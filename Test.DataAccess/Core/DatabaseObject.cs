using System;

namespace Test.DataAccess.Core
{
    public class DatabaseObject
    {
        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
