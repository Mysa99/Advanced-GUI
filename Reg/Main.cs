using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.gle/PqDDFpxP3BGUX11PA");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new MessageBoxes().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradientButton4_Click(object sender, EventArgs e)
        {
            new ShowDialogs().Show();
        }

        private void gradientButton5_Click(object sender, EventArgs e)
        {
            this.MessageBtn1.Show();
            this.MessageBtn2.Show();
            this.open_File_Dialogs11.Hide();
            this.dashboaard1.Hide();
            this.messageBoxes11.Show();
        }

        private void gradientButton6_Click(object sender, EventArgs e)
        {
            this.MessageBtn1.Hide();
            this.MessageBtn2.Hide();
            this.open_File_Dialogs11.Show();
            this.messageBoxes11.Hide();
            this.dashboaard1.Hide();
        }

        private void open_File_Dialogs11_Load(object sender, EventArgs e)
        {

        }

        private void gradientButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shows an Simple MessageBox in code. This code can be Used ONLY IN C#!");
        }

        private void GradientButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sets the title of the MessageBox.", "Title");
        }

        private void gradientButton1_Click_1(object sender, EventArgs e)
        {
            this.MessageBtn1.Hide();
            this.MessageBtn2.Hide();
            this.open_File_Dialogs11.Hide();
            this.dashboaard1.Show();
        }

        private void dashboaard1_Load(object sender, EventArgs e)
        {

        }
    }
}
