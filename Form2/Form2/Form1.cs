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

        string connectionString = "Server=localhost; Database=quotes; user id=root; Password=root;";
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
            // string queryString = "SELECT QuoteID, CustomerName, TotalPrice, Comment, QuoteStatus FROM quote WHERE QuoteID = '"+quoteIDtextbox.Text+"';";

            if (quoteIDtextbox.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        //get number from second panel
                        quoteNumber = Convert.ToInt32(quoteIDtextbox.Text);

                        string queryString = "SELECT QuoteID, CustomerName, TotalPrice, Comment, QuoteStatus FROM quote WHERE QuoteID = '" + quoteIDtextbox.Text + "';";

                        ////show new panel
                        //quoteRetrievePanel.Visible = true;
                        //quoteMainPanel.Visible = false;

                        //display quote id
                        QuoteIDDisplay.Text = quoteNumber.ToString();

                        //open MySQL connection
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryString, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            custNameDisplay.Text = reader.GetString(2);
                            priceDisplay.Text = reader.GetString(3);
                            commentDisplay.Text = reader.GetString(4);
                        }

                        else
                        {
                            MessageBox.Show("NO DATA");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //show new panel
                        quoteRetrievePanel.Visible = true;
                        quoteMainPanel.Visible = false;
                    }
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
