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
    public partial class Form2 : Form
    {
        Form4 form4 = new Form4();
        double totalMoney = 0;
        double expensiveItemCost = 0;
        double expensivecost;
        double totalCost = 0;
        double tripCost = 0;
        double tripAdditonal = 0;
        double itemCost = 0;
        double remainingMoney = 0;
        string expensiveItem = "";
        string expensiveName;



        public Form2()
        {
            InitializeComponent();
        }




        // adds items into a two arrays being the cost and the other being name and adds up total expenses
        public void btnAddItem_Click(object sender, EventArgs e)
        {            
            //data validation
            if (!double.TryParse(ItemCost.Text, out itemCost))
            {
                MessageBox.Show("Please enter a numeric value!");
                ItemCost.Focus();
                return;
            }
            //instatntiates the list view to be able to  add values
            ListViewItem name = new ListViewItem(ItemName.Text);
            ListViewItem item = new ListViewItem(ItemCost.Text);
            //stores the largest number and item name to determine the biggest purchase
            //try looking again to see if there is a way to access this with a loop.
            if (0 <= expensiveItemCost)
            {
                if(double.Parse(ItemCost.Text) > expensiveItemCost)
                {
                    expensiveItemCost = double.Parse(ItemCost.Text);
                    expensiveItem = ItemName.Text;
                    expensiveName = expensiveItem;
                    expensivecost = expensiveItemCost;
                    
                }
            }
            //adds up total cost
            totalCost = totalCost + double.Parse(ItemCost.Text);
            
            //adds items to both list views and clears the text box to be able to add the next item
            ItemListCost.Items.Add(item);
            ItemListName.Items.Add(name);

            ItemName.Clear();
            ItemCost.Clear();



        }

        //calculates results
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //data validation to confirm there is a spending limit
            if (!double.TryParse(TotalMoney.Text, out totalMoney))
            {
                MessageBox.Show("Please enter a number EX 1");
                TotalMoney.Focus();
                return;
            }
            totalMoney = double.Parse(TotalMoney.Text);
            totalCost = totalCost + tripAdditonal + tripCost;
            remainingMoney = totalMoney - totalCost;
            expensivecost = expensiveItemCost;

            // displays the results screen and pass through the data to the correct label
            form4.Show();
            Form4.instances.totalCost.Text = Convert.ToString(totalCost);
            Form4.instances.totalMoney.Text = Convert.ToString(totalMoney);
            Form4.instances.remainingMoney.Text = Convert.ToString(remainingMoney);
            Form4.instances.expensiveItemName.Text = expensiveName;
            Form4.instances.expensiveItemCost.Text = Convert.ToString(expensivecost);
            this.Close();


        }

        // Return to home page
        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        //select what kind of vacation it is an ask for addtional information
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NormalFee.Text = "RV cost";
                    AdditionalFee.Text = "Cost to fill RV";
                    tripCost = double.Parse(Fee.Text);
                    tripAdditonal = double.Parse(AddedFee.Text);
                    break;
                case 1:
                    NormalFee.Text = "Cost of ticket";
                    AdditionalFee.Hide();
                    AddedFee.Hide();
                    tripCost = double.Parse(Fee.Text);
                    tripAdditonal = 0;
                    break;
                case 2:
                    NormalFee.Text = "Hotel Cost";
                    AdditionalFee.Text = "Cost of Gas";
                    tripCost = double.Parse(Fee.Text);
                    tripAdditonal = double.Parse(Fee.Text);
                    break;
                default:
                    MessageBox.Show("Please selecte a type of vacation");
                    break;

            }
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
