using Cel.Modelo.Dominio.Interfaces.Repository;
using Cel.Modelo.Persistencia.EF.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel.Modelo.Persistencia.EF.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContext _modeloDbContext;

        public RepositoryBase()
        {
        }

        public void Add(TEntity obj)
        {
            _modeloDbContext.Set<TEntity>().Add(obj);
          //  _modeloDbContext.SaveChanges();
        }

        public TEntity AddAsyncWithReturn(TEntity obj)
        {
            int id = 0;

            AddAsync(obj, (idOject) =>
            {
                id = idOject;

            });

            return GetById(id);
        }

        public async void AddAsync(TEntity obj, Action<int> callBack)
        {
            _modeloDbContext.Set<TEntity>().Add(obj);
            await _modeloDbContext.SaveChangesAsync().ContinueWith((taskAnterior) =>
            {
                callBack(taskAnterior.Result);
            });
        }

        public virtual TEntity GetById(int id)
        {
            return _modeloDbContext.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetALL()
        {
            return _modeloDbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetALLAsNoTracking()
        {
            return _modeloDbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public void Update(TEntity obj)
        {
            //  _modeloDbContext.Entry(obj).State = EntityState.Modified;
            // _modeloDbContext.Set<TEntity>().Attach(obj);
          //  _modeloDbContext.SaveChanges();

        }

        public void Remove(TEntity obj)
        {
            _modeloDbContext.Set<TEntity>().Attach(obj);
            _modeloDbContext.Entry(obj).State = EntityState.Deleted;
         //   _modeloDbContext.SaveChanges();
            // ModeloDbContext.Set<TEntity>().Remove(obj);
        }

        public void Dispose()
        {
            _modeloDbContext.Dispose();
        }

        public void SaveChanges()
        {
            _modeloDbContext.SaveChanges();
        }
    }
}
