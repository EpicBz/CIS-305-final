using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form4 : Form
    {
        //allows for information to pass into the result view
        public static Form4 instances;
        public Label totalCost;
        public Label totalMoney;
        public Label remainingMoney;
        public Label expensiveItemName;
        public Label expensiveItemCost;

        public Form4()
        {
            InitializeComponent();
            // assigns this run through of the form to the correct labels and reassigns the new information
            instances = this;
            totalMoney = label5;
            totalCost = label6;
            remainingMoney = label7;
            expensiveItemCost = label9;
            expensiveItemName = label8;

        }

        //returns to home screen and closes the results
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
        
    }
}
