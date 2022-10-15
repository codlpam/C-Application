using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_App
{
    abstract class Livestock
    {
        public int ID;
        public double amtWater;
        public double dailyCost;
        public double Weight;
        public int Age;
        public string? Colour;
        public Livestock(int ID, double amtWater, double dailyCost, double Weight, int Age, string Colour) 
        { 
            this.ID = ID;
            this.amtWater = amtWater;
            this.dailyCost = dailyCost;
            this.Weight = Weight;
            this.Age = Age;
            this.Colour = Colour;
        }

        public abstract string DisplayInfo();

        public abstract double getProf();
        
    }
}
