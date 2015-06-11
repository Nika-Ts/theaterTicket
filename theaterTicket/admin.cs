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
    public partial class admin : Form
    {
        SqlConnection conn;
        public admin()
        {
            InitializeComponent();

            panel1.Hide();

            this.conn = connectDb.returnConn();
            SqlCommand command = new SqlCommand();
            command.Connection = this.conn;
            command.CommandText = "select * from dbo.orderLog";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String date = reader.GetValue(3).ToString();
                String type = "სტანდარტული";
                if(reader.GetValue(4).ToString() == "2") type = "Vip";
                String quantity = reader.GetValue(5).ToString();

                SqlCommand command2 = new SqlCommand();
                command2.Connection = connectDb.returnConn();

                command2.CommandText = "select * from dbo.users where Id ="+reader.GetValue(1).ToString()+"";
                SqlDataReader read = command2.ExecuteReader();
                read.Read();
                String name = read.GetValue(1).ToString();
                String lastname = read.GetValue(2).ToString();
                read.Close();

                command2.CommandText = "select * from dbo.tickets where id =" + reader.GetValue(2).ToString() + "";
                read = command2.ExecuteReader();
                read.Read();
                String ticketName = read.GetValue(1).ToString();
                this.gridView.Rows.Add(new object[] { name, lastname, ticketName, type, quantity, date });
            }
            this.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible) { panel1.Hide(); } else panel1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String saxeli = this.textBox1.Text.ToString();
            String fasi = this.textBox2.Text.ToString();
            String date = this.dateTimePicker1.Value.ToString();

            try
            {
                conn = connectDb.returnConn();
                SqlCommand command = new SqlCommand(); 
                command.Connection = conn;
                command.CommandText = "insert into dbo.tickets(name, date, price) values(N'" + saxeli + "','" + date + "', '" + fasi + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("სპექტაკლი წარმატებით დაემატა");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}