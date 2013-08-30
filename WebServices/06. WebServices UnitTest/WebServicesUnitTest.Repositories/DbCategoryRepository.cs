using System;
using WebServicesUnitTest.Model;
using WebServicesUnitTest.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace WebServicesUnitTest.Repositories
{
    public interface ICategoryRepository : IRepository<Schools>
    {
    }

    public class DbCategoryRepository : ICategoryRepository
    {
        private DbContext dbContext;
        private DbSet<Schools> entitySet;

        public DbCategoryRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Schools>();
        }

        public IQueryable<Schools> Find(Expression<Func<Schools, int, bool>> predicate)
        {
            return this.entitySet.Where(predicate);
        }

        public Schools Add(Schools entity)
        {
            this.entitySet.Add(entity);
            this.dbContext.SaveChanges();
            return entity;
        }

        public Schools Update(int id, Schools entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var entity = this.entitySet.Find(id);
            if (entity != null)
            {
                this.entitySet.Remove(entity);
                this.dbContext.SaveChanges();
            }
        }

        public Schools Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Schools> All()
        {
            return this.entitySet;
        }
    }
}
