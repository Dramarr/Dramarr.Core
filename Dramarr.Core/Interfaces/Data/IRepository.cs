using System;
using System.Collections.Generic;
using System.Text;

namespace Dramarr.Core.Interfaces.Data
{
    /// <summary>
    /// IRepository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        List<T> Select();

        T SelectById(Guid id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
