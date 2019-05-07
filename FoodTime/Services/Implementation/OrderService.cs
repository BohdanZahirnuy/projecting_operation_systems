using System;
using System.Collections.Generic;
using System.Text;
using FoodTime.Data.Models;
using FoodTime.Data.Interfaces;
using Services.Interfaces;
using Services.Dto;
using Services.Filters;
using System.Data;
using System.Linq;


namespace Services.Implementation
{
    public class OrderService : Service<Order, OrderDto, OrderFilter>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) :
           base(unitOfWork)
        {

        }
        protected override OrderDto MapToDto(Order entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            OrderDto dto = new OrderDto
            {
                Id = entity.Id,
                Info = entity.Info,
                User = entity.User,
                Address = entity.Address,
                Date = entity.Date
            };

            return dto;
        }
        protected override Order MapToEntity(OrderDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Order entity = new Order
            {
                Id = dto.Id,
                Info = dto.Info,
                User = dto.User,
                Address = dto.Address,
                Date = dto.Date
            };

            return entity;
        }
        public override OrderDto Get(string id)
        {
            Order entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            return MapToDto(entity);
        }
        public override IEnumerable<OrderDto> Get(OrderFilter filter)
        {
            Func<Order, bool> predicate = GetFilter(filter);
            List<Order> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new NullReferenceException();
            }

            return entities.Select(e => MapToDto(e));
        }
        public override void Add(OrderDto dto)
        {
            Order checkEntity = Repository
              .Get(e => e.Id == dto.Id)
              .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            Order entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Remove(string id)
        {
            Order entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Update(OrderDto dto)
        {
            Order entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }
            entity.Id = dto.Id;
            entity.Info = dto.Info;
            entity.User = dto.User;
            entity.Address = dto.Address;
               entity.Date = dto.Date;

            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }
        private Func<Order, bool> GetFilter(OrderFilter filter)
        {
            Func<Order, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Id.ToString()))
            {
                result += e => e.Id == filter.Id;
            }

            return result;
        }
    }
}
