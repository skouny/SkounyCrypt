using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkounyCrypt
{
    public partial class MyLicense : Form
    {
        public MyLicense()
        {
            InitializeComponent();
        }
        private void License_Load(object sender, EventArgs e)
        {
            textBoxLicense.Text = Properties.Resources.GPL_v3_0;
            textBoxLicense.DeselectAll();
        }
    }
}
