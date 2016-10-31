using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10_2__Process_lunch_orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creating the variables 
        double burger;
        double pizza;
        double salad;
        double grandTotal;
        //A method to clear the the extras when the menu item is selected. 
        //I got some ideas from https://social.msdn.microsoft.com/Forums/vstudio/en-US/61a33ecd-98f2-4ad7-8077-7e8aaeb0b0b3/uncheck-all-checkboxes?forum=csharpgeneral
        //for the clear all check boxes 
        private void clearAll(Control clear)
        {
            CheckBox chkBox = clear as CheckBox;
            if (chkBox == null)
            {
                foreach (Control c in clear.Controls) //foreach loop will clear any boxes that are checked
                {
                    clearAll(c);
                }
            }
            else
            {
                chkBox.Checked = false;
            }
            //setting all the extras to not be shown, and clearing the price boxes
            grpAddOnBurger.Visible = false;
            chkLettuce.Visible = false;
            chkKetchup.Visible = false;
            chkFries.Visible = false;
            grpAddOnPizza.Visible = false;
            chkOlives.Visible = false;
            chkPepperoni.Visible = false;
            chkSausage.Visible = false;
            grpAddOnSalad.Visible = false;
            chkBaconBits.Visible = false;
            chkBreadSticks.Visible = false;
            chkCroutons.Visible = false;
            txtSubtotal.Text = "";
            txtOrderTotal.Text = "";
            txtTax.Text = "";
        }
        // a return output method to display all the text box totals
        private void returnOutput(double foodItem)
        {
            double totalTax = foodItem * .0775;
            double orderTotal = totalTax + foodItem;
            grandTotal += orderTotal;
            txtSubtotal.Text = foodItem.ToString("c");
            txtTax.Text = totalTax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
            txtGrandTotal.Text = grandTotal.ToString("c");
        } 

        //a method for the burger option
        private void burgerTotal()
        {
            
            if(rdoBurger.Checked == true){
                burger = 6.95;
                lstOrderList.Items.Add(rdoBurger.Text); // adds burger to the listBox
                if (chkLettuce.Checked == true) //each if will check if the extra box is checked, and add it to the total and to the listBox
                {
                    burger += .75;
                    extrasPrint(chkLettuce.Text);
                }
                if(chkKetchup.Checked == true)
                {
                    burger += .75;
                    extrasPrint(chkKetchup.Text);
                }
                if(chkFries.Checked == true)
                {
                    burger += .75;
                    extrasPrint(chkFries.Text);
                }
                returnOutput(burger);
            }
            
        }
        //a method for the pizza option
        private void pizzaTotal()
        {
            if (rdoPizza.Checked == true) // checks if pizza is checked
            {
                pizza = 5.95;
                lstOrderList.Items.Add(rdoPizza.Text); // adds pizza to the listBox
                if (chkSausage.Checked == true) //each if will check if the extra box is checked, and add it to the total and to the listBox
                {
                    pizza += .5;
                    extrasPrint(chkSausage.Text);
                }
                if (chkPepperoni.Checked == true)
                {
                    pizza += .5;
                    extrasPrint(chkPepperoni.Text);
                }
                if (chkOlives.Checked == true)
                {
                    pizza += .5;
                    extrasPrint(chkOlives.Text);
                }
                returnOutput(pizza); //returns the output when the method is called
            }
        }

       
        //a method for the salad option
        private void saladtotal()
        {
            if (rdoSalad.Checked == true)
            {
                salad = 4.95;
                lstOrderList.Items.Add(rdoSalad.Text);
                if (chkBaconBits.Checked == true)//each if will check if the extra box is checked, and add it to the total and to the listBox
                {
                    salad += .25;
                    extrasPrint(chkBaconBits.Text);
                }
                if (chkBreadSticks.Checked == true)
                {
                    salad += .25;
                    extrasPrint(chkBreadSticks.Text);
                }
                if (chkCroutons.Checked == true)
                {
                    salad += .25;
                    extrasPrint(chkCroutons.Text);

                }
                returnOutput(salad);//returns the output when the method is called
            }
        }
        //a method to set the extra prices to be added to the listBox when it is called
        private ListBox extrasPrint(String item)
        {
            if (rdoBurger.Checked == true)
            {
                lstOrderList.Items.Add(item + " - $.75");
            }
            if (rdoPizza.Checked == true)
            {
                lstOrderList.Items.Add(item + " - $.50");
            }
            if (rdoSalad.Checked == true)
            {
                lstOrderList.Items.Add(item + " - $.25");
            }

            return lstOrderList;
        }

        //exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //place order button
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            burgerTotal();
            pizzaTotal();
            saladtotal();

        }
        //a method for when radio button burger is checked 
        private void rdoBurger_CheckedChanged(object sender, EventArgs e)
        {
            clearAll(this);
            grpAddOnBurger.Visible = true;
            chkLettuce.Visible = true;
            chkKetchup.Visible = true;
            chkFries.Visible = true;
        }
        //a method for when radio button pizza is checked 
        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            clearAll(this);
            grpAddOnPizza.Visible = true;
            chkOlives.Visible = true;
            chkPepperoni.Visible = true;
            chkSausage.Visible = true;
        }
        //a method for when radio button salad is checked 
        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            clearAll(this);
            grpAddOnSalad.Visible = true;
            chkBaconBits.Visible = true;
            chkBreadSticks.Visible = true;
            chkCroutons.Visible = true;
        }
        // an event for everytime an extra checkbox is checked or unchecked it will clear the totals except the grand total and listbox
        private void unChecked_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtOrderTotal.Text = "";
            txtTax.Text = "";
        }
        //a new order button to clear everyhting for a new order
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            clearAll(this);
            grandTotal = 0;
            txtGrandTotal.Text = "";
            lstOrderList.Items.Clear();
        }
    }
}

