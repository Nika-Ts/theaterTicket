using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theaterTicket
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration window = new registration();
            window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            authorization window = new authorization();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin window = new admin();
            window.Show();
        }
    }
}
