using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementOops
{ 
    class HotelAdminstration
    {
        // encapsulated

        string HotelName = "Taj";
        string GstNo = "A35555JK7890";
        string HotelLocation = "Bangalore";
        int Pin = 560066;
        string ShowHotelDetails;

        public void HotelDetails()
        {
            ShowHotelDetails = "Hotel name is " + " " + HotelName + " " + ",GST No is" + " " + GstNo

                               + " " + ",hotel location is" + " " + HotelLocation + " " + "and pin is" + " " + Pin;

            Console.WriteLine(ShowHotelDetails);
            Console.ReadLine();
        }
    }
}
