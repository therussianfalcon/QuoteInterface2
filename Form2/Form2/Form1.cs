using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
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
            //MySqlConnection connection = new MySqlConnection("server=sql5.freemysqlhosting.net;database=sql5125420;uid=sql5125420;pwd=CuPC68fUR7;");
            //try
            //{
            //    connection.Open();
            //    MessageBox.Show("success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection!");
            //}
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
                retrieveDataFill(quoteIDtextbox);
            }
            else
            {

            }

        }

        private void quoteRetrievalReturnButton_Click(object sender, EventArgs e)
        {
            quoteMainPanel.Visible = true;
            quoteRetrievePanel.Visible = false;
            custNameDisplay.Text = "";
            priceDisplay.Text = "";
            commentDisplay.Text = "";
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

        private void unresolvedCheckbox_Click(object sender, EventArgs e)
        {
            unresolvedCheckbox.Checked = true;
            sanctionedCheckbox.Checked = false;
        }

        private void sanctionedCheckbox_Click(object sender, EventArgs e)
        {
            unresolvedCheckbox.Checked = false;
            sanctionedCheckbox.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                double discountPercent = Convert.ToDouble(comboBox1.Text);
                double basePrice = Convert.ToDouble(priceDisplay.Text);
                discountPercent = 1 - (discountPercent / 100);
                actualPrice = basePrice * discountPercent;
                priceDisplay2.Text = actualPrice.ToString();

                confirmDiscountButton.Enabled = true;
            }

        }

        double actualPrice;
        private void confirmDiscountButton_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            confirmDiscountButton.Enabled = false;
            discountApply(actualPrice, QuoteIDDisplay);
            retrieveDataFill(QuoteIDDisplay);
        }

        private void quoteDisplayRefresh_Click(object sender, EventArgs e)
        {
            retrieveDataFill(QuoteIDDisplay);
        }
    }
}
