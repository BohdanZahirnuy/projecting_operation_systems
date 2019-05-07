using System;
using System.Collections.Generic;
using System.Text;
using Services.Dto;


namespace Services.Interfaces
{
    public interface IService<TDto>
    {
        TDto Get(string id);
        IEnumerable<TDto> Get();
        void Add(TDto dto);
        void Remove(string id);
        void Update(TDto dto);

    }
}
