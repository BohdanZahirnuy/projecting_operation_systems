using System;
using System.Collections.Generic;
using System.Text;
using Services.Dto;
using Services.Filters;

namespace Services.Interfaces
{
    public interface IFoodService : IService<FoodDto, FoodFilter>
    {

    }
}
