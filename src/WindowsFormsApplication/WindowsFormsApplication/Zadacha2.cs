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
    public partial class Zadacha2 : Form
    {
        public Zadacha2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text_box1 = textBox1.Text;
                string text_box2 = textBox2.Text;

                double x = double.Parse(text_box1);
                double y = double.Parse(text_box2);

                if ((y>=x*x)&&(x*x+y*y<=1))
                {
                    textBox3.Text = "Принадлежит";

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
