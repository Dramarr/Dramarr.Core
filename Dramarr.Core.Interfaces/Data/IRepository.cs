using System;
using System.Collections.Generic;
using System.Text;

namespace Dramarr.Core.Interfaces.Data
{
    public interface IRepository<T>
    {
        List<T> Select();

        T SelectById(Guid id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
