namespace Project_10_2__Process_lunch_orders
{
    partial class Form1
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
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoBurger = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddOnBurger = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.grpAddOnPizza = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkBreadSticks = new System.Windows.Forms.CheckBox();
            this.chkBaconBits = new System.Windows.Forms.CheckBox();
            this.chkCroutons = new System.Windows.Forms.CheckBox();
            this.grpAddOnSalad = new System.Windows.Forms.GroupBox();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOnBurger.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.grpAddOnPizza.SuspendLayout();
            this.grpAddOnSalad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdoSalad);
            this.grpMainCourse.Controls.Add(this.rdoPizza);
            this.grpMainCourse.Controls.Add(this.rdoBurger);
            this.grpMainCourse.Location = new System.Drawing.Point(40, 59);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(309, 209);
            this.grpMainCourse.TabIndex = 1;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(20, 140);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(128, 24);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(20, 94);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(125, 24);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoBurger
            // 
            this.rdoBurger.AutoSize = true;
            this.rdoBurger.Location = new System.Drawing.Point(20, 47);
            this.rdoBurger.Name = "rdoBurger";
            this.rdoBurger.Size = new System.Drawing.Size(167, 24);
            this.rdoBurger.TabIndex = 0;
            this.rdoBurger.TabStop = true;
            this.rdoBurger.Text = "Hamburger - $6.95";
            this.rdoBurger.UseVisualStyleBackColor = true;
            this.rdoBurger.CheckedChanged += new System.EventHandler(this.rdoBurger_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project 10-2 Process lunch orders Jeremy Belisle";
            // 
            // grpAddOnBurger
            // 
            this.grpAddOnBurger.Controls.Add(this.chkFries);
            this.grpAddOnBurger.Controls.Add(this.chkKetchup);
            this.grpAddOnBurger.Controls.Add(this.chkLettuce);
            this.grpAddOnBurger.Location = new System.Drawing.Point(390, 59);
            this.grpAddOnBurger.Name = "grpAddOnBurger";
            this.grpAddOnBurger.Size = new System.Drawing.Size(462, 209);
            this.grpAddOnBurger.TabIndex = 1;
            this.grpAddOnBurger.TabStop = false;
            this.grpAddOnBurger.Text = "Add-on items ($.75/each)";
            this.grpAddOnBurger.Visible = false;
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Location = new System.Drawing.Point(28, 139);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(119, 24);
            this.chkFries.TabIndex = 2;
            this.chkFries.Text = "French fries";
            this.chkFries.UseVisualStyleBackColor = true;
            this.chkFries.Visible = false;
            this.chkFries.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(28, 93);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(237, 24);
            this.chkKetchup.TabIndex = 1;
            this.chkKetchup.Text = "Ketchup, mustard, and mayo";
            this.chkKetchup.UseVisualStyleBackColor = true;
            this.chkKetchup.Visible = false;
            this.chkKetchup.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Location = new System.Drawing.Point(28, 46);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(233, 24);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Text = "Lettuce, tomato, and onions";
            this.chkLettuce.UseVisualStyleBackColor = true;
            this.chkLettuce.Visible = false;
            this.chkLettuce.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.txtGrandTotal);
            this.grpOrderTotal.Controls.Add(this.label5);
            this.grpOrderTotal.Controls.Add(this.label4);
            this.grpOrderTotal.Controls.Add(this.label3);
            this.grpOrderTotal.Controls.Add(this.label2);
            this.grpOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpOrderTotal.Controls.Add(this.txtTax);
            this.grpOrderTotal.Controls.Add(this.txtSubtotal);
            this.grpOrderTotal.Location = new System.Drawing.Point(40, 321);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(403, 256);
            this.grpOrderTotal.TabIndex = 7;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(170, 193);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(153, 26);
            this.txtGrandTotal.TabIndex = 7;
            this.txtGrandTotal.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grand Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax (7.75%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(170, 141);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(153, 26);
            this.txtOrderTotal.TabIndex = 2;
            this.txtOrderTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(170, 95);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(153, 26);
            this.txtTax.TabIndex = 1;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(170, 52);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(153, 26);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TabStop = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(645, 305);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(185, 52);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(645, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(645, 400);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(185, 52);
            this.btnNewOrder.TabIndex = 4;
            this.btnNewOrder.Text = "New order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // grpAddOnPizza
            // 
            this.grpAddOnPizza.Controls.Add(this.chkOlives);
            this.grpAddOnPizza.Controls.Add(this.chkSausage);
            this.grpAddOnPizza.Controls.Add(this.chkPepperoni);
            this.grpAddOnPizza.Location = new System.Drawing.Point(390, 59);
            this.grpAddOnPizza.Name = "grpAddOnPizza";
            this.grpAddOnPizza.Size = new System.Drawing.Size(462, 209);
            this.grpAddOnPizza.TabIndex = 3;
            this.grpAddOnPizza.TabStop = false;
            this.grpAddOnPizza.Text = "Add-on items ($.50/each)";
            this.grpAddOnPizza.Visible = false;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(28, 139);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 24);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.Visible = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(28, 93);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(99, 24);
            this.chkSausage.TabIndex = 4;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.Visible = false;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(28, 46);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(107, 24);
            this.chkPepperoni.TabIndex = 3;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.Visible = false;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkBreadSticks
            // 
            this.chkBreadSticks.AutoSize = true;
            this.chkBreadSticks.Location = new System.Drawing.Point(28, 139);
            this.chkBreadSticks.Name = "chkBreadSticks";
            this.chkBreadSticks.Size = new System.Drawing.Size(122, 24);
            this.chkBreadSticks.TabIndex = 5;
            this.chkBreadSticks.Text = "Bread sticks";
            this.chkBreadSticks.UseVisualStyleBackColor = true;
            this.chkBreadSticks.Visible = false;
            this.chkBreadSticks.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkBaconBits
            // 
            this.chkBaconBits.AutoSize = true;
            this.chkBaconBits.Location = new System.Drawing.Point(28, 93);
            this.chkBaconBits.Name = "chkBaconBits";
            this.chkBaconBits.Size = new System.Drawing.Size(110, 24);
            this.chkBaconBits.TabIndex = 4;
            this.chkBaconBits.Text = "Bacon bits";
            this.chkBaconBits.UseVisualStyleBackColor = true;
            this.chkBaconBits.Visible = false;
            this.chkBaconBits.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // chkCroutons
            // 
            this.chkCroutons.AutoSize = true;
            this.chkCroutons.Location = new System.Drawing.Point(28, 46);
            this.chkCroutons.Name = "chkCroutons";
            this.chkCroutons.Size = new System.Drawing.Size(100, 24);
            this.chkCroutons.TabIndex = 3;
            this.chkCroutons.Text = "Croutons";
            this.chkCroutons.UseVisualStyleBackColor = true;
            this.chkCroutons.Visible = false;
            this.chkCroutons.CheckedChanged += new System.EventHandler(this.unChecked_CheckedChanged);
            // 
            // grpAddOnSalad
            // 
            this.grpAddOnSalad.Controls.Add(this.chkBreadSticks);
            this.grpAddOnSalad.Controls.Add(this.chkBaconBits);
            this.grpAddOnSalad.Controls.Add(this.chkCroutons);
            this.grpAddOnSalad.Location = new System.Drawing.Point(390, 59);
            this.grpAddOnSalad.Name = "grpAddOnSalad";
            this.grpAddOnSalad.Size = new System.Drawing.Size(462, 209);
            this.grpAddOnSalad.TabIndex = 2;
            this.grpAddOnSalad.TabStop = false;
            this.grpAddOnSalad.Text = "Add-on items ($.25/each)";
            this.grpAddOnSalad.Visible = false;
            // 
            // lstOrderList
            // 
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.ItemHeight = 20;
            this.lstOrderList.Location = new System.Drawing.Point(967, 59);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(284, 504);
            this.lstOrderList.TabIndex = 7;
            this.lstOrderList.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1261, 594);
            this.Controls.Add(this.lstOrderList);
            this.Controls.Add(this.grpAddOnSalad);
            this.Controls.Add(this.grpAddOnPizza);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddOnBurger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddOnBurger.ResumeLayout(false);
            this.grpAddOnBurger.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.grpAddOnPizza.ResumeLayout(false);
            this.grpAddOnPizza.PerformLayout();
            this.grpAddOnSalad.ResumeLayout(false);
            this.grpAddOnSalad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddOnBurger;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoBurger;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.GroupBox grpAddOnPizza;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkBreadSticks;
        private System.Windows.Forms.CheckBox chkBaconBits;
        private System.Windows.Forms.CheckBox chkCroutons;
        private System.Windows.Forms.GroupBox grpAddOnSalad;
        private System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label5;
    }
}

