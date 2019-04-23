using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Devgis.Naming
{
    public partial class Words : Form
    {
        public String KeyWords="";
        public Words()
        {
            InitializeComponent();

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            KeyWords = tbWords.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
