using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        int ID;
        double amtWater; // per day
        double dailyCost;
        double Weight; // in Kg
        int Age; // in Years
        string? Colour;
        double amtMilk; // Per day
        bool isJersey;
        double amtWool; // per year not per day

        Dictionary<int, Livestock> Animals = new Dictionary<int, Livestock>();
        string[] tables = { "Cows", "Goats", "Sheep", "Dogs", "Rates and Prices" };
        string table;
        private void ReadData()
        {
            string ConnStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Cody\Desktop\Final App.accdb";
            using (OleDbConnection connection = new OleDbConnection(ConnStr))
            {
                try
                {
                    connection.Open();
                    for (int i = 0; i < tables.Length; i++)
                    {
                        table = tables[i];
                        string q = $"select * from [{table}]";
                        OleDbCommand command = new OleDbCommand(q, connection);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (table == "Cows")
                                {
                                    ProcessAnimal(reader);
                                    amtMilk = (double)reader["amount of milk"];
                                    isJersey = (bool)reader["Is jersey"];
                                    if (isJersey == true)
                                    {
                                        Livestock p = new JerseyCow(ID, amtWater, dailyCost, Weight, Age, Colour!, amtMilk);
                                        Animals.Add(ID, p);
                                    }
                                    else
                                    {
                                        Livestock p = new Cow(ID, amtWater, dailyCost, Weight, Age, Colour!, amtMilk);
                                        Animals.Add(ID, p);
                                    }
                                }
                                else if (table == "Goats")
                                {
                                    ProcessAnimal(reader);
                                    amtMilk = (double)reader["amount of milk"];
                                    Livestock p = new Goat(ID, amtWater, dailyCost, Weight, Age, Colour!, amtMilk);
                                    Animals.Add(ID, p);
                                }
                                else if (table == "Sheep")
                                {
                                    ProcessAnimal(reader);
                                    amtWool = (double)reader["amount of wool"];
                                    Livestock p = new Sheep(ID, amtWater, dailyCost, Weight, Age, Colour!, amtWool);
                                    Animals.Add(ID, p);
                                }
                                else if (table == "Dogs")
                                {
                                    ProcessAnimal(reader);
                                    Livestock p = new Dog(ID, amtWater, dailyCost, Weight, Age, Colour!);
                                    Animals.Add(ID, p);
                                }
                                else
                                {
                                    /* TEMPORARY MANUALLY SET VARIBLES SO I CAN COMPLETE REPORTS */
                                    

                                    /*
                                    //tb_testing.Text += tables[i];
                                    //tb_testing.Text += reader["Rate"];
                                    //tb_testing.Text += "text:" + reader["Goat milk price"];
                                    if (reader["Rate"].ToString() == "Goat milk price") Prices.goatMilkPrice = (double)reader["Amount"];

                                    tb_testing.Text += Prices.goatMilkPrice;
                                    tb_testing.Text += Environment.NewLine;
                                    tb_testing.Text += Prices.cowMilkPrice;
                                    Prices.cowMilkPrice = (double)reader["Cow milk price"];
                                    Prices.sheepWoolPrice = (double)reader["Sheep wool price"];
                                    Prices.waterPrice = (double)reader["Water price"];
                                    Prices.Tax = (double)reader["Tax"];
                                    Prices.jerseyCowTax = (double)reader["Jersey cow tax"];
                                    
                                    //MessageBox.Show(Prices.goatMilkPrice.ToString());
                                    //tb_testing.Text += (double)reader["Goat milk price"];
                                    */
                                }
                            }
                        }
                        
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ProcessAnimal(OleDbDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"]);
            amtWater = (double)reader["Amount of water"];
            dailyCost = (double)reader["daily cost"];
            Weight = (double)reader["Weight"];
            Age = Convert.ToInt32(reader["Age"]);
            Colour = reader["Color"].ToString();
        }
      
        private void SearchID()
        {
            try
            {
                int searchID = Convert.ToInt32(tb_AnimalID.Text);
                MessageBox.Show(Animals[searchID].DisplayInfo(), "Animal: "+ Animals[searchID].ID.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("ID Not Found");
            }
        }

        private double TotalProfit(Dictionary<int, Livestock> Animals)
        {
            double total = 0;
            foreach(KeyValuePair<int, Livestock> entry in Animals)
            {
                total = total + Animals[entry.Key].getProf();
            }
            total = Math.Round(total, 2);
            return total;
        }

        private double avgAge()
        {
            double totalAge = 0;
            int count = 0;
            foreach (KeyValuePair<int, Livestock> entry in Animals)
            {
                if (Animals[entry.Key] is Dog) break;
                else
                {
                    totalAge = totalAge + Animals[entry.Key].Age;
                    count++;
                }
            }
            double avgAge = totalAge / count;
            avgAge = Math.Round(avgAge, 1);
            return avgAge;
        }

        
        private double isRed()
        {
            int totalRed = 0;
            foreach (KeyValuePair<int, Livestock> entry in Animals)
            {
                if(Animals[entry.Key].Colour == "Red")
                {
                    totalRed++;
                }
            }
           return totalRed;
        }

        //private double TotalMilk()
        //{
        //    double totalMilk = 0;
        //    foreach (KeyValuePair<int, Livestock> entry in Animals)
        //    {
        //        if (Animals[entry.Key] is Cow)
        //        {
        //            totalMilk += Animals[entry.Key].Milk(); // GOTTA FIX
        //        }
        //    }
        //    return totalMilk;
        //}

        private double JerseyCowProfit()
        {
            double JCowProfit = 0;
            foreach (KeyValuePair<int, Livestock> entry in Animals)
            {
                if (Animals[entry.Key] is JerseyCow)
                {
                    JCowProfit += Animals[entry.Key].getProf();
                }
            }
            JCowProfit = Math.Round(JCowProfit, 2);
            return JCowProfit;

        }

        private double [] goatCowProfvsSheep()
        {
            double goatCowProf = 0;
            double sheepProf = 0;
            var Profits = new HashSet<double>();
            foreach (KeyValuePair<int, Livestock> entry in Animals)
            {

                if (Animals[entry.Key] is Sheep)
                {
                    sheepProf += Animals[entry.Key].getProf();
                }
                else if (Animals[entry.Key] is JerseyCow) continue; // skips over Jersey Cows otherwise they get counted as well
                else if (Animals[entry.Key] is Cow or Goat)
                {
                    goatCowProf += Animals[entry.Key].getProf();
                }
            }
            sheepProf = Math.Round(sheepProf, 2);
            goatCowProf = Math.Round(goatCowProf, 2);
            Profits.Add(goatCowProf);
            Profits.Add(sheepProf);
            return Profits.ToArray();
        }

        private void bt_getAnimal_Click(object sender, EventArgs e)
        {     
            SearchID();
        }

        private void bt_Reports_Click(object sender, EventArgs e)
        {
            lb_totalProfit.Text = "Total Profitability Per Day: $" + TotalProfit(Animals);
            lb_avgAge.Text = "Average Age (Excluding Dogs): " + avgAge();
            lb_redRatio.Text = "Ratio of Red Livestock: " + Animals.Count + " : " + isRed();
            lb_JCowProfit.Text = "Profit from Jersey Cows: $" + JerseyCowProfit();
            double[] Profits = goatCowProfvsSheep();
            lb_goatCowVsSheepProf.Text = "Goat and Cow: $" + Profits[0] + Environment.NewLine + "Sheep: $" + Profits[1];
        }
    }
}