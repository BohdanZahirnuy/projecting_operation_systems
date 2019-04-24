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
    class CartService: Service<Cart, CartDto, CartFilter>, ICartService
    {
        public CartService(IUnitOfWork unitOfWork) :
             base(unitOfWork)
        {

        }
        protected override CartDto MapToDto(Cart entity)
        {

        }
        protected override Cart MapToEntity(CartDto dto)
        {

        }

        public override CartDto Get(string id)
        {

        }
        public override IEnumerable<CartDto> Get(CartFilter filter)
        {

        }
        public override void Add(CartDto dto)
        {

        }
        public override void Remove(string id)
        {

        }
        public override void Update(CartDto dto)
        {

        }
    }
}
