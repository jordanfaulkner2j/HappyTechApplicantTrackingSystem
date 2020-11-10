using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ApplicantTrackingSystem
{
    public partial class UserControlCreateTemplate : UserControl
    {
        public UserControlCreateTemplate()
        {
            InitializeComponent();
        }
        public string defaultHeaderText = "Select some codes from the 'Header' section...";
        // select either enable or disable
        // click on save template button
        // ask user for name of template
        // insert the name of the template as title into the template data table
        // if section has enabled box ticked, set value of section to 1 and insert it into the template data table
        // if section has disabled box ticked, set value of section to 0 and insert it into the template data table
    }
}
