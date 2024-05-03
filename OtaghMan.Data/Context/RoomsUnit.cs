using OtaghMan.Data.Repositories;
using OtaghMan.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Context
{
    public class RoomsUnit : IDisposable
    {
        OtaghMan_DBEntities db = new OtaghMan_DBEntities();
        private IRoomsRepository _roomRepository;

        public IRoomsRepository RoomsRepository
        {
            get
            {
                if (_roomRepository == null)
                {
                    _roomRepository = new RoomRepository(db);
                }
                return _roomRepository;
            }
        }
        //------------------------------| SAVECHANGES |------------------------------//

       public void SaveChanges()
        { 
        db.SaveChanges();
        }

        //------------------------------| SAVECHANGES |------------------------------//
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
