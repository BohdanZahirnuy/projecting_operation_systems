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
    public class UserService : Service<User, UserDto>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) :
        base(unitOfWork)
        {

        }

        public override void Add(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public override UserDto Get(string name)
        {
            {
                User entity = Repository
                .Get(e => e.UserName.ToString() == name)
                .SingleOrDefault();

                if (entity == null)
                {
                    throw new NullReferenceException();
                }

                return MapToDto(entity);
            }
        }

        public override IEnumerable<UserDto> Get()
        {
            throw new NotImplementedException();
        }

        public override void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public override void Update(UserDto dto)
        {
            throw new NotImplementedException();
        }

        protected override UserDto MapToDto(User entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            UserDto dto = new UserDto
            {
                Id = entity.Id,
                UserName = entity.UserName,
                Address = entity.Address,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber
            };

            return dto;
        }

        protected override User MapToEntity(UserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
