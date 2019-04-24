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
    class CommentService: Service<Comment, CommentDto, CommentFilter>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork) :
        base(unitOfWork)
        {

        }
        protected override CommentDto MapToDto(Comment entity)
        {

        }
        protected override Comment MapToEntity(CommentDto dto)
        {

        }

        public override CommentDto Get(string id)
        {

        }
        public override IEnumerable<CommentDto> Get(CommentFilter filter)
        {

        }
        public override void Add(CommentDto dto)
        {

        }
        public override void Remove(string id)
        {

        }
        public override void Update(CommentDto dto)
        {

        }
    }
}
