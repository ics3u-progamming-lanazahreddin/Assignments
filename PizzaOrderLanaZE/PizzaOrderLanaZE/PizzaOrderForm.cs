/*
 * Created by: Lana ZE
 * Created on: 14-10-2019
 * Created for: ICS3U Programming
 * Major Assignment – Day #7 - Pizza Order
 * This program calculates the subtotal and the total of your pizza depending on what pizza size you
 * want, how many toppings, any side fries, tax of your province and if you want it delivered to you house.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderLanaZE
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();

            // auto-check those buttons 
            radMedium.Checked = true;
            radOntario.Checked = true;
            radYes.Checked = false;

            //hide the final order text and the calculate button
            this.txtFinalOrder.Hide();
            this.btnCalculate.Hide();
            lblToppingsPrice.Hide();
            lblFriesCost.Hide();
        }

        // variables
        double SIZE_COST = 0;
        const double MEDIUM_S = 7.99;
        const double LARGE_S = 9.99;
        const double EXTRA_LARGE = 12.99;

        double TOPPINGS_COST = 0;
        const double TOPPING_0 = 0;
        const double TOPPING_1 = 0.75;
        const double TOPPING_2 = 1.35;
        const double TOPPING_3 = 2.15;
        const double TOPPING_4 = 2.75;

        double FRIES_COST = 0;
        const double FRIES_0 = 0;
        const double FRIES_1 = 1.99;
        const double FRIES_2 = 2.30;
        const double FRIES_3 = 2.60;

        double DELIVERY_FEE = 0;
        const double DELIVERY_FEE_YES = 6.99;
        const double DELIVERY_FEE_NO = 0;

        double TAX = 0 ;
        string province;
        string taxRate;

        double subtotal = 0;
        double total = 0;


        //PIZZA SIZE COST 
        private void RadMedium_CheckedChanged(object sender, EventArgs e)
        {
            SIZE_COST = MEDIUM_S;
            lblPizzaSizeCost.Text = "The cost of your medium pizza is " + string.Format("{0:$0.00}", SIZE_COST);
        }
        private void RadLarge_CheckedChanged(object sender, EventArgs e)
        {
            SIZE_COST = LARGE_S;
            lblPizzaSizeCost.Text = "The cost of your large pizza is " + string.Format("{0:$0.00}", SIZE_COST);
        }
        private void RadXLarge_CheckedChanged(object sender, EventArgs e)
        {
            SIZE_COST = EXTRA_LARGE;
            lblPizzaSizeCost.Text = "The cost of your extra large pizza is " + string.Format("{0:$0.00}", SIZE_COST);
        }

        //TOPPINGS COST
        private void NudToppings_ValueChanged(object sender, EventArgs e)
        {
            if (nudToppings.Value == 0)
            {
               TOPPINGS_COST = 0;
            }
            else if (nudToppings.Value == 1)
            {
                TOPPINGS_COST = TOPPING_1;
            }

            else if (nudToppings.Value == 2)
            {
                TOPPINGS_COST = TOPPING_2;
            }

            else if (nudToppings.Value == 3)
            {
                TOPPINGS_COST = TOPPING_3;
            }

            else if (nudToppings.Value == 4)
            {
                TOPPINGS_COST= TOPPING_4;
            }
            lblToppingsPrice.Show();
            lblToppingsPrice.Text = "The cost of your pizza toppings is" + string.Format("{0:$0.00}", TOPPINGS_COST);
        }

        // FRIES COST
        private void NudFries_ValueChanged(object sender, EventArgs e)
        {
            if (nudFries.Value == 0)
            {
                FRIES_COST = FRIES_0;
            }

            else if (nudFries.Value == 1)
            {
                FRIES_COST = FRIES_1;
            }

            else if (nudFries.Value == 2)
            {
                FRIES_COST = FRIES_2;
            }

            else if (nudFries.Value == 3)
            {
                FRIES_COST = FRIES_3;
            }
            lblFriesCost.Show();
            lblFriesCost.Text = "The cost of your fries is " + string.Format("{0:$0.00}", FRIES_COST);
        }


        //TAX RATE IN 2 PROVINCES
        private void RadOntario_CheckedChanged(object sender, EventArgs e)
        {
            TAX = 1.13;
            province = "Onatrio";
            taxRate = "13%";
            lblProvince.Text = "The tax rate in your province is " + taxRate;

        }

        private void RadAlberta_CheckedChanged(object sender, EventArgs e)
        {
            TAX = 1.05;
            province = "Alberta";
            taxRate = "5%";
            lblProvince.Text = "The tax rate in your province is " + taxRate;
        }

        //DELIVERY FEE
        private void RadYes_CheckedChanged(object sender, EventArgs e)
        {
            DELIVERY_FEE = DELIVERY_FEE_YES;
            lblDelivery.Text = " Your delivery fee is" + string.Format("{0:$0.00}", DELIVERY_FEE);
            btnCalculate.Show();
        }

        private void RadNo_CheckedChanged(object sender, EventArgs e)
        {
            DELIVERY_FEE = DELIVERY_FEE_NO ;
            lblDelivery.Text = " You don't have any delivery fee!";
            btnCalculate.Show();
        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //calculat the subtotal
            subtotal = SIZE_COST + TOPPINGS_COST + FRIES_COST + DELIVERY_FEE;

            //calculate the total
            total = subtotal * TAX;

           // display the final oder
            txtFinalOrder.Show();
            txtFinalOrder.Text = "As you live in" + province + "you will be charged" + taxRate + "tax for you order";
            txtFinalOrder.Text = "You are charged $" + SIZE_COST + "for your pizza, $" + TOPPINGS_COST + "for your toppings, $" +
                FRIES_COST + "for your fries and $" + DELIVERY_FEE + "as your delivery fee. Thankyou for ordering from our store," +
                "your subtotal is: $" + Convert.ToString(Math.Round(subtotal, 2)) + "and your total comes to$" +
                Convert.ToString(Math.Round(total, 2)) + ".";

        }

        private void FrmPizzaOrder_Load(object sender, EventArgs e)
        {

        }
    }

}
