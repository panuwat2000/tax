using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int a6 = int.Parse(textBox4.Text);
                if (a6 <= 9000)
                {
                    a.Text = a6.ToString();
                }
                else
                {
                    a.Text = "9000";
                }
            }
            if (checkBox2.Checked)
            {
                int bb = int.Parse(textBox5.Text);
                if (bb <= 100000)
                {
                    b.Text = bb.ToString();
                }
                else
                {
                    b.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int cc = int.Parse(b.Text);
                int bb;
                if (cc <= 100000)
                {
                    bb = 100000 - cc;
                    c.Text = bb.ToString();

                    if (bb <= 15000)
                    {
                        c.Text = bb.ToString();
                    }
                    else
                    {
                        c.Text = "15000";
                    }
                }
                if (checkBox4.Checked)
                {
                    int dd = int.Parse(textBox7.Text);
                    if (dd <= 15000)
                    {
                        d.Text = dd.ToString();
                    }
                    else
                    {
                        d.Text = "15000";
                    }
                }
                if (checkBox5.Checked)
                {
                    int pe = int.Parse(textBox8.Text);
                    if (pe <= 10000)
                    {
                        e5.Text = pe.ToString();
                    }
                    else
                    {
                        e5.Text = "10000";
                    }
                }
                if (checkBox6.Checked)
                {
                    int ff = int.Parse(textBox9.Text);
                    if (ff <= 10000)
                    {
                        f.Text = ff.ToString();
                    }
                    else
                    {
                        f.Text = "10000";
                    }
                }
                if (checkBox7.Checked)
                {
                    int gg = int.Parse(textBox10.Text);
                    if (gg <= 500000)
                    {
                        g.Text = gg.ToString();
                    }
                    else
                    {
                        g.Text = "500000";
                    }
                }
                int p;
                int aa = int.Parse(a.Text);
                int ab = int.Parse(b.Text);
                int ac = int.Parse(c.Text);
                int ad = int.Parse(d.Text);
                int ae = int.Parse(e5.Text);
                int af = int.Parse(f.Text);
                int ag = int.Parse(g.Text);
                p = aa + ab + ac + ad + ae + af + ag;
                Program.grop2 = p;
                textBox11.Text = p.ToString();

                int b1 = int.Parse(total.Text);
                int b2 = int.Parse(textBox11.Text);
                int outcome;
                outcome = b1 - b2;
                tot.Text = outcome.ToString();

               
                }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void g_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            total.Text = Program.income.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }
    }
}