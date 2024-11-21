
namespace FinalProject
{
    partial class Form2
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.ItemListName = new System.Windows.Forms.ListView();
            this.ItemCost = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.ItemListCost = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddedFee = new System.Windows.Forms.TextBox();
            this.AdditionalFee = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.TextBox();
            this.NormalFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(274, 349);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(132, 349);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // ItemListName
            // 
            this.ItemListName.HideSelection = false;
            this.ItemListName.Location = new System.Drawing.Point(450, 124);
            this.ItemListName.Name = "ItemListName";
            this.ItemListName.Size = new System.Drawing.Size(64, 97);
            this.ItemListName.TabIndex = 23;
            this.ItemListName.UseCompatibleStateImageBehavior = false;
            // 
            // ItemCost
            // 
            this.ItemCost.Location = new System.Drawing.Point(164, 257);
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.Size = new System.Drawing.Size(100, 20);
            this.ItemCost.TabIndex = 22;
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(164, 218);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(100, 20);
            this.ItemName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Added Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Item Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Name";
            // 
            // TotalMoney
            // 
            this.TotalMoney.Location = new System.Drawing.Point(274, 71);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(100, 20);
            this.TotalMoney.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount of Money you want to spend";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(483, 349);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 23);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return Home";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ItemListCost
            // 
            this.ItemListCost.HideSelection = false;
            this.ItemListCost.Location = new System.Drawing.Point(548, 124);
            this.ItemListCost.Name = "ItemListCost";
            this.ItemListCost.Size = new System.Drawing.Size(69, 97);
            this.ItemListCost.TabIndex = 28;
            this.ItemListCost.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RV",
            "Crusie",
            "InState"});
            this.comboBox1.Location = new System.Drawing.Point(165, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddedFee
            // 
            this.AddedFee.Location = new System.Drawing.Point(164, 187);
            this.AddedFee.Name = "AddedFee";
            this.AddedFee.Size = new System.Drawing.Size(100, 20);
            this.AddedFee.TabIndex = 31;
            // 
            // AdditionalFee
            // 
            this.AdditionalFee.AutoSize = true;
            this.AdditionalFee.Location = new System.Drawing.Point(88, 190);
            this.AdditionalFee.Name = "AdditionalFee";
            this.AdditionalFee.Size = new System.Drawing.Size(33, 13);
            this.AdditionalFee.TabIndex = 30;
            this.AdditionalFee.Text = "Label";
            // 
            // Fee
            // 
            this.Fee.Location = new System.Drawing.Point(164, 161);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(100, 20);
            this.Fee.TabIndex = 33;
            // 
            // NormalFee
            // 
            this.NormalFee.AutoSize = true;
            this.NormalFee.Location = new System.Drawing.Point(88, 164);
            this.NormalFee.Name = "NormalFee";
            this.NormalFee.Size = new System.Drawing.Size(33, 13);
            this.NormalFee.TabIndex = 32;
            this.NormalFee.Text = "Label";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.NormalFee);
            this.Controls.Add(this.AddedFee);
            this.Controls.Add(this.AdditionalFee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ItemListCost);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.ItemListName);
            this.Controls.Add(this.ItemCost);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListView ItemListName;
        private System.Windows.Forms.TextBox ItemCost;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView ItemListCost;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox AddedFee;
        private System.Windows.Forms.Label AdditionalFee;
        private System.Windows.Forms.TextBox Fee;
        private System.Windows.Forms.Label NormalFee;
    }
}