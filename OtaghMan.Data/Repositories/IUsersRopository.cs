using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Repositories
{
    public interface IUsersRopository
    {

        //------------------------------| SELECT |------------------------------//
        List<Users_tbl> GetAllUsers();

        Users_tbl GetUserByID(int userid);

        //------------------------------| SELECT |------------------------------//

        //------------------------------| INSERT |------------------------------//

        bool AddUser(Users_tbl user);

        //------------------------------| INSERT |------------------------------//

        //------------------------------| UPDATE |------------------------------//

        bool UpdateUserInfo(Users_tbl user);

        //------------------------------| UPDATE |------------------------------//

        //------------------------------| DELETE |------------------------------//

        bool DeleteUser(int userId);

        bool DeleteUser(Users_tbl user);

        //------------------------------| DELETE |------------------------------//

        //------------------------------| SAVECHANGES |------------------------------//

        void SaveChanges();

        //------------------------------| SAVECHANGES |------------------------------//
    }
}
