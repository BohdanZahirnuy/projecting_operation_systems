﻿using System;
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
    class FoodService: Service<Food, FoodDto, FoodFilter>, IFoodService
    {
        public FoodService(IUnitOfWork unitOfWork) :
          base(unitOfWork)
        {

        }
        protected override FoodDto MapToDto(Food entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            FoodDto dto = new FoodDto
            {
                Id = entity.Id,
                Category = entity.Category,
                Componets = entity.Componets,
                ExtraInfo = entity.ExtraInfo,
                Name = entity.Name,
                Price = entity.Price,
                Weight = entity.Weight
            };

            return dto;
        }
        protected override Food MapToEntity(FoodDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Food entity = new Food
            {
                Id = dto.Id,
                Category = dto.Category,
                Componets = dto.Componets,
                ExtraInfo = dto.ExtraInfo,
                Name = dto.Name,
                Price = dto.Price,
                Weight = dto.Weight
            };

            return entity;
        }

        public override FoodDto Get(string id)
        {
            Food entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            return MapToDto(entity);
        }
        public override IEnumerable<FoodDto> Get(FoodFilter filter)
        {
            Func<Food, bool> predicate = GetFilter(filter);
            List<Food> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new NullReferenceException();
            }

            return entities.Select(e => MapToDto(e));
        }
        public override void Add(FoodDto dto)
        {
            Food checkEntity = Repository
               .Get(e => e.Id == dto.Id)
               .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            Food entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Remove(string id)
        {
            Food entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Update(FoodDto dto)
        {
            Food entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }


            entity.Category = dto.Category;
            entity.Componets = dto.Componets;
            entity.ExtraInfo = dto.ExtraInfo;
            entity.Name = dto.Name;
            entity.Price = dto.Price;
            entity.Weight = dto.Weight;
            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }
        private Func<Food, bool> GetFilter(FoodFilter filter)
        {
            Func<Food, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Id.ToString()))
            {
                result += e => e.Id == filter.Id;
            }

            return result;
        }
    }
}
