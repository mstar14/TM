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
    public partial class Form5 : Form
    {
        DataTable indata;
        public Form5(DataTable data)
        {
            InitializeComponent();
            indata = data;
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
