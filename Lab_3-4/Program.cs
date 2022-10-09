using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(20000, "Mary", "Acer");
            invoice.CalculatePaymentAmount();
        }
    }
}
