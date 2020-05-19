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
    public partial class Form9 : Form
    {
        DataTable data = new DataTable();
        public DataTable indata;
        DataTable Check = new DataTable();
        string numberroom = "";
        string roomrate = "";
        public Form9(DataTable data)
        {
            InitializeComponent();
            indata = data;
            chkcolor();
            Check.Columns.Add("Time In");
            Check.Columns.Add("Time Out");
            Check.Columns.Add("Number");
            Check.Columns.Add("ราคา");
            Check.Columns.Add("จำนวนวัน");
        }
        public void chkcolor()
        {
            Button1.BackColor = Color.Lime;
            Button2.BackColor = Color.Lime;
            Button3.BackColor = Color.Lime;
            Button4.BackColor = Color.Lime;
            Button5.BackColor = Color.Lime;
            Button6.BackColor = Color.Lime;
            Button7.BackColor = Color.Lime;
            Button8.BackColor = Color.Lime;
            Button9.BackColor = Color.Lime;
            Button10.BackColor = Color.Lime;
            button11.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;
            button13.BackColor = Color.Lime;
            button14.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;
            button16.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;
            button19.BackColor = Color.Lime;
            button20.BackColor = Color.Lime;
            button21.BackColor = Color.Lime;
            button22.BackColor = Color.Lime;
            button23.BackColor = Color.Lime;
            button24.BackColor = Color.Lime;
            button25.BackColor = Color.Lime;
            button26.BackColor = Color.Lime;
            button27.BackColor = Color.Lime;
            button28.BackColor = Color.Lime;

        }
        public void Addtime(string numberroom,string roomrate)
        {
            int dayin = Int32.Parse(dateTimePicker1.Value.Day.ToString());
            int dayout = Int32.Parse(dateTimePicker2.Value.Day.ToString());
            int month_n = Int32.Parse(dateTimePicker1.Value.Month.ToString());
            int month_o = Int32.Parse(dateTimePicker2.Value.Month.ToString());
            int year_n = Int32.Parse(dateTimePicker1.Value.Year.ToString());
            int year_o = Int32.Parse(dateTimePicker1.Value.Year.ToString());
            Month(dayin, dayout, month_n, month_o, year_n, year_o,numberroom,roomrate);
        }
        public void Month(int dayin,int dayout,int month_n,int month_o,int year_n,int year_o,string numberroom,string roomrate)
        {
            int[] a1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] mchk = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] sum = new Int32[10];
            string addmonth_n = "";
            sum[0] = dayin;
            var addyear_n = year_n.ToString();
            var chk1 = dateTimePicker1.Value.ToString();
            var chkyearlength = dateTimePicker1.Value.ToString();
            string yearinsub = dateTimePicker1.Value.ToString().Substring(chkyearlength.Length - 4);
            var chkmonthlength = dateTimePicker1.Value.ToString();
            string stringsup = dateTimePicker1.Value.ToString().Substring(chkmonthlength.Length - 5, 1);
            int numberDay = 0;
            for (int i=1;i<=12;i++)
            {
                if(month_n == i)
                {
                    addmonth_n = mchk[i];
                }
            }
            int chk = 0;
            for (int i =0; ;i++)
            {
                for (int ii = 0; ii < indata.Rows.Count;ii++)
                {
                    if (sum[7] < 10)
                    {
                        if ("0" + sum[7].ToString() +stringsup+ + month_n+stringsup + yearinsub == indata.Rows[ii][0].ToString() && numberroom == indata.Rows[ii][2].ToString())
                        {
                            chk++;
                        }
                    }
                    else if(sum[7] > 10)
                    {
                        if (sum[7].ToString() + stringsup + month_n + stringsup + yearinsub == indata.Rows[ii][0].ToString() && numberroom == indata.Rows[ii][2].ToString())
                        {
                            chk++;
                        }
                    }
                }
                if (chk == 0)
                {
                    numberDay++;
                    indata.Rows.Add(sum[0] + "-" + stringsup + month_n + stringsup + yearinsub, dateTimePicker2.Value.ToString(), numberroom, roomrate);
                    Check.Rows[Check.Rows.Count - 1]["จำนวนวัน"] = numberDay.ToString();
                }
                if (sum[0] == dayout)
                    break;
                sum[0]++;
            }
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 from = new Form10(Check,indata);
            //indata = from;
            from.Show();
            Check = from.inCheck;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.BackColor == Color.Lime)
            {
                int chk = 0;
                Button1.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s101" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }
                    
                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s101";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s101", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button1.BackColor = Color.Lime;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Button2.BackColor == Color.Lime)
            {
                int chk = 0;
                Button2.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s102" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s102";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s102", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button2.BackColor = Color.Lime;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.BackColor == Color.Lime)
            {
                int chk = 0;
                Button3.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s103" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s103";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s103", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button3.BackColor = Color.Lime;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Button4.BackColor == Color.Lime)
            {
                int chk = 0;
                Button4.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s104" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s104";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s104", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button4.BackColor = Color.Lime;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Button5.BackColor == Color.Lime)
            {
                int chk = 0;
                Button5.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s105" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s105";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s105", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button5.BackColor = Color.Lime;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (Button10.BackColor == Color.Lime)
            {
                int chk = 0;
                Button10.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s106" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s106";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s106", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button10.BackColor = Color.Lime;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (Button9.BackColor == Color.Lime)
            {
                int chk = 0;
                Button9.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s107" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s107";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s107", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button9.BackColor = Color.Lime;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Button8.BackColor == Color.Lime)
            {
                int chk = 0;
                Button8.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s108" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s108";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s108", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button8.BackColor = Color.Lime;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Button7.BackColor == Color.Lime)
            {
                int chk = 0;
                Button7.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s109" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s109";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s109", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button7.BackColor = Color.Lime;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Button6.BackColor == Color.Lime)
            {
                int chk = 0;
                Button6.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s110" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s110";
                    roomrate = "600";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s110", "600","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                Button6.BackColor = Color.Lime;
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Lime)
            {
                int chk = 0;
                button18.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s201" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s201";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s201", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button18.BackColor = Color.Lime;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Lime)
            {
                int chk = 0;
                button17.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s202" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s202";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s202", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button17.BackColor = Color.Lime;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Lime)
            {
                int chk = 0;
                button16.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s203" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s203";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s203", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button16.BackColor = Color.Lime;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Lime)
            {
                int chk = 0;
                button15.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s204" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s204";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s204", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button15.BackColor = Color.Lime;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Lime)
            {
                int chk = 0;
                button11.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s208" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s208";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s208", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button11.BackColor = Color.Lime;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Lime)
            {
                int chk = 0;
                button12.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s207" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s207";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s207", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button12.BackColor = Color.Lime;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Lime)
            {
                int chk = 0;
                button13.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s206" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s206";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s206", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button13.BackColor = Color.Lime;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Lime)
            {
                int chk = 0;
                button14.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s205" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s205";
                    roomrate = "800";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s205", "800","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button14.BackColor = Color.Lime;
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Lime)
            {
                int chk = 0;
                button24.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s301" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s301";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s301", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button24.BackColor = Color.Lime;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Lime)
            {
                int chk = 0;
                button23.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s302" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s302";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s302", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button23.BackColor = Color.Lime;
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Lime)
            {
                int chk = 0;
                button22.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s303" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s303";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s303", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button22.BackColor = Color.Lime;
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Lime)
            {
                int chk = 0;
                button19.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s306" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s306";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s306", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button19.BackColor = Color.Lime;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Lime)
            {
                int chk = 0;
                button20.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s305" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s305";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s305", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button20.BackColor = Color.Lime;
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Lime)
            {
                int chk = 0;
                button21.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s304" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s304";
                    roomrate = "1000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s304", "1000","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button21.BackColor = Color.Lime;
            }
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.Lime)
            {
                int chk = 0;
                button28.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s401" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s401";
                    roomrate = "1500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s401", "1500","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button28.BackColor = Color.Lime;
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.Lime)
            {
                int chk = 0;
                button27.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s402" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s402";
                    roomrate = "1500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s402", "1500","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button27.BackColor = Color.Lime;
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Lime)
            {
                int chk = 0;
                button25.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s404" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s404";
                    roomrate = "1500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s404", "1500","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button25.BackColor = Color.Lime;
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Lime)
            {
                int chk = 0;
                button26.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {

                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "s403" == indata.Rows[i]["num_room"].ToString())
                    {
                        chk++;
                    }

                }
                if (chk == indata.Rows.Count)
                {
                    numberroom = "s403";
                    roomrate = "1500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "s403", "1500","");
                    Addtime(numberroom, roomrate);
                }
            }
            else
            {
                button26.BackColor = Color.Lime;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Button[] btn = { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, };
            for(int i = 0;i<btn.Length;i++)
            {
                btn[i].BackColor = Color.Lime;
            }
            for (int i =0;i<indata.Rows.Count;i++)
            {
                for (int ii = 0 ;i < btn.Length ; ii++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString())
                    {
                        if (indata.Rows[i][2].ToString() == btn[ii].Text)
                        {
                            btn[ii].BackColor = Color.Red;
                        }
                    }
                }
                /*if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString())
                {
                    for (int ii=0;ii<btn.Length;ii++)
                    {
                        if (btn[ii].Text == indata.Rows[i]["numberroom"].ToString())
                        {
                            btn[ii].BackColor = Color.Red
                        }
                    }
                }*/
            }
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 from = new Form4(Check);
            from.Show();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
