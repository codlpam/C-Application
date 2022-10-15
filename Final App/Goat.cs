using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_App
{
    class Goat: Livestock
    { 
        public double amtMilk;
        
        public Goat(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour, double amtMilk) 
            : base(ID, amtWater, dailyCost, Weight, Age, Colour)
        {
            this.amtMilk = amtMilk;
        }
        
        override public string DisplayInfo()
        {
            string info = $"Goat: {Environment.NewLine}" +
                $"ID: {ID} {Environment.NewLine}" +
                $"Amount of Water: {amtWater} {Environment.NewLine}" +
                $"Daily Cost: {dailyCost} {Environment.NewLine}" +
                $"Weight: {Weight} {Environment.NewLine}" +
                $"Age: {Age} {Environment.NewLine}" +
                $"Colour: {Colour} {Environment.NewLine}" +
                $"Amount of Milk: {amtMilk}";

            return info;
        }

        override public double getProf()
        {
            double prof = 0;
            prof += (Prices.goatMilkPrice * amtMilk) - (Prices.waterPrice * amtWater) - dailyCost;
            return prof;
        }

    }
}
