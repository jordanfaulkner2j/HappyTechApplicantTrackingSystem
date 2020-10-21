using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // missing login validation

            // hide current form
            this.Hide();

            // create main form and open it
            using (Main MainApplication = new Main())
                MainApplication.ShowDialog();

            // once main application closes, open login page again
            this.Show();
        }
    }
}
