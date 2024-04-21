using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Repositories
{
    public interface IEquipmentRepository
    {

        //------------------------------| SELECT |------------------------------//
        List<Equipment_tbl> GetAllEquipment();

        Equipment_tbl GetEquipmentByID(int equipmentId);

        //------------------------------| SELECT |------------------------------//

        //------------------------------| INSERT |------------------------------//

        bool AddEquipment(Equipment_tbl equipment);

        //------------------------------| INSERT |------------------------------//

        //------------------------------| UPDATE |------------------------------//

        bool UpdateEquipmentInfo(Equipment_tbl equipment);

        //------------------------------| UPDATE |------------------------------//

        //------------------------------| DELETE |------------------------------//

        bool DeleteEquipment(int roomId);

        bool DeleteEquipment(Equipment_tbl equipment);

        //------------------------------| DELETE |------------------------------//

        //------------------------------| SAVECHANGES |------------------------------//

        void SaveChanges();

        //------------------------------| SAVECHANGES |------------------------------//

    }
}
