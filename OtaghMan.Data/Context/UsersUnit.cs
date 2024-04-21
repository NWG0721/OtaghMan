using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OtaghMan.Data.Services;
using OtaghMan.Data.Repositories;

namespace OtaghMan.Data.Context
{
    public class UsersUnit:IDisposable
    {
        OtaghMan_DBEntities db = new OtaghMan_DBEntities();
        private IUsersRopository _usersRepository;

        public IUsersRopository UsersRopository
        {
            get
            {
                if (_usersRepository == null)
                {
                    _usersRepository = new UserRepository(db);
                }
                return _usersRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
