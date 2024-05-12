using OtaghMan.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace OtaghMan.Data.Services
{
    public class StorageRepository : IStorageRepository
    {
        OtaghMan_DBEntities db;
        public StorageRepository(OtaghMan_DBEntities db)
        {
            this.db = db;
        }

        public bool AddStorage(Storages_tbl Storage)
        {
            try
            {
                db.Storages_tbl.Add(Storage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteStorage(int StorageId)
        {
            try
            {
                var storage = GetStorageByID(StorageId);
                DeleteStorage(storage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteStorage(Storages_tbl Storage)
        {
            try
            {
                db.Entry(Storage).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Storages_tbl> GetAllStorages()
        {
            return db.Storages_tbl.ToList();
        }

        public Storages_tbl GetStorageByID(int storageId)
        {
            return db.Storages_tbl.Find(storageId);
        }

        public Storages_tbl GetStorageByName(string storageName, int roomID)
        {
            return db.Storages_tbl.Where(store => store.STORAGE_NAME == storageName && store.ROOM_ID == roomID).SingleOrDefault();
        }

        public List<Storages_tbl> GetStorageByRoom(int roomID)
        {
            return db.Storages_tbl.Where(store => store.ROOM_ID == roomID).ToList();
        }

        public List<Storages_tbl> GetStorages(int storageId)
        {
            return db.Storages_tbl.Where(storage => storage.ROOM_ID == storageId).ToList();
        }

        public List<Storages_tbl> GetStoragesByFillter(string parameter)
        {
            return db.Storages_tbl.Where(storage => storage.STORAGE_NAME == parameter).ToList();
        }

        public bool UpdateStorageInfo(Storages_tbl Storage)
        {
            try
            {
                var local = db.Set<Storages_tbl>().Local.FirstOrDefault(f => f.STORAGE_ID == Storage.STORAGE_ID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(Storage).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
