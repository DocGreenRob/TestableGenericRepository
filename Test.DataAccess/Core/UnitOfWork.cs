using System;

namespace Test.DataAccess.Core
{
    public class UnitOfWork : IUnitOfWork
    {

        private DatabaseObject db;

        public UnitOfWork() : this(new DatabaseObject()) { }

        public UnitOfWork(DatabaseObject dbContext)
        {
            db = dbContext;
        }

        public T GetRepository<T>() where T : class
        {
            var type = typeof(T);
            var constructor = type.GetConstructor(new Type[0]);

            if (constructor == null)
            {
                var result = (T)Activator.CreateInstance(typeof(T), db, this);
                if (result != null)
                {
                    return result;
                }
                return null;
            }
            else
            {
                var result = (T)Activator.CreateInstance(typeof(T));
                if (result != null)
                {
                    return result;
                }
                return null;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
