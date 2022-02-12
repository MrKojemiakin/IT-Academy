using Microsoft.EntityFrameworkCore;
using SurveyApp.Data.Context;
using SurveyApp.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Data.Repository
{
   

    public class SurveyRepository : IGenericRepository
    {
        DbContext _context;


        public SurveyRepository(DbContext context)
        {
            _context = context;

        }

        public SurveyRepository()
        {
            _context=new SurveyDBContext();
        }



        public IQueryable<TEntity> Get<TEntity>(params string[] navigationProperties) where TEntity : class
        {
            var query = _context.Set<TEntity>().AsQueryable();
            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            return query;
        }


        public void Create<TEntity>(TEntity item) where TEntity : class
        {
            _context.Add<TEntity>(item);
            _context.SaveChanges();
        }
        public void Update<TEntity>(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Remove<TEntity>(TEntity item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}
