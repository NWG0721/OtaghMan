using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Repositories
{
    public interface IStorageRepository
    {

        //------------------------------| SELECT |------------------------------//
        List<Storages_tbl> GetAllStorages();

        Storages_tbl GetStorageByID(int StorageId);

        //------------------------------| SELECT |------------------------------//

        //------------------------------| INSERT |------------------------------//

        bool AddStorage(Storages_tbl Storage);

        //------------------------------| INSERT |------------------------------//

        //------------------------------| UPDATE |------------------------------//

        bool UpdateStorageInfo(Storages_tbl Storage);

        //------------------------------| UPDATE |------------------------------//

        //------------------------------| DELETE |------------------------------//

        bool DeleteStorage(int StorageId);

        bool DeleteStorage(Storages_tbl Storage);

        //------------------------------| DELETE |------------------------------//

        //------------------------------| SAVECHANGES |------------------------------//

        void SaveChanges();

        //------------------------------| SAVECHANGES |------------------------------//

    }
}
