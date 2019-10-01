using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }

        public double total { get; private set; }


        public void AddItem(double itemPrice)
        {
            total += itemPrice;
            NumberOfItems++;
        }
    }
}
