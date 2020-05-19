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
    public partial class Form10 : Form
    {
        public DataTable inCheck;
        Form inform;
        public DataTable indata;
        string label = "";
        public Form10(DataTable Check,DataTable data)
        {
            InitializeComponent();
            inCheck = Check;
            indata = data;
            
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i=0;i<inCheck.Rows.Count;i++)
            {
                sum += Int32.Parse(inCheck.Rows[i]["ราคา"].ToString());
                sum1 = sum * (sum2 = Int32.Parse(inCheck.Rows[i]["จำนวนวัน"].ToString()));
            }
            lbPrice.Text = sum1.ToString();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inCheck;
        }

        private void BtDelRoom_Click(object sender, EventArgs e)
        {
            for (int i=0; ;)
            {
                if (indata.Rows.Count == 0)
                    break;
                indata.Rows[i].Delete();
                
            }
            inCheck.Clear();
        }

        private void BtAddRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            inform.Show();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 from = new Form9( indata);
            
            from.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 from = new Form11(textBox1.Text,textBox2.Text,textBox3.Text,inCheck,lbPrice.Text,label);
            this.Close();
            from.Show();
        }

      /*  private void Label5_Click(object sender, EventArgs e)
        {
            label = label5.Text;
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            label = label5.Text;
        }*/
    }
}
