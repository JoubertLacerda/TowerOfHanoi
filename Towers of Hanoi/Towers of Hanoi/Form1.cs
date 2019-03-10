using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Hanoi(1, 2, 3, 3);
        }
        void Hanoi(int Tower1, int Tower2, int Tower3, int n)
        {
            if (n == 1)
                txtOutput.Text += "Move from " + Tower1 + " to " + Tower3 + "\r\n";
            if (n > 1)
            {
                Hanoi(Tower1, Tower3, Tower2, n - 1);
                Hanoi(Tower1, Tower2, Tower3, 1);
                Hanoi(Tower2, Tower1, Tower3, n - 1);
            }
        }
    }
}
