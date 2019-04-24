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
    class OrderService: Service<Order, OrderDto, OrderFilter>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) :
           base(unitOfWork)
        {

        }
        protected override OrderDto MapToDto(Order entity)
        {

        }
        protected override Order MapToEntity(OrderDto dto)
        {

        }

        public override OrderDto Get(string id)
        {

        }
        public override IEnumerable<OrderDto> Get(OrderFilter filter)
        {

        }
        public override void Add(OrderDto dto)
        {

        }
        public override void Remove(string id)
        {

        }
        public override void Update(OrderDto dto)
        {

        }
    }
}
