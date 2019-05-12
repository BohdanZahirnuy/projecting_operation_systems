using FoodTime.Data.Interfaces;
using FoodTime.Data.Models;
using Services.Dto;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Services.Implementation
{
    public class CartMService : Service<CartM, CartMDto>, ICartMService
    {
        public CartMService(IUnitOfWork unitOfWork) :
          base(unitOfWork)
        {

        }
        protected override CartMDto MapToDto(CartM entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            CartMDto dto = new CartMDto
            {
                Id = entity.Id,
                Quanity = entity.Quanity
            };

            return dto;
        }
        protected override CartM MapToEntity(CartMDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            CartM entity = new CartM
            {
                Id = dto.Id,
                Quanity = dto.Quanity
            };

            return entity;
        }

        public override CartMDto Get(string id)
        {
            CartM entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                return null;
            }

            return MapToDto(entity);
        }
        public override IEnumerable<CartMDto> Get()
        {
            List<CartM> entities = Repository
              .Get()
              .ToList();

            if (!entities.Any())
            {
                return null;
            }

            return entities.Select(e => MapToDto(e));
        }
        public override void Add(CartMDto dto)
        {
            CartM checkEntity = Repository
               .Get(e => e.Id == dto.Id)
               .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            CartM entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Remove(string id)
        {
            CartM entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Update(CartMDto dto)
        {
            CartM entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }


            entity.Quanity = dto.Quanity;
            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }

    }
}


