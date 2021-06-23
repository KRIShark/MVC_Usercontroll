using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Vorher
{
    public partial class UserControl1 : UserControl
    {
        private string name = "Müller";

        public UserControl1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            textBoxName.Text = this.name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.name = textBoxName.Text;
        }
    }
}
