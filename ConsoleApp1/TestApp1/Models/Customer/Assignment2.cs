using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models.Customer
{
    internal class Assignment2
    {
        private double costPrice;
        private double salesPrice;
        public double profit;
        public double loss;

        public Assignment2(double costPrice, double salesPrice)
        {
            this.costPrice = costPrice;
            this.salesPrice = salesPrice;
        }

        public void CalculateProfitORLoss()
        {
            if(this.costPrice > this.salesPrice)
                this.loss = this.costPrice - this.salesPrice;
            else
                this.profit = this.salesPrice - this.costPrice;
        }

        public void Display()
        {
            Console.WriteLine($"Cost Price : {this.costPrice}");
            Console.WriteLine($"Sales Price : {this.salesPrice}");
            Console.WriteLine($"Profit : {this.profit}");
            Console.WriteLine($"Loss : {this.loss}");
        }
    }
}
