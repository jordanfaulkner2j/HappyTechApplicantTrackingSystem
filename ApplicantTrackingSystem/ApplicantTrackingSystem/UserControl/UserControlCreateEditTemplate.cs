using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class UserControlCreateTemplate : UserControl
    {
        public UserControlCreateTemplate()
        {
            InitializeComponent();
        }
        public string defaultHeaderText = "Select some codes from the 'Header' section...";
        public string headerCode;

        private void cbxH01_CheckStateChanged(object sender, EventArgs e)
        {
            if (headerCode == "H01")
            {
                tbxHeader.Text = defaultHeaderText;
                headerCode = "";
            }
            else
            {
                tbxHeader.Text = "Code H01 has been selected.";
                headerCode = "H01";
            }
        }

        private void cbxH02_CheckStateChanged(object sender, EventArgs e)
        {
            if (headerCode == "H02")
            {
                tbxHeader.Text = defaultHeaderText;
                headerCode = "";
            }
            else
            {
                tbxHeader.Text = "Code H02 has been selected.";
                headerCode = "H02";
            }
        }
    }
}
