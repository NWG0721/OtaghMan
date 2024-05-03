using OtaghMan.Data.Repositories;
using OtaghMan.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Context
{
    public class StorageUnit : IDisposable
    {
        OtaghMan_DBEntities db = new OtaghMan_DBEntities();
        private IStorageRepository _storageRepository;

        public IStorageRepository StorageRepository
        {
            get
            {
                if (_storageRepository == null)
                {
                    _storageRepository = new StorageRepository(db);
                }
                return _storageRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
