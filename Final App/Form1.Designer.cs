namespace Final_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AnimalID = new System.Windows.Forms.TextBox();
            this.bt_getAnimal = new System.Windows.Forms.Button();
            this.lb_totalProfit = new System.Windows.Forms.Label();
            this.lb_taxPaid = new System.Windows.Forms.Label();
            this.lb_GoatCowMilk = new System.Windows.Forms.Label();
            this.lb_avgAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_testing = new System.Windows.Forms.TextBox();
            this.bt_Reports = new System.Windows.Forms.Button();
            this.lb_JCowProfit = new System.Windows.Forms.Label();
            this.lb_redRatio = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lb_goatCowVsSheepProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm Profitability / Expenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Animal ID:";
            // 
            // tb_AnimalID
            // 
            this.tb_AnimalID.Location = new System.Drawing.Point(136, 93);
            this.tb_AnimalID.Name = "tb_AnimalID";
            this.tb_AnimalID.Size = new System.Drawing.Size(100, 23);
            this.tb_AnimalID.TabIndex = 2;
            // 
            // bt_getAnimal
            // 
            this.bt_getAnimal.Location = new System.Drawing.Point(259, 93);
            this.bt_getAnimal.Name = "bt_getAnimal";
            this.bt_getAnimal.Size = new System.Drawing.Size(94, 23);
            this.bt_getAnimal.TabIndex = 3;
            this.bt_getAnimal.Text = "Display Info";
            this.bt_getAnimal.UseVisualStyleBackColor = true;
            this.bt_getAnimal.Click += new System.EventHandler(this.bt_getAnimal_Click);
            // 
            // lb_totalProfit
            // 
            this.lb_totalProfit.AutoSize = true;
            this.lb_totalProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_totalProfit.Location = new System.Drawing.Point(38, 197);
            this.lb_totalProfit.Name = "lb_totalProfit";
            this.lb_totalProfit.Size = new System.Drawing.Size(190, 21);
            this.lb_totalProfit.TabIndex = 4;
            this.lb_totalProfit.Text = "Total Profitability Per Day: ";
            // 
            // lb_taxPaid
            // 
            this.lb_taxPaid.AutoSize = true;
            this.lb_taxPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_taxPaid.Location = new System.Drawing.Point(38, 230);
            this.lb_taxPaid.Name = "lb_taxPaid";
            this.lb_taxPaid.Size = new System.Drawing.Size(143, 21);
            this.lb_taxPaid.TabIndex = 5;
            this.lb_taxPaid.Text = "Tax Paid Per Month:";
            // 
            // lb_GoatCowMilk
            // 
            this.lb_GoatCowMilk.AutoSize = true;
            this.lb_GoatCowMilk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_GoatCowMilk.Location = new System.Drawing.Point(38, 262);
            this.lb_GoatCowMilk.Name = "lb_GoatCowMilk";
            this.lb_GoatCowMilk.Size = new System.Drawing.Size(226, 21);
            this.lb_GoatCowMilk.TabIndex = 6;
            this.lb_GoatCowMilk.Text = "Milk Per Day (Goats and Cows):";
            // 
            // lb_avgAge
            // 
            this.lb_avgAge.AutoSize = true;
            this.lb_avgAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_avgAge.Location = new System.Drawing.Point(38, 359);
            this.lb_avgAge.Name = "lb_avgAge";
            this.lb_avgAge.Size = new System.Drawing.Size(221, 21);
            this.lb_avgAge.TabIndex = 7;
            this.lb_avgAge.Text = "Average Age (Excluding Dogs):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reports ";
            // 
            // tb_testing
            // 
            this.tb_testing.Location = new System.Drawing.Point(353, 232);
            this.tb_testing.Multiline = true;
            this.tb_testing.Name = "tb_testing";
            this.tb_testing.Size = new System.Drawing.Size(223, 165);
            this.tb_testing.TabIndex = 9;
            // 
            // bt_Reports
            // 
            this.bt_Reports.Location = new System.Drawing.Point(38, 400);
            this.bt_Reports.Name = "bt_Reports";
            this.bt_Reports.Size = new System.Drawing.Size(92, 26);
            this.bt_Reports.TabIndex = 10;
            this.bt_Reports.Text = "Run Reports";
            this.bt_Reports.UseVisualStyleBackColor = true;
            this.bt_Reports.Click += new System.EventHandler(this.bt_Reports_Click);
            // 
            // lb_JCowProfit
            // 
            this.lb_JCowProfit.AutoSize = true;
            this.lb_JCowProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_JCowProfit.Location = new System.Drawing.Point(38, 329);
            this.lb_JCowProfit.Name = "lb_JCowProfit";
            this.lb_JCowProfit.Size = new System.Drawing.Size(182, 21);
            this.lb_JCowProfit.TabIndex = 11;
            this.lb_JCowProfit.Text = "Profit from Jersey Cows: ";
            // 
            // lb_redRatio
            // 
            this.lb_redRatio.AutoSize = true;
            this.lb_redRatio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_redRatio.Location = new System.Drawing.Point(38, 294);
            this.lb_redRatio.Name = "lb_redRatio";
            this.lb_redRatio.Size = new System.Drawing.Size(166, 21);
            this.lb_redRatio.TabIndex = 12;
            this.lb_redRatio.Text = "Ratio of Red Livestock:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(426, 129);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(163, 15);
            this.lb.TabIndex = 13;
            this.lb.Text = "Cow and Goat vs Sheep Profit";
            // 
            // lb_goatCowVsSheepProf
            // 
            this.lb_goatCowVsSheepProf.AutoSize = true;
            this.lb_goatCowVsSheepProf.Location = new System.Drawing.Point(426, 165);
            this.lb_goatCowVsSheepProf.Name = "lb_goatCowVsSheepProf";
            this.lb_goatCowVsSheepProf.Size = new System.Drawing.Size(10, 15);
            this.lb_goatCowVsSheepProf.TabIndex = 14;
            this.lb_goatCowVsSheepProf.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 467);
            this.Controls.Add(this.lb_goatCowVsSheepProf);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lb_redRatio);
            this.Controls.Add(this.lb_JCowProfit);
            this.Controls.Add(this.bt_Reports);
            this.Controls.Add(this.tb_testing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_avgAge);
            this.Controls.Add(this.lb_GoatCowMilk);
            this.Controls.Add(this.lb_taxPaid);
            this.Controls.Add(this.lb_totalProfit);
            this.Controls.Add(this.bt_getAnimal);
            this.Controls.Add(this.tb_AnimalID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_AnimalID;
        private Button bt_getAnimal;
        private Label lb_totalProfit;
        private Label lb_taxPaid;
        private Label lb_GoatCowMilk;
        private Label lb_avgAge;
        private Label label3;
        private TextBox tb_testing;
        private Button bt_Reports;
        private Label lb_JCowProfit;
        private Label lb_redRatio;
        private Label lb;
        private Label lb_goatCowVsSheepProf;
    }
}