/*
 * Created by: Lana ZE
 * Created on: 20-09-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the height of a rock since it was dropped at x time (usrer inputs time)
 * from the initial height of 100m and there are two choices of gravity; earth and moon.
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

namespace FallingObjectsLanaZE
{
    public partial class frmFallingObjectsLanaZE : Form
    {
        public frmFallingObjectsLanaZE()
        {
            InitializeComponent();
        }

        //declare the variables 
        double height = 100;
        double initialHeight = 100;
        double gravity = 9.807;

        
        private void FrmFallingObjectsLanaZE_Load(object sender, EventArgs e)
        {

        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }

        //This is to make sure that if the user tries to type anything else but letters
        //inside the text box it won't show up.
        private void TxtTime_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare whatever is written in the text box
            double UserTime = double.Parse(txtTime.Text);

            //this is the equation used to find the heigt using the time given
            height = initialHeight - (0.5 * gravity * Math.Pow(UserTime, 2));

            if (height <= 0)
            {
                lblAnswer.Text = "The rock has already hit the ground!";
            }

            //This displays an answer that informs the user that the object haven't been dropped yet
            else if (height == 0)
            {
                lblAnswer.Text = "The rock has not been dropped yet!";
            }

            //This just writes the message for the calculation
            else if (true)
            { // math.round rounds to the nearst two decimals.
                lblAnswer.Text = "The rock is currently at  " + Convert.ToString(Math.Round(height , 2)) + "  meters above the ground.";
            }
        }

        private void MoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravity = 1.62;
        }

        private void EarthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravity = 9.807;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
