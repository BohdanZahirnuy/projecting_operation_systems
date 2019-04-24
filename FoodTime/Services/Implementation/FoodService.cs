using System;
using System.Collections.Generic;
using System.Text;
using FoodTime.Data.Models;
using FoodTime.Data.Interfaces;
using Services.Interfaces;
using Services.Dto;
using Services.Filters;

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

        }
        protected override Food MapToEntity(FoodDto dto)
        {

        }

        public override FoodDto Get(string id)
        {

        }
        public override IEnumerable<FoodDto> Get(FoodFilter filter)
        {

        }
        public override void Add(FoodDto dto)
        {

        }
        public override void Remove(string id)
        {

        }
        public override void Update(FoodDto dto)
        {

        }
    }
}
