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
    public partial class Form4 : Form
    {
        DataTable indata;
        public Form4(DataTable data)
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

        private void Standard_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Supe_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Deluxe_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Suite_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9(indata);
            //form.Show();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }
    }
}
