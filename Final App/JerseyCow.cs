using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_App
{
    class JerseyCow : Cow
    {
        public JerseyCow(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour, double amtMilk)
            : base(ID, amtWater, dailyCost, Weight, Age, Colour, amtMilk) { }


        override public string DisplayInfo()
        {
            string info = $"Jersy Cow: {Environment.NewLine}" +
                $"ID: {ID} {Environment.NewLine}" +
                $"Amount of Water: {amtWater} {Environment.NewLine}" +
                $"Daily Cost: {dailyCost} {Environment.NewLine}" +
                $"Weight: {Weight} {Environment.NewLine}" +
                $"Age: {Age} {Environment.NewLine}" +
                $"Colour: {Colour} {Environment.NewLine}" +
                $"Amount of Milk: {amtMilk}";
            //MessageBox.Show(info, $"Jersey Cow: {ID}");
            return info;
        }
    }
}
