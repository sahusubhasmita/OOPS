using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementOops
{
    // Polymorphism and Inheritance
    class HotelItemDescription
    {
        // variable declaration

      //  public string staffHotel1 = "Gaurav";
      //  public string staffHotel2 = "Tina";
      //  public string staffHotel3 = "Suraj";
      //  public string staffDetails = "Mani";

        // method declaration
       // public void HotelManagement()
      //  {
      //      staffDetails = "Staffs are :" + " " + staffHotel1 + " " + staffHotel2 + " " + staffHotel3;
      //      Console.WriteLine(staffDetails);
      //      Console.ReadLine();
      //  }
        //Polymorphism method overloading
        public void Items(string Veg, string NonVeg)
        {
            Console.WriteLine("Items are: " + " " + Veg + " " + "and" + " " + NonVeg);

            Console.ReadLine();
        }

        public void Items(int Veg, int NonVeg)
        {
            Console.WriteLine("Total Items in Veg categories are:" + " " + Veg + " " + "and" + " " + "Total items in NonVeg categories are::" + " " +  NonVeg);

            Console.ReadLine();
        }

        // Polymorphism method overriding
        public virtual void ItemStoreRoom()  //Virtula 
        {
            Console.WriteLine("Veg items are avilable in the store room");

            Console.ReadLine();
        }
    }

     
  // Inheritance

    class CookingStaff : HotelItemDescription
    {
        public string CookName;
        public string Id;
        public string Age;
        public string details;

        public override void ItemStoreRoom() // Polymorphism overriding
        {
            Console.WriteLine("NonVeg items are avilable in the item storeroom");

            Console.ReadLine();
        }

        public void Details()
        {
            details = "Cook Name is ::" + " " + CookName + ", Id is " + " " + Id +
                       " " + ", Age is" + " " + Age + " " + " he has access in the ItemStoreRoom ";

            Console.WriteLine(details);

            Console.ReadLine();
        }

    }
}
    

