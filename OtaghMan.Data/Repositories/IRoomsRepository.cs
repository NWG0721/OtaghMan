using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaghMan.Data.Repositories
{
    public interface IRoomsRepository
    {

        //------------------------------| SELECT |------------------------------//
        List<Rooms_tbl> GetAllRooms();

        Rooms_tbl GetRoomByID(int roomId);

        //------------------------------| SELECT |------------------------------//

        //------------------------------| INSERT |------------------------------//

        bool AddRoom(Rooms_tbl room);

        List<Rooms_tbl> GetRoomsByFillter(string parameter);

        //------------------------------| INSERT |------------------------------//

        //------------------------------| UPDATE |------------------------------//

        bool UpdateRoomInfo(Rooms_tbl room);

        //------------------------------| UPDATE |------------------------------//

        //------------------------------| DELETE |------------------------------//

        bool DeleteRoom(int roomId);

        bool DeleteRoom(Rooms_tbl room);

        //------------------------------| DELETE |------------------------------//



    }
}
