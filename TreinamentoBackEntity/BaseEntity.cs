using System;
using Dapper;
using System.Collections.Generic;
using Npgsql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using TreinamentoBack.Model;

namespace TreinamentoBack.DataBase
{
    public abstract class BaseEntity<T> : IDisposable where T : class
    {
        private readonly string strConexao = @"Server=localhost;Port=5432;UserId=postgres;Password=alberto021;Database=BancoFinalPratica";

        private bool disposedValue;

        internal IDbConnection Db { get; set; }

        public BaseEntity()
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            Db = new NpgsqlConnection(strConexao);
        }
        public virtual void Insert(T Model)
        {
            Db.Insert(Model);
        }
        public virtual void Update(T Model)
        {
            Db.Update(Model);
        }
        public virtual void Delete(object id)
        {
            Db.Delete<T>(id);
        }
        public virtual T Recover(object id)
        {
            T Model = Db.Get<T>(id);
            return Model;
        }
        public virtual List<T> List()
        {
            List<T> list = Db.GetList<T>().ToList();
            return list;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (Db != null)
                    {
                        Db.Dispose();
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