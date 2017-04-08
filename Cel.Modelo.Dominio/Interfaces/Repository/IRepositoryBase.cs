    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Dominio.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void AddAsync(TEntity obj, Action<int> callBack);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetALL();
        IEnumerable<TEntity> GetALLAsNoTracking();
        void Update(TEntity obj);
        void Remove(TEntity obj);

        void Dispose();

    }
}
