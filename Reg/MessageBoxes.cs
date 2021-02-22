using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg
{
    public partial class MessageBoxes : Form
    {
        public MessageBoxes()
        {
            InitializeComponent();
        }

        private void GradientButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shows an Simple MessageBox in code. This code can be Used ONLY IN C#!");
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sets the title of the MessageBox.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
