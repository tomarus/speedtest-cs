using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SpeedTest
{
    public class NumbersOnlyTextBox : TextBox
    {
        public NumbersOnlyTextBox()
        {
            this.KeyPress += new KeyPressEventHandler(HandleKeyPress);
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    } 
}
