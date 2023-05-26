using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Крамер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = GetDoubleValueFromTextBox(textBox1);
            double a2 = GetDoubleValueFromTextBox(textBox2);
            double a3 = GetDoubleValueFromTextBox(textBox3);
            double b1 = GetDoubleValueFromTextBox(textBox4);
            double b2 = GetDoubleValueFromTextBox(textBox5);
            double b3 = GetDoubleValueFromTextBox(textBox6);
            double c1 = GetDoubleValueFromTextBox(textBox7);
            double c2 = GetDoubleValueFromTextBox(textBox8);
            double c3 = GetDoubleValueFromTextBox(textBox9);
            double d1 = GetDoubleValueFromTextBox(textBox10);
            double d2 = GetDoubleValueFromTextBox(textBox11);
            double d3 = GetDoubleValueFromTextBox(textBox12);

            double D = (a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (a3 * b2 * c1) - (b3 * c2 * a1) - (c3 * a2 * b1);
            double Dx = (d1 * b2 * c3) + (b1 * c2 * d3) + (c1 * d2 * b3) - (d3 * b2 * c1) - (b3 * c2 * d1) - (c3 * d2 * b1);
            double Dy = (a1 * d2 * c3) + (d1 * c2 * a3) + (c1 * a2 * d3) - (a3 * d2 * c1) - (d3 * c2 * a1) - (c3 * a2 * d1);
            double Dz = (a1 * b2 * d3) + (b1 * d2 * a3) + (d1 * a2 * b3) - (a3 * b2 * d1) - (b3 * d2 * a1) - (d3 * a2 * b1);

            if (D == 0)
            {
                label1.Text = "Система уравнений не имеет однозначного решения.";
            }
            else
            {
                double x = Dx / D;
                double y = Dy / D;
                double z = Dz / D;

                label1.Text = $"Решением системы уравнений является:\n x = {x}\n y = {y}\n z = {z}";
            }
        }

        private double GetDoubleValueFromTextBox(System.Windows.Forms.TextBox textBox)
        {
            double value;

            if (!double.TryParse(textBox.Text, out value))
            {
                MessageBox.Show("Пожалуйста, введите действительный номер!");
                throw new Exception("Неверный ввод номера");
            }

            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}