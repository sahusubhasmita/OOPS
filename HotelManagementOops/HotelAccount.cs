using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementOops
{

    //Encapsulation Method - its a binding of method and property , and when we declare a private class then by using
    // getter and setter method we can access this private value accountBalance .
    class HotelAccount
    {
        private  int accountBalace = 100000;

        public int balance // balance is property
        {
            set // setter method
            {
                if (value < 100)
                {
                    Console.WriteLine("You can not pass the value which is less than 100");
                }
                else
                {
                    accountBalace = value;
                }
            }
            get // getter method
            {
                return accountBalace;
            }
        }
    }
}
