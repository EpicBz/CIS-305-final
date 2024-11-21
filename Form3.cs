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
    // initnalized variables
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();
        double totalMoney = 0;
        double expensiveItemCost = 0;
        double expensivecost;
        double totalCost = 0;
        double itemCost = 0;
        double remainingMoney = 0;
        double hours = 0;
        double rate = 0;
        string expensiveItem = "";
        string expensiveName;
        public Form3()
        {
            InitializeComponent();
            HourlyRate.Hide();
            HRRate.Hide();
            HoursWorked.Hide();
            WorkedHours.Hide();
            SalaryYear.Hide();
            Salary.Hide();
        }

        //returns to home page and closes current page
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        //adds item to list
        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(CostItem.Text, out itemCost))
            {
                MessageBox.Show("Please enter a numeric value!");
                CostItem.Focus();
                return;
            }
            ListViewItem name = new ListViewItem(NameItem.Text);
            ListViewItem item = new ListViewItem(CostItem.Text);
            if (0 <= expensiveItemCost)
            {
                if (double.Parse(CostItem.Text) > expensiveItemCost)
                {
                    expensiveItemCost = double.Parse(CostItem.Text);
                    expensiveItem = NameItem.Text;
                    expensiveName = expensiveItem;
                    expensivecost = expensiveItemCost;

                }
            }
            totalCost = totalCost + double.Parse(CostItem.Text);

            ItemCostList.Items.Add(item);
            ItemNameList.Items.Add(name);

            NameItem.Clear();
            CostItem.Clear();

        }

        //calaculates 
        private void button2_Click(object sender, EventArgs e)
        {
            //calaculations for salary pay
            if (SalaryPay.Checked)
            {
                if (!double.TryParse(SalaryYear.Text, out totalMoney))
                {
                    MessageBox.Show("Please enter a number EX 1");
                    Salary.Focus();
                    return;
                }
                totalMoney = double.Parse(SalaryYear.Text);
                remainingMoney = totalMoney - totalCost;
                expensivecost = expensiveItemCost;
            }

            //calaculations for hourly pay
            if (HourlyPay.Checked)
            {
                if (!double.TryParse(HRRate.Text, out totalMoney))
                {
                    MessageBox.Show("Please enter a number EX 1");
                    HRRate.Focus();
                    return;
                }
                if (!double.TryParse(HoursWorked.Text, out totalMoney))
                {
                    MessageBox.Show("Please enter a number EX 1");
                    HoursWorked.Focus();
                    return;
                }
                hours = double.Parse(HoursWorked.Text);
                rate = double.Parse(HRRate.Text);
                if(hours > 40)
                {
                   totalMoney = ((rate * 40) + (rate * 1.5) * (hours - 40) * 4);
                }
                else
                {
                    totalMoney = (rate * hours) * 4;
                }
                remainingMoney = totalMoney - totalCost;
                expensivecost = expensiveItemCost;
            }


            // displays the results screen and pass through the data to the correct label
            form4.Show();
            Form4.instances.totalCost.Text = Convert.ToString(totalCost);
            Form4.instances.totalMoney.Text = Convert.ToString(totalMoney);
            Form4.instances.remainingMoney.Text = Convert.ToString(remainingMoney);
            Form4.instances.expensiveItemName.Text = expensiveName;
            Form4.instances.expensiveItemCost.Text = Convert.ToString(expensivecost);
            this.Close();
        }

        //hides hourly information and sets them to 0 and shows salary information
        private void SalaryPay_CheckedChanged(object sender, EventArgs e)
        {
            if (SalaryPay.Checked)
            {
                SalaryYear.Show();
                Salary.Show();
                HRRate.Hide();
                HourlyRate.Hide();
                HoursWorked.Hide();
                WorkedHours.Hide();
                hours = 0;
                rate = 0;
            }
        }

        //hides salary information and sets them to 0 and shows hourly information
        private void HourlyPay_CheckedChanged(object sender, EventArgs e)
        {
            if (HourlyPay.Checked)
            {
                HourlyRate.Show();
                HRRate.Show();
                HoursWorked.Show();
                WorkedHours.Show();
                SalaryYear.Hide();
                Salary.Hide();
            }
        }
    }
}
