using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tmproject
{
    public partial class Form11 : Form
    {
        public Form11(string textBox1,string textBox2,string textBox3,DataTable inCheck,string lbPrice,string label)
        {
            InitializeComponent();
            lbN.Text = textBox1;
            lbL.Text = textBox2;
            lbPh.Text = textBox3;
            dataGridView1.DataSource = inCheck;
            //label11.Text = label;
            lbP.Text = lbPrice;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
