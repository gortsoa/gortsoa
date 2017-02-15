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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ans = new int[4];
        TextBox[] guessText;

        private void reset()
        {
            a5.Text = "";
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                guessText[i].Text = "";
                bool repeat = false;
                do
                {
                    ans[i] = r.Next(0, 10);
                    for (int t = 0; t < i; t++)
                        if (ans[i] == ans[t])
                            repeat = true;
                } while (repeat);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 0;
            b = 0;
            for (int i = 0; i < 4; i++)
            {
                int num = int.Parse(guessText[i].Text);
                for (int r = 0; r < 4; r++)
                {
                    if (num == ans[r])
                        if (i == r)
                            a++;
                  
                }

                for (int r = 0; r < 4; r++)
                {
                    if (num == ans[r])
                        
                            b++;
                 
                }




            }
            if (a == 4)
            {
                MessageBox.Show("答對了");
            }
            else
            {
                string d = "";
                for (int i = 0; i < 4; i++)
                    d += guessText[i].Text;
                a5.Text = d + "->" + a + "A" + b + "B";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void form1_load(object sender, EventArgs e)
        {
            guessText = new TextBox[4] { a1, a2, a3, a4 };

            reset();
        }
    }
}
