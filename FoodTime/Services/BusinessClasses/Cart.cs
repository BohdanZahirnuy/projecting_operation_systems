using Services.Interfaces;
using Services.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using Services.Dto;

namespace Services.BusinessClasses
{
  public class Cart
    {
        List<FoodDto> foods;
        Dictionary<FoodDto, int> orders = new Dictionary<FoodDto, int>();
        IFoodService serv;
        public Cart(IFoodService _serv )
        {
            serv = _serv;
        }
        public void Add(string id)
        {
            if(orders.ContainsKey(serv.Get(id)))
            {
                int prevValue;
                orders.TryGetValue(serv.Get(id),out prevValue);
                orders[serv.Get(id)] = prevValue + 1;
            }
            else
            {
                orders.Add(serv.Get(id),1);
            }
        }
        
    }
}
