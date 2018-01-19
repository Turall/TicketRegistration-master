using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.Visible = false;
            panel1.Visible = false;
        }
       
        int boyukler = 0,korpeler = 0,usaqlar = 0,sum = 0,bcount = 0,kcount = 0,ucount = 0;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            textBox2.Text = Form2.str;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(boyukler == 0)
            {
                button8.Enabled = false;
            }
            if (usaqlar == 0)
            {
                button9.Enabled = false;
            }
            if (korpeler == 0)
            {
                button10.Enabled = false;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            monthCalendar1.MinDate = monthCalendar1.TodayDate;
            monthCalendar1.Visible = true;
        }

       
        static bool select = false;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (select == false)
            {
                textBox3.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                select = true;
                monthCalendar1.MinDate = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.ToShortDateString());
                monthCalendar1.Visible = false;
            }
            else
            {
                textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                select = false;
                monthCalendar1.Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            boyukler++;
            label2.Text = boyukler.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (boyukler > 0)
            {
                button8.Enabled = true;
            }
            bcount++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            usaqlar++;
            label9.Text = usaqlar.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (usaqlar > 0)
            {
                button9.Enabled = true;
            }
            ucount++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            korpeler++;
            label11.Text = korpeler.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (korpeler > 0)
            {
                button10.Enabled = true;
            }
            kcount++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boyukler--;
            label2.Text = boyukler.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (boyukler > 0)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
            }
            bcount--;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            usaqlar--;
            label9.Text = usaqlar.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (usaqlar > 0)
            {
                button9.Enabled = true;
            }
            else button9.Enabled = false;

            ucount--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int qiymet = 0;
            if (comboBox2.Text == "Ekonom" && Form2.str == "Ankara, Esenboğa, Türkiyə")
            {
             qiymet = (bcount * 150) + (ucount * 120) + (kcount * 100);
            MessageBox.Show("Qalxma : " + textBox2.Text + "\n" + "Vaxt : " + textBox3.Text + "\n" + "Enme : " + textBox1.Text + "\n" + "Vaxt : " + textBox4.Text + "\n" +
                "Xidmet Sinfi : " + comboBox2.Text + "\n" + "Bilet Sayi : " + textBox5.Text + "\n" + "Qiymet :" + qiymet + "Azn" +"\n" );
            }
            else if(comboBox2.Text == "Ekonom" && Form2.str == "Ekaterinburg, Rusiya")
            {
                qiymet = (bcount * 180) + (ucount * 140) + (kcount * 120);
                MessageBox.Show("Qalxma : " + textBox2.Text + "\n" + "Vaxt : " + textBox3.Text + "\n" + "Enme : " + textBox1.Text + "\n" + "Vaxt : " + textBox4.Text + "\n" +
                "Xidmet Sinfi : " + comboBox2.Text + "\n" + "Bilet Sayi : " + textBox5.Text + "\n" + "Qiymet :" + qiymet + "Azn" + "\n");
            }
           else if (comboBox2.Text == "Biznes" && Form2.str == "Ankara, Esenboğa, Türkiyə")
            {
                qiymet = (bcount * 250) + (ucount * 200) + (kcount * 150);
                MessageBox.Show("Qalxma : " + textBox2.Text + "\n" + "Vaxt : " + textBox3.Text + "\n" + "Enme : " + textBox1.Text + "\n" + "Vaxt : " + textBox4.Text + "\n" +
                    "Xidmet Sinfi : " + comboBox2.Text + "\n" + "Bilet Sayi : " + textBox5.Text + "\n" + "Qiymet :" + qiymet + "Azn" + "\n");
            }
            else if (comboBox2.Text == "Biznes" && Form2.str == "Ekaterinburg, Rusiya")
            {
                qiymet = (bcount * 280) + (ucount * 250) + (kcount * 200);
                MessageBox.Show("Qalxma : " + textBox2.Text + "\n" + "Vaxt : " + textBox3.Text + "\n" + "Enme : " + textBox1.Text + "\n" + "Vaxt : " + textBox4.Text + "\n" +
                "Xidmet Sinfi : " + comboBox2.Text + "\n" + "Bilet Sayi : " + textBox5.Text + "\n" + "Qiymet :" + qiymet + "Azn" + "\n");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            textBox1.Text = Form2.str;
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            korpeler--;
            label11.Text = korpeler.ToString();
            sum = korpeler + usaqlar + boyukler;
            textBox5.Text = sum.ToString();
            if (korpeler > 0)
            {
                button10.Enabled = true;
            }
            else button10.Enabled = false;

            kcount--;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            monthCalendar1.Visible = true ;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
    
}
