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

        string connectionString = "Server=localhost;Database=quotes;User Id=root;Password=thekingpin;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quotesDataSet2.quote' table. You can move, or remove it, as needed.
            //this.quoteTableAdapter1.Fill(this.quotesDataSet2.quote);
            // TODO: This line of code loads data into the 'customersDataSet.customers' table. You can move, or remove it, as needed.


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = true;
            //this.quoteTableAdapter1.Fill(this.quotesDataSet2.quote);
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

        private void refreshQuoteButton_Click(object sender, EventArgs e)
        {
            this.quoteTableAdapter1.Fill(this.quotesDataSet2.quote);
        }

        private void retrieveQuoteButton_Click(object sender, EventArgs e)
        {
            int quoteNumber;
            string queryString = "SELECT QuoteID, CustomerName, TotalPrice, Comment, QuoteStatus FROM quote WHERE QuoteID = @" + quoteIDtextbox.Text;

            if (quoteIDtextbox.Text != "")
            {
                try
                {
                    quoteNumber = Convert.ToInt32(quoteIDtextbox.Text);
                    quoteRetrievePanel.Visible = true;
                    quoteMainPanel.Visible = false;
                    QuoteIDDisplay.Text = quoteNumber.ToString();
                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //}
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
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
    }
}
