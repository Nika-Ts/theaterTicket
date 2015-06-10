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
    public partial class registration : Form
    {
        SqlConnection conn;
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = this.name.Text.ToString();
            String lastname = this.lastname.Text.ToString();
            String mail = this.mail.Text.ToString();
            String pass = this.password.Text.ToString();
            if (name == "" || lastname == "" || mail == "" || pass == "")
            {
                MessageBox.Show("გთხოვთ შეავსეთ ყველა ველი!");
            }
            else
            {
                try
                {
                    this.conn = connectDb.returnConn();
                    SqlCommand query = new SqlCommand();
                    query.Connection = conn;
                    query.CommandText = "insert into dbo.users(Name, Lastname, Mail, Pass) Values('" + name + "','" + lastname + "','" + mail + "', '" + pass + "')";
                    query.ExecuteNonQuery();
                    MessageBox.Show("რეგისტრაცია წარმატებით დასრულდა, გთხოვთ გაიაროთ ავტორიზაცია");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    this.conn.Close();
                    this.Close();
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
