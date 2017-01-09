using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class z : Form
    {
        public z()
        {
            InitializeComponent();
        }

        Random aa = new Random();
        int[] a = new int[5];

        private void button1_Click(object sender, EventArgs e)
        {
                p.Text = "";
                for (int i = 0; i <= 4; i++)
                {
                    a[i] = aa.Next(0, 100);
                }
            
                foreach (int q in a)
                {
                    p.Text += Convert.ToString(q) + ",";
                }



               
            for(int r=0;r<=a.Length;r++)
            {
                for(int j=0;j<a.Length-1;j++)
                {
                    if(a[j]>a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            y.Text = "";
            foreach(int o in a)
            {
                y.Text += Convert.ToString(o) + ",";
            }


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
            nn.Text = "";
            foreach (int g in a)
            {
                nn.Text += Convert.ToString(g) + ",";
            }







            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            


        }
    }
}
