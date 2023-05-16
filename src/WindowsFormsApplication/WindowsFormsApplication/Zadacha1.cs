using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Zadacha1 : Form
    {
        public Zadacha1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text_box1 = textBox1.Text;
                string text_box2 = textBox2.Text;

                int x = int.Parse(text_box1);
                int y = int.Parse(text_box2);

                if ((x>=-4)&&(x<=5)&&(y<=4)&&(y>=-3))
                {
                    if ((x >= 2) && (x <= 5) && (y >= 0) && (y <= 4)) 
                    {
                        textBox3.Text = "Не принадлежит";
                    }
                    else if ((x>=-4)&&(x<=-2)&&(y>=0)&&(y<=4))
                    {
                        textBox3.Text = "Не принадлежит";
                    }
                    else
                    {
                        textBox3.Text = "Принадлежит";
                    }
                    
                }

                else
                {
                    textBox3.Text = "Не принадлежит";

                }

            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
