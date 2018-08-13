using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace WebApiFeeding.repository
{
    public class Repository <T> :IRepository <T> where T: class
    {
        private USERSEntities context;
        private DbSet < T > dbSet;

        public Repository()
        {
            context =new USERSEntities();
            dbSet=context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }
        public T Insert (T obj)
        {
            dbSet.Add(obj);
            //Save();
            return obj;
        }
        public void Delete(object Id)
        {
            T entityToDelete = dbSet.Find(Id);
            Delete(entityToDelete);
        }
        public void Delete(T entityToDelete) 
           
 {  
        if (context.Entry(entityToDelete).State == EntityState.Detached) {  
            dbSet.Attach(entityToDelete);  
        //    -- -- -- -- -- -- -- -- -- -- -- -- > it add the row like in particular table, particular field, particular value has been deleted with timestamps.  
        }  
        dbSet.Remove(entityToDelete);  
    }  
    public T Update(T obj)  {  
        dbSet.Attach(obj);  
        context.Entry(obj).State = EntityState.Modified;  
        
        Save();  
        return obj;  
    }  
    public void Save() {  
        try {  
            context.SaveChanges();  
            
        } catch (DbEntityValidationException dbEx) {  
            foreach(var validationErrors in dbEx.EntityValidationErrors) {  
                foreach(var validationError in validationErrors.ValidationErrors) {  
                    System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);  
                  
                }  
            }  
        }  
    }  
    protected virtual void Dispose(bool disposing)  {  
        if (disposing) {  
            if (context != null) {  
                context.Dispose();  
                context = null;  
            }  
        }  
    }  
    }
}