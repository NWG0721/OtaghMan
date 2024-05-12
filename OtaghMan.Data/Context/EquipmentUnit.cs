using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OtaghMan.Data.Services;
using OtaghMan.Data.Repositories;

namespace OtaghMan.Data.Context
{
    public class EquipmentUnit:IDisposable
    {
        OtaghMan_DBEntities db = new OtaghMan_DBEntities();
        private IEquipmentRepository _equipmentRepository;

        public IEquipmentRepository EquipmentRepository
        {
            get
            {
                if (_equipmentRepository == null)
                {
                    _equipmentRepository = new EquipmentRepository(db);
                }
                return _equipmentRepository;
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
