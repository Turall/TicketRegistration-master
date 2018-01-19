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
        Form2 form2 = new Form2();
        int boyukler = 0,korpeler = 0,usaqlar = 0,sum = 0;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            textBox1.Text = Form2.str;
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
