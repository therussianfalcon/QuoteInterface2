using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Interface2 : Form
    {
        Form1 frm1;
        public Interface2(Form1 parent)
        {
            InitializeComponent();
            frm1 = parent;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            frm1.Close();
        }
    }
}
