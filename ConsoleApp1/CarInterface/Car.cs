using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterface
{
    internal class Car : IVehicle
    {
        public int startingGasolineAmount;

        public Car(int startingGasolineAmount)
        {
            this.startingGasolineAmount = startingGasolineAmount;
            this.Drive();
        }

        public void Drive()
        {
            if (this.startingGasolineAmount > 0)
                Console.WriteLine("Car is Driving");
            else
            {
                Console.Write("Fuel tank empty : Please enter the gasoline Amount to refule the car : ");
                int gas = int.Parse(Console.ReadLine());
                if(this.Refuel(gas))
                    this.Drive();
            }
        }

        public bool Refuel(int gasolineAmount)
        {
            if(gasolineAmount > 0)
                this.startingGasolineAmount += gasolineAmount;
            return true;
        }
    }
}
