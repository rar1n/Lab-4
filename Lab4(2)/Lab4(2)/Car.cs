using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2_
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public double VEngine;
        public string TypeFuel;
        public int Probig;
        public double SerednyaVitrataFuel;
        public double Price;

        public double GetFuelPricePer100km(double fuelPrice)
        {
            return SerednyaVitrataFuel * fuelPrice;
        }

    }
}
