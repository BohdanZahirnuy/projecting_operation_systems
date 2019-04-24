using System;
using System.Collections.Generic;
using System.Text;
using Services.Dto;
using Services.Filters;

namespace Services.Interfaces
{
    interface IOrderService:IService<OrderDto, OrderFilter>
    {

    }
}
