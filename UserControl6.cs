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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int study = int.Parse(textBox5.Text);
            int government = int.Parse(textBox6.Text);
            int sport = int.Parse(textBox7.Text);
            int public1 = int.Parse(textBox8.Text);
            int pabuk = int.Parse(textBox9.Text);
            int general = int.Parse(textBox10.Text);
            int politics = int.Parse(numericUpDown1.Text);
            int to = int.Parse(textBox4.Text);//รายได้พึงประะเมิน
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int x = 0;
            int tot;//บริจาค
            int total;//รายได้สุทธิ
            int taxtotal;//สามารถลดหย่อนได้

            a1 = (study * 2);
            textBox11.Text = a1.ToString();
            a2 = (government * 2);
            textBox12.Text = a2.ToString();
            a3 = (sport * 2);
            textBox13.Text = a3.ToString();
            a4 = (public1 * 2);
            textBox14.Text = a4.ToString();
            a5 = pabuk;
            textBox15.Text = a5.ToString();
            a6 = general;
            textBox16.Text = a6.ToString();
            a7 = politics;
            textBox17.Text = a7.ToString();

            taxtotal = (to * 10) / 100;//สามารถลดหย่อนได้ = รายได้รวมที่หักค่าลดหย่อนอื่นๆแล้ว

            tot = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//บริจาค
            Program.grop4 = tot;
            if (tot > taxtotal)
            {
                x = taxtotal;
            }
            else if (tot < taxtotal)
            {
                x = tot;
            }
            textBox18.Text = x.ToString();

            total = to - x;//รายได้สุทธิ = รายได้พึงประเมิน-ภาษีที่ลดหย่อนได้
            textBox19.Text = total.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int total;
            total = Program.income;

            textBox4.Text = total.ToString();
        }
    }
}
