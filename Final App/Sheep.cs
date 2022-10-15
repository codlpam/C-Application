using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_App
{
    class Sheep : Livestock 
    {
        public double amtWool;

        public Sheep(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour, double amtWool) 
            : base(ID, amtWater, dailyCost, Weight, Age, Colour)
        {
            this.amtWool = amtWool;
        }

        override public string DisplayInfo()
        {
            string info = "";
            info = $"Sheep: {Environment.NewLine}" +
                $"ID: {ID} {Environment.NewLine}" +
                $"Amount of Water: {amtWater} {Environment.NewLine}" +
                $"Daily Cost: {dailyCost} {Environment.NewLine}" +
                $"Weight: {Weight} {Environment.NewLine}Age: {Age} {Environment.NewLine}" +
                $"Colour: {Colour} {Environment.NewLine}" +
                $"Amount of Wool: {amtWool}";
            return info;
        }

        override public double getProf()
        {
            double prof = 0;
            prof += (Prices.sheepWoolPrice * amtWool) - (Prices.waterPrice * amtWater) - dailyCost;
            return prof;
        }
       
    }
}
