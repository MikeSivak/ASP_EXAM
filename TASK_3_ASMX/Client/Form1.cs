using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        localhost.WebService1 client;
        public Form1()
        {
            InitializeComponent();

            this.client = new localhost.WebService1();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //GetSum
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(this.client.Sum(2, 3));
        }

        //GetMul
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(this.client.Mul(2, 3));
        }

        //GetSub
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(this.client.Sub(3, 2));
        }
    }
}
