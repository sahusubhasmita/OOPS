using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementOops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation

            HotelAdminstration hotelAdminstration = new HotelAdminstration();

            hotelAdminstration.HotelDetails();

            // Polymorphism and Inheritance 

            HotelItemDescription hotelItemDescription = new HotelItemDescription();

            hotelItemDescription.Items("Panner Butter Masal", "Chicken Curry");

            hotelItemDescription.Items(7, 10);

            CookingStaff cookingStaff = new CookingStaff();

            cookingStaff.CookName = "Kamal";

            cookingStaff.Age = "35";

            cookingStaff.Id = "12345678934";

            cookingStaff.ItemStoreRoom();

            cookingStaff.Details();

            // Abstract class 

            HotelGuest hotelGuest = new HotelGuest();

            hotelGuest.newGuest();
        }
    }
}
