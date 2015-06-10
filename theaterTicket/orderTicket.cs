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
    public partial class orderTicket : Form
    {
        SqlConnection conn;
        public int id;
        public orderTicket()
        {
            InitializeComponent();
            this.conn = connectDb.returnConn();
            SqlCommand command = new SqlCommand();
            command.Connection = this.conn;
            command.CommandText = "Select * from dbo.tickets";
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                combo.Items.Add(data.GetValue(0).ToString() + "-" + data.GetValue(1).ToString() + " - " + data.GetValue(2).ToString() + "-" + data.GetValue(3).ToString() + "gel");
            }
            this.conn.Close();
        }

        private void orderTicket_Load(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {
            
            if (combo.SelectedItem == null || textbox.Text.ToString() == "" || combo2.SelectedItem == null)
            {
                MessageBox.Show("შეავსეთ ყველა ველი!");
            }
            else
            {
                String speqtakli = this.combo.SelectedItem.ToString();
            int raodenoba = Convert.ToInt32(this.textbox.Text.ToString());
            String type1 = this.combo2.SelectedItem.ToString();
            int type = 1;
            if (type1 == "VIP") type = 2;
                MessageBox.Show(this.id.ToString());
            }
        }
    }
}