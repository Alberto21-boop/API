using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBack.DataBase;
using TreinamentoBack.Model;
using Dapper;


namespace TreinamentoBack.Service
{
    public abstract class BaseService<T> : IDisposable where T : class
    {
        private bool disposedValue;

        public BaseEntity<T> Entity { get; set; }

        public BaseService(BaseEntity<T> entity)
        {
            Entity = entity;
        }

        public virtual void Insert(T Model)
        {
            Entity.Insert(Model);
        }
        public virtual void Update(T Model)
        {
            Entity.Update(Model);
        }
        public virtual void Delete(object id)
        {
            Entity.Delete(id);
        }
        public virtual T Recover(object id)
        {
            return Entity.Recover(id);
        }

        public virtual List<T> List()
        {
            return Entity.List();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(Entity != null)
                    {
                        Entity.Dispose();
                    }
                }
                disposedValue = true;
            }
        }
        public virtual void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
