 
//Allows you to press keys, which in our case means it will raise 
//events to tell any other control/class that a key has been pressed.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keys
{
    public partial class Generickeys : UserControl
    {
        public Generickeys()
        {
            InitializeComponent();
        }

        //  Allows you to push button
        public event KeyPressEventHandler ButtonPressed;  

        //  Event when button is presseed 
        public void RaiseButtonPressed(char WhatToSend)
        {
            KeyPressEventHandler handler = ButtonPressed;
            if (handler != null)
            {
                handler(this, new KeyPressEventArgs(WhatToSend));
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void btnminus_Click(object sender, EventArgs e)
        {

        }

    }
}
