using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExceptionNegativePrice : Exception
    {
        double priceValue;

        public ExceptionNegativePrice(double price, string msg) : base(msg)
        {
            priceValue = price;
        }

    }
}
