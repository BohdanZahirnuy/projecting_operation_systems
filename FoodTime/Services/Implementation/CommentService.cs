using System;
using System.Collections.Generic;
using System.Text;
using FoodTime.Data.Models;
using FoodTime.Data.Interfaces;
using Services.Interfaces;
using Services.Dto;
using System.Data;
using System.Linq;

namespace Services.Implementation
{
    public  class CommentService : Service<Comment, CommentDto>, ICommentService
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
                Message = entity.Message,
                Date = entity.Date,
                FoodId = entity.FoodId

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
                Message = dto.Message,
                Date = dto.Date,
                FoodId = dto.FoodId
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
       
        public override IEnumerable<CommentDto> Get()
        {
            
            List<Comment> entities = Repository
              .Get()
              .ToList();

            

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
            entity.Message = dto.Message;
            entity.Date = dto.Date;
            entity.FoodId = dto.FoodId;

            Repository.Update(entity);
            _unitOfWork.SaveChanges();
        }
      
    }
}
