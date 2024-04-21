using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtaghMan.Data.Repositories;
using System.Data.Entity;

namespace OtaghMan.Data.Services
{
    public class EquipmentRepository : IEquipmentRepository
    {
        OtaghMan_DBEntities db;
       public EquipmentRepository(OtaghMan_DBEntities db)
        {
            this.db = db;
        }

        public bool AddEquipment(Equipment_tbl equipment)
        {
            try
            {
                db.Equipment_tbl.Add(equipment);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEquipment(int equipmentId)
        {
            try
            {
                var storage = GetEquipmentByID(equipmentId);
                DeleteEquipment(equipmentId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEquipment(Equipment_tbl equipment)
        {
            try
            {
                db.Entry(equipment).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Equipment_tbl> GetAllEquipment()
        {
            return db.Equipment_tbl.ToList();
        }

        public Equipment_tbl GetEquipmentByID(int Equipmentid)
        {
            return db.Equipment_tbl.Find(Equipmentid);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public bool UpdateEquipmentInfo(Equipment_tbl equipment)
        {
            try
            {
                db.Entry(equipment).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
