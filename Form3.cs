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
    public partial class Form3 : Form
    {
        DataTable indata;
        public Form3(DataTable data)
        {
            InitializeComponent();
            indata = data;
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                pictureBox1.Visible = true;
            }
        }
    }
}
