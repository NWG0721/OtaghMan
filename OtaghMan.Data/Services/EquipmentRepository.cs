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
                DeleteEquipment(storage);
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

        public List<Equipment_tbl> FindEquipmentByStorageID(int storageId)
        {
            return db.Equipment_tbl.Where(equip=> equip.EQUIPMENT_STORAGE == storageId).ToList();
        }

        public List<Equipment_tbl> GetAllEquipment()
        {
            return db.Equipment_tbl.ToList();
        }

        public Equipment_tbl GetEquipmentByID(int Equipmentid)
        {
            return db.Equipment_tbl.Find(Equipmentid);
        }

        public List<Equipment_tbl> GetTheActualEquipments(int storageId, int userID)
        {
            return db.Equipment_tbl.Where(equip => equip.EQUIPMENT_STORAGE == storageId && equip.EQUIPMENT_OWNER == userID).ToList();
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
