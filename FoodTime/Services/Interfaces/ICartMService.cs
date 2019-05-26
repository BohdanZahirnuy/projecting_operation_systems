using Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICartMService : IService<CartMDto>
    {
        IEnumerable<CartMDto> GetList(string email);
        CartMDto GetFood(string id, string userId);
        void RemoveFood(string FoodId, string email);
        void RemoveList(string email);
    }
}
