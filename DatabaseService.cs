using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LibManagementSystem_Updated.Models;

namespace LibManagementSystem_Updated
{
    //public class DatabaseService<T> where T : class
    //{
    //    private readonly MyDbContext _context;

    //    public DatabaseService()
    //    {
    //        _context = new MyDbContext();
    //    }

    //    public List<T> GetAll()
    //    {
    //        return _context.Set<T>().ToList();
    //    }

    //    public void Add(T entity)
    //    {
    //        _context.Set<T>().Add(entity);
    //        _context.SaveChanges();
    //    }

    //    public void Update(T entity)
    //    {
    //        _context.Entry(entity).State = EntityState.Modified;
    //        _context.SaveChanges();
    //    }

    //    public void Delete(T entity)
    //    {
    //        _context.Set<T>().Remove(entity);
    //        _context.SaveChanges();
    //    }

    public class DatabaseService<T> where T : class
    {
        private readonly MyDbContext myDbContext;

        public DatabaseService()
        {
            myDbContext = new MyDbContext();
        }

        //REtrieve all records
        public List<T> GetAll() 
        {
            return myDbContext.Set<T>().ToList();
        }

        //This method inserts a new row into the database.
        public void Add(T entity)
        {
            myDbContext.Set<T>().Add(entity);
            myDbContext.SaveChanges();
        }

        //This allows you to update an existing record.
        public void Update(T entity) 
        {
            myDbContext.Entry(entity).State = EntityState.Modified;
            myDbContext.SaveChanges();
        }

        public void Delete(T entity) 
        {
            myDbContext.Set<T>().Remove(entity);
            myDbContext.SaveChanges();
        }

        //public void SaveOrUpdate(T entity)
        //{
        //    var entry = myDbContext.Entry(entity);

        //    if (entry.State == EntityState.Detached)
        //    {
        //        var existingEntity = myDbContext.Set<T>().Find(GetPrimaryKey(entity));

        //        if (existingEntity != null)
        //        {
        //            myDbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
        //        }
        //        else
        //        {
        //            myDbContext.Set<T>().Add(entity);
        //        }
        //    }

        //    myDbContext.SaveChanges();
        //}


    }
}
