using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Interfaces.Data
{
    public interface IGenericRepository
    {
        void Create<TEntity>(TEntity item) where TEntity : class;
        IQueryable<TEntity> Get<TEntity>(params string[] navigationProperties) where TEntity : class;
        void Remove<TEntity>(TEntity item);
        void Update<TEntity>(TEntity item);
    }
}
