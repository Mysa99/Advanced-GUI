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
    public partial class dashboaard : UserControl
    {
        public dashboaard()
        {
            InitializeComponent();
        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This is cooming out soon! You Can't enable that because its currently under work. Maybe you can look at the feature later!");
            MessageBox.Show("To Avoid any glitches with your Learning Experience, we will restart after you Click the 'OK' Button.");
            Application.Exit();
        }

        private void devmode_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This is cooming out soon! You Can't enable that because its currently under work. Maybe you can look at the feature later!");
            MessageBox.Show("To Avoid any glitches with your Learning Experience, we will restart after you Click the 'OK' Button.");
            Application.Exit();
        }

        private void beginmode_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hold Up! before you Report an Issue here, We know that there are to many Bugs with this feature! Its currently in Alpha, it means it is Completely new. Thank you for your use!", "Issued Feature 'Beginner Mode'");
        }
    }
}
