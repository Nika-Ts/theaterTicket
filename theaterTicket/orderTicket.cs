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
        public String id;
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
            //this.conn.Close();
            //this.conn.Open();
            //Object obj = this.id;
            //SqlCommand command1 = new SqlCommand();
            //command1.Connection = this.conn;
            //command1.CommandText = "select money from dbo.users where id = " + this.id + "";
            //Object obj =  command1.ExecuteScalar().ToString();

            this.conn.Close();
        }

        private void orderTicket_Load(object sender, EventArgs e)
        {
            this.conn = connectDb.returnConn();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = this.conn;
            command1.CommandText = "select money from dbo.users where id = " + this.id + "";
            this.balanceLabel.Text = command1.ExecuteScalar().ToString();
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

            this.conn = connectDb.returnConn();

            SqlCommand command1 = new SqlCommand();
            command1.Connection = this.conn;
            command1.CommandText = "select money from dbo.users where id = " + this.id + "";
            double money = Convert.ToDouble(command1.ExecuteScalar());

            String[] arr = speqtakli.Split('-');
            double price = Convert.ToDouble(arr[3].Replace("gel", ""));
            if (type == 2) price = price + 10; //ფასს ემატება 10 ლარი VIP ბილეთის შემთხვევაში
            money = money - (price * raodenoba);
            DateTime dateTime = DateTime.Now;

            SqlCommand command = new SqlCommand();
            SqlTransaction transaction = this.conn.BeginTransaction("transaction");
            command.Connection = this.conn;
            command.Transaction = transaction;
            try
            {
                command.CommandText = "update dbo.users set money = " + money + " where id = " + this.id + "";
                command.ExecuteNonQuery();
                command.CommandText = "insert into dbo.orderLog(UserId,TicketId,Date,Type,Quantity) values('" + this.id + "','" + arr[0] + "','" + dateTime + "', '" + type + "', '" + raodenoba + "')";
                command.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("თქვენ წარმატებით იყიდეთ ბილეთი");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("დაფიქსირადა შეცდომა, ბილეთის ყიდვა გაუქმებულია");
            }

            }
        }
    }
}