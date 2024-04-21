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
        private IEquipmentRepository _storageRepository;

        public IEquipmentRepository EquipmentRepository
        {
            get
            {
                if (_storageRepository == null)
                {
                    _storageRepository = new EquipmentRepository(db);
                }
                return _storageRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
