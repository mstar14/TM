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
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add("time_in");
            data.Columns.Add("time_out");
            data.Columns.Add("num_room");
            data.Columns.Add("price");

        }

        private void BtIn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(data);
            data = form.indata;
            //form.Show();
            this.Hide();
            form.ShowDialog();
        }
    }
}
