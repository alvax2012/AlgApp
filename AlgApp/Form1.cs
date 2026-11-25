using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AlgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Text = DateTime.Now.ToString();  //CustomFormat = "dd.MM.yyyy";
            this.radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double f = 0;

            try
            {
                double x = Convert.ToDouble(this.textBox6.Text);
                double y = Convert.ToDouble(this.textBox7.Text);


                if (radioButton1.Checked == true)
                {
                    f = Math.Cos(x);
                }

                if (radioButton1.Checked == true)
                {
                    f = Math.Cos(x);
                }
                if (radioButton2.Checked == true)
                {
                    f = Math.Pow(y, 2);
                }
                if (radioButton3.Checked == true)
                {
                    f = Math.Exp(x);
                }



                

                //if (x >= 1 & x <= 5)
                //{
                //    Console.WriteLine("Отрицательное число");
                //}
                //else if (number == 0)
                //{
                //    Console.WriteLine("Нулевое число");
                //}
                //else if (number > 0)
                //{
                //    Console.WriteLine("Положительное число");
                //}
                //else
                //{
                //    Console.WriteLine("Другое число");
                //}


            }
            catch (Exception ex)
            {
                // Защита от ввода букв вместо чисел
                MessageBox.Show("Пожалуйста, введите корректные числовые значения!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double x = Convert.ToDouble(this.textBox1.Text); ;

                if (x == 0)
                {
                    MessageBox.Show("Ошибка: деление на ноль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }


                double y = Convert.ToDouble(this.textBox2.Text);
                double z = Convert.ToDouble(this.textBox3.Text);

                double result = Math.Pow(Math.Tan(Math.Sqrt(x) - Math.Pow(y, 3)), 5) + Math.Exp(y/x) * Math.Sin(z * z);


                this.textBox4.Text = result.ToString("F4"); // Форматирование до 4 знаков
            }
            catch (Exception ex)
            {
                // Защита от ввода букв вместо чисел
                MessageBox.Show("Пожалуйста, введите корректные числовые значения!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.ForeColor = Color.Red;
            }
            else
            {
                textBox5.ForeColor = Color.Black;

            }
        }
    }
}
