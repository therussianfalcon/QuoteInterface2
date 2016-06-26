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
        public void retrieveDataFill() {
            int quoteNumber;
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
                    try
                    {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
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
        public void textChangeEvent(Button button, TextBox textbox)
        {
            button.Enabled = !string.IsNullOrWhiteSpace(textbox.Text);
        }
    }
}
