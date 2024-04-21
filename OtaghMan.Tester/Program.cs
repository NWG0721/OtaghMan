using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtaghMan.Data;
using OtaghMan.Data.Context;
using OtaghMan.Data.Repositories;
using OtaghMan.Data.Services;

namespace OtaghMan.Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomsUnit db = new RoomsUnit();
            var list = db.RoomsRepository.GetAllRooms();
        }
    }
}
