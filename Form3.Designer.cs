
namespace FinalProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalaryYear = new System.Windows.Forms.TextBox();
            this.HoursWorked = new System.Windows.Forms.TextBox();
            this.NameItem = new System.Windows.Forms.TextBox();
            this.CostItem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.HourlyPay = new System.Windows.Forms.RadioButton();
            this.SalaryPay = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemCostList = new System.Windows.Forms.ListView();
            this.ItemNameList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkedHours = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.HRRate = new System.Windows.Forms.TextBox();
            this.HourlyRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalaryYear
            // 
            this.SalaryYear.Location = new System.Drawing.Point(152, 119);
            this.SalaryYear.Name = "SalaryYear";
            this.SalaryYear.Size = new System.Drawing.Size(100, 20);
            this.SalaryYear.TabIndex = 47;
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(244, 182);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(100, 20);
            this.HoursWorked.TabIndex = 46;
            // 
            // NameItem
            // 
            this.NameItem.Location = new System.Drawing.Point(136, 219);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(100, 20);
            this.NameItem.TabIndex = 45;
            // 
            // CostItem
            // 
            this.CostItem.Location = new System.Drawing.Point(136, 247);
            this.CostItem.Name = "CostItem";
            this.CostItem.Size = new System.Drawing.Size(100, 20);
            this.CostItem.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Calaculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(84, 286);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 42;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Type of Employee";
            // 
            // HourlyPay
            // 
            this.HourlyPay.AutoSize = true;
            this.HourlyPay.Location = new System.Drawing.Point(270, 63);
            this.HourlyPay.Name = "HourlyPay";
            this.HourlyPay.Size = new System.Drawing.Size(55, 17);
            this.HourlyPay.TabIndex = 40;
            this.HourlyPay.TabStop = true;
            this.HourlyPay.Text = "Hourly";
            this.HourlyPay.UseVisualStyleBackColor = true;
            this.HourlyPay.CheckedChanged += new System.EventHandler(this.HourlyPay_CheckedChanged);
            // 
            // SalaryPay
            // 
            this.SalaryPay.AutoSize = true;
            this.SalaryPay.Location = new System.Drawing.Point(210, 63);
            this.SalaryPay.Name = "SalaryPay";
            this.SalaryPay.Size = new System.Drawing.Size(54, 17);
            this.SalaryPay.TabIndex = 39;
            this.SalaryPay.TabStop = true;
            this.SalaryPay.Text = "Salary";
            this.SalaryPay.UseVisualStyleBackColor = true;
            this.SalaryPay.CheckedChanged += new System.EventHandler(this.SalaryPay_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Items Added";
            // 
            // ItemCostList
            // 
            this.ItemCostList.HideSelection = false;
            this.ItemCostList.Location = new System.Drawing.Point(563, 163);
            this.ItemCostList.Name = "ItemCostList";
            this.ItemCostList.Size = new System.Drawing.Size(78, 97);
            this.ItemCostList.TabIndex = 37;
            this.ItemCostList.UseCompatibleStateImageBehavior = false;
            // 
            // ItemNameList
            // 
            this.ItemNameList.HideSelection = false;
            this.ItemNameList.Location = new System.Drawing.Point(456, 163);
            this.ItemNameList.Name = "ItemNameList";
            this.ItemNameList.Size = new System.Drawing.Size(78, 97);
            this.ItemNameList.TabIndex = 36;
            this.ItemNameList.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Items Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Items Name";
            // 
            // WorkedHours
            // 
            this.WorkedHours.AutoSize = true;
            this.WorkedHours.Location = new System.Drawing.Point(67, 186);
            this.WorkedHours.Name = "WorkedHours";
            this.WorkedHours.Size = new System.Drawing.Size(171, 13);
            this.WorkedHours.TabIndex = 33;
            this.WorkedHours.Text = "Average Hours Worked in a Week";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(68, 119);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(68, 13);
            this.Salary.TabIndex = 32;
            this.Salary.Text = "Yearly Salary";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(523, 353);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 23);
            this.btnReturn.TabIndex = 48;
            this.btnReturn.Text = "Return Home";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // HRRate
            // 
            this.HRRate.Location = new System.Drawing.Point(152, 153);
            this.HRRate.Name = "HRRate";
            this.HRRate.Size = new System.Drawing.Size(100, 20);
            this.HRRate.TabIndex = 50;
            // 
            // HourlyRate
            // 
            this.HourlyRate.AutoSize = true;
            this.HourlyRate.Location = new System.Drawing.Point(67, 156);
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.Size = new System.Drawing.Size(63, 13);
            this.HourlyRate.TabIndex = 49;
            this.HourlyRate.Text = "Hourly Rate";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HRRate);
            this.Controls.Add(this.HourlyRate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.SalaryYear);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.CostItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HourlyPay);
            this.Controls.Add(this.SalaryPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemCostList);
            this.Controls.Add(this.ItemNameList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorkedHours);
            this.Controls.Add(this.Salary);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalaryYear;
        private System.Windows.Forms.TextBox HoursWorked;
        private System.Windows.Forms.TextBox NameItem;
        private System.Windows.Forms.TextBox CostItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton HourlyPay;
        private System.Windows.Forms.RadioButton SalaryPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView ItemCostList;
        private System.Windows.Forms.ListView ItemNameList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WorkedHours;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox HRRate;
        private System.Windows.Forms.Label HourlyRate;
    }
}