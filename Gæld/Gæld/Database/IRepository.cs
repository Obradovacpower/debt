using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Database
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity Get(int id);
        List<TEntity> Get();
        void Delete(int id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}