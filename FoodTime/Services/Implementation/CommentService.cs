using System;
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
    class CommentService: Service<Comment, CommentDto, CommentFilter>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork) :
        base(unitOfWork)
        {

        }
        protected override CommentDto MapToDto(Comment entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            CommentDto dto = new CommentDto
            {
                Id = entity.Id,
                Content = entity.Content,
                Date = entity.Date,
                Owner = entity.Owner,
                DishId = entity.DishId
            };

            return dto;
        }
        protected override Comment MapToEntity(CommentDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            Comment entity = new Comment
            { 
                Id = dto.Id,
                Content = dto.Content,
                Date = dto.Date,
                Owner = dto.Owner,
                DishId = dto.DishId
            };

            return entity;
        }

        public override CommentDto Get(string id)
        {
            Comment entity = Repository
             .Get(e => e.Id.ToString() == id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            return MapToDto(entity);
        }
        public override IEnumerable<CommentDto> Get(CommentFilter filter)
        {
            Func<Comment, bool> predicate = GetFilter(filter);
            List<Comment> entities = Repository
              .Get(p => predicate(p))
              .ToList();

            if (!entities.Any())
            {
                throw new NullReferenceException();
            }

            return entities.Select(e => MapToDto(e));
        }
        public override void Add(CommentDto dto)
        {
            Comment checkEntity = Repository
               .Get(e => e.Id == dto.Id)
               .SingleOrDefault();

            if (checkEntity != null)
            {
                throw new DuplicateNameException();
            }

            Comment entity = MapToEntity(dto);
            Repository.Add(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Remove(string id)
        {
            Comment entity = Repository
            .Get(e => e.Id.ToString() == id)
            .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            Repository.Remove(entity);
            _unitOfWork.SaveChanges();
        }
        public override void Update(CommentDto dto)
        {
            Comment entity = Repository
             .Get(e => e.Id == dto.Id)
             .SingleOrDefault();

            if (entity == null)
            {
                throw new NullReferenceException();
            }

            entity.Id = dto.Id;
            entity.Content = dto.Content;
            entity.Date = dto.Date;
            entity.Owner = dto.Owner;
            entity.DishId = dto.DishId;

            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }
        private Func<Comment, bool> GetFilter(CommentFilter filter)
        {
            Func<Comment, bool> result = e => true;
            if (!String.IsNullOrEmpty(filter?.Id.ToString()))
            {
                result += e => e.Id == filter.Id;
            }

            return result;
        }
    }
}
