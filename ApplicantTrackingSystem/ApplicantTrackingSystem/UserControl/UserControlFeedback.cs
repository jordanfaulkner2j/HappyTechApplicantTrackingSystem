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
    public partial class UserControlFeedback : UserControl
    {
        public UserControlFeedback()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void Header_Text(object sender, EventArgs e)
        //{
        //    string Hdr =
        //        "Header: /n Dear [ApplicantName], /n My name is [EmployeeName] and I am contacting you regarding your application for [JobPostion] at our company HappyTech";
        //    MessageBox.Show(Hdr);
        //    Header.Text = Hdr;
        //}
    }
}
