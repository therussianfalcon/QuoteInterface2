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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quotesDataSet2.quote' table. You can move, or remove it, as needed.
            this.quoteTableAdapter1.Fill(this.quotesDataSet2.quote);
            // TODO: This line of code loads data into the 'customersDataSet.customers' table. You can move, or remove it, as needed.


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = true;
        }

        private void quoteMainReturnButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = false;
        }



        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.quoteTableAdapter1.Search(this.quotesDataSet2.quote, ((int)(System.Convert.ChangeType(quoteIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
