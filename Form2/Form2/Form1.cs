using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // TODO: This line of code loads data into the 'sql5125420DataSet1.quotes' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'sql5125420DataSet.quotes' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quotesDataSet.quote' table. You can move, or remove it, as needed.       
            // TODO: This line of code loads data into the 'quotesDataSet2.quote' table. You can move, or remove it, as needed.
            //this.quoteTableAdapter.Fill(this.quotesDataSet2.quote);
            // TODO: This line of code loads data into the 'customersDataSet.customers' table. You can move, or remove it, as needed.
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = true;
            try
            {
                this.quotesTableAdapter.Fill(this.sql5125420DataSet1.quotes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void quoteMainReturnButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = false;
        }


        private void refreshQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.quotesTableAdapter.Fill(this.sql5125420DataSet1.quotes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void retrieveQuoteButton_Click(object sender, EventArgs e)
        {
            //int quoteNumber;
            // string queryString = "SELECT QuoteID, CustomerName, TotalPrice, Comment, QuoteStatus FROM quote WHERE QuoteID = '"+quoteIDtextbox.Text+"';";

            if (quoteIDtextbox.Text != "")
            {
                retrieveDataFill();
            }
            else
            {

            }

        }

        private void quoteRetrievalReturnButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = true;
            quoteRetrievePanel.Visible = false;
        }

        private void custNameDisplay_TextChanged(object sender, EventArgs e)
        {
            textChangeEvent(modifyQuoteButton, custNameDisplay);
        }

        private void quoteIDtextbox_TextChanged(object sender, EventArgs e)
        {
            textChangeEvent(retrieveQuoteButton, quoteIDtextbox);
            textChangeEvent(deleteQuoteButton, quoteIDtextbox);
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.quotesTableAdapter.Search(this.sql5125420DataSet1.quotes, ((int)(System.Convert.ChangeType(quoteIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
