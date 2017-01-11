using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        private void button1_Click(object sender, EventArgs e)
        {
                   a= new int[5] { Convert.ToInt16(aa.Text), 
                                   Convert.ToInt16(b.Text), 
                                   Convert.ToInt16(c.Text), 
                                   Convert.ToInt16(d.Text), 
                                   Convert.ToInt16(ee.Text), 
                                 };
                   cc.Text = "";
            foreach (int q in a)
            {
                cc.Text += Convert.ToString(q) + ",";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int r = 0; r <= 5; r++)
            {
                for (int j = 0; j < 5 - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            y.Text = "";
            foreach (int o in a)
            {
                y.Text += Convert.ToString(o) + ",";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int d = 0; d <= a.Length; d++)
            {
                for (int b = 0; b < a.Length - 1; b++)
                {
                    if (a[b] < a[b + 1])
                    {
                        int temp = a[b];
                        a[b] = a[b + 1];
                        a[b + 1] = temp;
                    }
                }
            }
            y.Text = "";
            foreach (int g in a)
            {
                y.Text += Convert.ToString(g) + ",";
            }
        }

        private void aa_TextChanged(object sender, EventArgs e)
        {

        }









    }
}
