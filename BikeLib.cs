using System;

namespace Lab__02ALib
{
    class Bike
    {
        public string Brand;
        public string Country;
        public string Region;
        public int Price;
        public double Weight;
        public double Lenghth;
        public bool HasHydraulicBrake;
        public bool HasHydraulicSeatPost;
        public double GetYearIncomePerInhabitant()
        {
            return Price / Weight;
        }

    }
}
