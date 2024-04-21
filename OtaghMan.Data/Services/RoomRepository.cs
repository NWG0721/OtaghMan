using OtaghMan.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtaghMan.Data.Repositories;
using System.Data.Entity;

namespace OtaghMan.Data.Services
{
    public class RoomRepository : IRoomsRepository
    {
        OtaghMan_DBEntities db;
        public RoomRepository(OtaghMan_DBEntities db)
        {
            this.db = db;
        }

        public bool AddRoom(Rooms_tbl room)
        {
            try
            {
                db.Rooms_tbl.Add(room);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRoom(int roomId)
        {
            try
            {
                var room = GetRoomByID(roomId);
                DeleteRoom(room);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRoom(Rooms_tbl room)
        {
            try
            {
                db.Entry(room).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 

        public List<Rooms_tbl> GetAllRooms()
        {
            return db.Rooms_tbl.ToList();
        }

        public Rooms_tbl GetRoomByID(int roomId)
        {
            return db.Rooms_tbl.Find(roomId );
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public bool UpdateRoomInfo(Rooms_tbl room)

        {
            try
            {
                db.Entry(room).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
