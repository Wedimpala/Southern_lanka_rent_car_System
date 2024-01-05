using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }
        
        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    private void customer_click(object sender,EventArgs e)
    {
     

    }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle mn = new Vehicle();
            mn.Show();

        }

        private void customer_Click_1(object sender, EventArgs e)
        {
            Customer_Info mn = new Customer_Info();
            mn.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            today_available mn = new today_available();
            mn.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Payment mn = new Payment();
            mn.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Packages mn = new Packages();
            mn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Workers mn = new Workers();
            mn.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register mn = new Register();
            mn.Show();
        }
    }
}
