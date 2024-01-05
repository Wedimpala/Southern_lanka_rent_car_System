using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KDG1C53\SQLEXPRESS;Initial Catalog=SouthernLanka;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Login values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("record inserted succesfully");
        }
    }
}
