using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    internal class Invoice
    {
        private readonly int account; 
        private readonly string customer;
        private readonly string provider; 
        private string article = "01234"; 
        private int quantity = 1; 
        private double tax = 0.2;
        public Invoice (int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CalculatePaymentAmount()
        {
            double costWithoutTax = (account - account * tax) * quantity;
            double costWithTax = account * quantity;
            Console.WriteLine($"Payment amount with taxes = {costWithTax}");
            Console.WriteLine($"Payment amount without taxes = {costWithoutTax}");
        }
    }
}
