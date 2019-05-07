using System;
using System.Collections.Generic;
using System.Text;
using Services.Filters;
using Services.Dto;

namespace Services.Interfaces
{
    public interface ICartService : IService<CartDto, CartFilter>
    {
        
    }
}
