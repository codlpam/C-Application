using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_App
{
    class Dog : Livestock
    {

        public Dog(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour) : base(ID, amtWater, dailyCost, Weight, Age, Colour) { }
       

        override public string DisplayInfo()
        {
            string info = "";
            info = $"Dog: {Environment.NewLine}" +
                $"ID: {ID} {Environment.NewLine}" +
                $"Amount of Water: {amtWater} {Environment.NewLine}" +
                $"Daily Cost: {dailyCost} {Environment.NewLine}" +
                $"Weight: {Weight} {Environment.NewLine}" +
                $"Age: {Age} {Environment.NewLine}" +
                $"Colour: {Colour}";
            return info;
        }

        override public double getProf()
        {
            double prof = 0;
            prof += (Prices.waterPrice * amtWater) - dailyCost;
            return prof;
        }
    }
}
