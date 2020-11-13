﻿using System;
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
    public partial class UserControlApplications : UserControl
    {
        public UserControlApplications()
        {
            InitializeComponent();
        }

        public void UpdateApplicationsTable()
        {
            // get dataset from database based on provided SQL query
            dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvApplications.DataSource;
            bs.Filter = string.Format("CONVERT(" + dgvApplications.Columns[1].DataPropertyName + ", System.String) like '%" + textBoxFirstName.Text.Replace("'", "''") + "%'");
            dgvApplications.DataSource = bs;
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            // if text box is set to default, clear its content
            if (textBoxFirstName.Text == "Search First Name")
            {
                textBoxFirstName.Clear();
            }
        }


        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvApplications.DataSource;
            bs.Filter = string.Format("CONVERT(" + dgvApplications.Columns[3].DataPropertyName + ", System.String) like '%" + textBoxLastName.Text.Replace("'", "''") + "%'");
            dgvApplications.DataSource = bs;
        }
        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            // if text box is set to default, clear its content
            if (textBoxLastName.Text == "Search Last Name")
            {
                textBoxLastName.Clear();
            }

        }
    }
}
