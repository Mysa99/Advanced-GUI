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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ViReoL" && textBox2.Text == "6b95a6ae-4506-40cf-b4e2-c0d010f8e28d")
            {
                new Splash().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hmm, looks like you didn't do the Special Steps! Please click on Get Username and Get Password to get a Succfull Login.", "Incorrect Token Or Username");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Moon Learn! here you can Learn Coding in 10Minutes!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradientButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://up-to-down.net/181440/username");
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://up-to-down.net/181440/token");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Key was needed here, Because we want to make Some Money too. You Learn Programing the simplest stuff and Pro things Like we said, we DON'T Scamming you. We just don't have so much time, to Code everything in here this is the Reason why we needed a Key that is Protected with A Platform called 'Linkvertise' We can make Money out of it!", "Infomation");
        }

        private void gradientButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Moon Learn! here you will Learn, how to Code a simple to Pro C# Program! If you don't know how to Start for free, you should watch the Tutorial we already made for People who don't understand how to get the Token and Username. Make Sure to Follow The Steps *CORRECTLY* Or you sadly can't Login, anyways here you will Learn C#, Timers and How they work, MessageBoxes and More!", "Moon Learn - About");
        }
    }
}
