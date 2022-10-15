using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_App
{
    class Cow : Livestock
    {
        public double amtMilk;

        public Cow(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour, double amtMilk)
            : base(ID, amtWater, dailyCost, Weight, Age, Colour)
        {
            this.amtMilk = amtMilk;
        }

        override public string DisplayInfo()
        {
            string info = $"Cow: {Environment.NewLine}" +
                $"ID: {ID} {Environment.NewLine}" +
                $"Amount of Water: {amtWater} {Environment.NewLine}" +
                $"Daily Cost: {dailyCost} {Environment.NewLine}" +
                $"Weight: {Weight} {Environment.NewLine}" +
                $"Age: {Age} {Environment.NewLine}" +
                $"Colour: {Colour} {Environment.NewLine}" +
                $"Amount of Milk: {amtMilk}";
           // MessageBox.Show(info, $"Cow: {ID}");
            return info;
        }

        override public double getProf()
        {
            double prof = 0;
            prof += (Prices.cowMilkPrice * amtMilk) - (Prices.waterPrice * amtWater) - dailyCost;
            return prof;
        }  

    }
}
