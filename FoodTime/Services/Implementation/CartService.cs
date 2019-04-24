using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using FoodTime.Data.Models;
using FoodTime.Data.Interfaces;
using Services.Interfaces;
using Services.Dto;
using Services.Filters;
using System.Linq;


namespace Services.Implementation
{
    class CartService: Service<Cart, CartDto, CartFilter>, ICartService
    {
        public CartService(IUnitOfWork unitOfWork) :
             base(unitOfWork)
        {

        }
        protected override CartDto MapToDto(Cart entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            CartDto dto = new CartDto
            {
                ID = entity.ID,
                Date = entity.Date,
                OrderList = entity.OrderList
            };

            return dto;
        }
        protected override Cart MapToEntity(CartDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Cart entity = new Cart
            {
                ID = dto.ID,
                Date = dto.Date,
                OrderList = dto.OrderList,
            };

            return entity;
        }

        public override CartDto Get(string id)
        {
            Cart entity = Repository
             .Get(e => e.ID.ToString() == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            return MapToDto(entity);
        }
        public override IEnumerable<CartDto> Get(CartFilter filter)
        {
            Func<Cart, bool> predicate = GetFilter(filter);
            List<Cart> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new NullReferenceException();
            }

            return entities.Select(e => MapToDto(e));
        }

        public override void Add(CartDto dto)
        {
            Cart checkEntity = Repository
               .Get(e => e.ID == dto.ID)
               .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            Cart entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public override void Remove(string id)
        {
            Cart entity = Repository
             .Get(e => e.ID.ToString() == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChanges();
        }

        public override void Update(CartDto dto)
        {
            Cart entity = Repository
             .Get(e => e.ID == dto.ID)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            entity.ID = dto.ID;
            entity.Date = dto.Date;
            entity.OrderList = dto.OrderList;

            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        private Func<Cart, bool> GetFilter(CartFilter filter)
        {
            Func<Cart, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.ID.ToString()))
            {
                result += e => e.ID == filter.ID;
            }

            return result;
        }
    }
}
