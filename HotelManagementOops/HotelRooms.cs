using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementOops
{
    //Abstract Class
    abstract class HotelRooms
    {
        public abstract void newGuest();

            public void HotelRoom()
            {
                Console.WriteLine("Total Gusets are 5 and total 5 rooms are available");
            }

    }
    class HotelGuest : HotelRooms // Inheritance
     {
            public override void newGuest()
            {
                Console.WriteLine("Total NewGusets are 10 and there is no room available for new Guest");

                Console.ReadLine();
            }
     }
    
}

