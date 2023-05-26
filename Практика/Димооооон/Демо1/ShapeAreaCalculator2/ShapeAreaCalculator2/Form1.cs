using System;
using System.Windows.Forms;

namespace ShapeAreaCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxValue_Text(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLenght_Text(object sender, EventArgs e)
        {

        }

        private void textBoxWidht_Text(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_Text(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(textBoxValue.Text);
                double area = 6 * Math.Pow(side, 2);
                labelResult.Text = $"Площадь куба = {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBoxLength.Text);
                double width = double.Parse(textBoxWidth.Text);
                double height = double.Parse(textBoxHeight.Text);
                double area = 2 * (length * width + length * height + width * height);
                labelResult.Text = $"Площадь прямоугольного параллелепипеда = {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBoxRadius.Text);
                double height = double.Parse(textBoxHeightCone.Text);
                double area = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
                labelResult.Text = $"Площадь конуса = {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBoxRadiusCylinder.Text);
                double height = double.Parse(textBoxHeightCylinder.Text);
                double area = 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
                labelResult.Text = $"Площадь цилиндра = {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void textBoxRadius_Text(object sender, EventArgs e)
        {

        }

        private void textBoxHeightCone_Text(object sender, EventArgs e)
        {

        }

        private void textBoxRadiusCylinder_Text(object sender, EventArgs e)
        {

        }

        private void textBoxHeightCylinder_Text(object sender, EventArgs e)
        {

        }
    }
}