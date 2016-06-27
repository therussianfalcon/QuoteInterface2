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
    
        string connectionString = "server=sql5.freemysqlhosting.net;database=sql5125420;uid=sql5125420;pwd=CuPC68fUR7;";
        public void retrieveDataFill(TextBox id) {
            int quoteNumber;
            MySqlConnection conn = new MySqlConnection("server=sql5.freemysqlhosting.net;database=sql5125420;uid=sql5125420;pwd=CuPC68fUR7;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }

            try
            {
                //get number from second panel
                quoteNumber = Convert.ToInt32(id.Text);

                string sql = "SELECT * FROM quotes WHERE QuoteID = '" + id.Text + "';";
                //string sql = "SELECT * FROM quotes WHERE QuoteID = '1';";
                ////show new panel
                //quoteRetrievePanel.Visible = true;
                //quoteMainPanel.Visible = false;

                //display quote id
                QuoteIDDisplay.Text = quoteNumber.ToString();

                //open MySQL connection
                try
                {
                    //connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //**************error with this command
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    if (rdr.Read())
                    {
                        custNameDisplay.Text = rdr.GetString(1);
                        priceDisplay.Text = rdr.GetString(2);
                        priceDisplay2.Text = rdr.GetString(3);
                        commentDisplay.Text = rdr.GetString(4);
                        int status = rdr.GetInt32(5);
                        if(status ==0)
                        {
                            unresolvedCheckbox.Checked = true;
                        }
                        else if (status >= 0)
                        {
                            unresolvedCheckbox.Checked = false;
                            sanctionedCheckbox.Checked = true;
                        }
                    }

                    else
                    {
                        MessageBox.Show("NO DATA");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reader Failure");
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //close connection to server
                conn.Close();
                //show new panel
                quoteRetrievePanel.Visible = true;
                quoteMainPanel.Visible = false;
            }

        }
        public void discountApply(double actualPrice, TextBox id)
        {
            //create instance of connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = "update sql5125420.quotes set TotalPrice='" + actualPrice.ToString() + "' where QuoteID='" + id.Text + "';";

            //attempt to open connection with sql server
            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }

            //create command
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //exectue query
            MySqlDataReader rdr = cmd.ExecuteReader();
        }
        public void textChangeEvent(Button button, TextBox textbox)
        {
            button.Enabled = !string.IsNullOrWhiteSpace(textbox.Text);
        }
    }
}
