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

namespace theaterTicket
{
    public partial class authorization : Form
    {
        SqlConnection conn;
        public authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mail = this.mail.Text.ToString();
            String pass = this.password.Text.ToString();
            if (mail == "" || pass == "")
            {
                MessageBox.Show("ჩაწერეთ მეილი და პაროლი");
            }
            else
            {
                try
                {
                    this.conn = connectDb.returnConn();
                    SqlCommand command = new SqlCommand();
                    command.Connection = this.conn;
                    command.CommandText = "select pass from dbo.users where mail ='"+mail+"'";
                    Object value = command.ExecuteScalar();
                    if (value != null) {
                        String dbPass = command.ExecuteScalar().ToString();
                        if (dbPass != pass) { MessageBox.Show("პაროლი არასწორია!"); }
                        else
                        {
                            orderTicket window = new orderTicket();
                            this.Close();
                            window.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("მეილი ვერ მოიძებნა");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    this.Close();
                }
                finally
                {
                    this.conn.Close();
                }
            }
        }
    }
}
