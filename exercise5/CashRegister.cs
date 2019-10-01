using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class CashRegister
    {

        public static double totalMoneyAllCRs { get; set; }

        public static int totalItemsAllCRs { get; set; }

        public int NumberOfItems { get; private set; }

        public double total { get; private set; }


        public void AddItem(double itemPrice)
        {
            total += itemPrice;
            NumberOfItems++;

            totalItemsAllCRs++;
            totalMoneyAllCRs += itemPrice;
        }
    }
}
