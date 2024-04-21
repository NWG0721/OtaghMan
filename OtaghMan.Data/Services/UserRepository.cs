using OtaghMan.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OtaghMan.Data.Services
{
    public class UserRepository : IUsersRopository
    {
        OtaghMan_DBEntities db;
        public UserRepository(OtaghMan_DBEntities db)
        {
            this.db = db;
        }

        public bool AddUser(Users_tbl user)
        {
            try
            {
                db.Users_tbl.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                var user = GetUserByID(userId);
                DeleteUser(userId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUser(Users_tbl user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Users_tbl> GetAllUsers()
        {
            return db.Users_tbl.ToList();
        }

        public Users_tbl GetUserByID(int userid)
        {
            return db.Users_tbl.Find(userid);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public bool UpdateUserInfo(Users_tbl user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
