using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShapeAreaCalculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxValue = new TextBox();
            labelResult = new Label();
            textBoxLength = new TextBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            textBoxRadius = new TextBox();
            textBoxHeightCone = new TextBox();
            textBoxRadiusCylinder = new TextBox();
            textBoxHeightCylinder = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 301);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 301);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 1;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 301);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 2;
            button3.Text = "Вычислить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(690, 301);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 3;
            button4.Text = "Вычислить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(35, 203);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 4;
            textBoxValue.TextChanged += textBoxValue_Text;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(12, 391);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(294, 37);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат вычислений";
            labelResult.Click += labelResult_Click;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(237, 153);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 6;
            textBoxLength.TextChanged += textBoxLenght_Text;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(237, 203);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 7;
            textBoxWidth.TextChanged += textBoxWidht_Text;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(237, 261);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 8;
            textBoxHeight.TextChanged += textBoxHeight_Text;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(483, 178);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(100, 23);
            textBoxRadius.TabIndex = 10;
            textBoxRadius.TextChanged += textBoxRadius_Text;
            // 
            // textBoxHeightCone
            // 
            textBoxHeightCone.Location = new Point(483, 232);
            textBoxHeightCone.Name = "textBoxHeightCone";
            textBoxHeightCone.Size = new Size(100, 23);
            textBoxHeightCone.TabIndex = 11;
            textBoxHeightCone.TextChanged += textBoxHeightCone_Text;
            // 
            // textBoxRadiusCylinder
            // 
            textBoxRadiusCylinder.Location = new Point(669, 178);
            textBoxRadiusCylinder.Name = "textBoxRadiusCylinder";
            textBoxRadiusCylinder.Size = new Size(100, 23);
            textBoxRadiusCylinder.TabIndex = 12;
            textBoxRadiusCylinder.TextChanged += textBoxRadiusCylinder_Text;
            // 
            // textBoxHeightCylinder
            // 
            textBoxHeightCylinder.Location = new Point(669, 232);
            textBoxHeightCylinder.Name = "textBoxHeightCylinder";
            textBoxHeightCylinder.Size = new Size(100, 23);
            textBoxHeightCylinder.TabIndex = 13;
            textBoxHeightCylinder.TextChanged += textBoxHeightCylinder_Text;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 185);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 14;
            label1.Text = "Сторона куба";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 135);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 15;
            label2.Text = "Длина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 186);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 243);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 17;
            label4.Text = "Высота";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 160);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 18;
            label5.Text = "Радиус";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 214);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 19;
            label6.Text = "Высота";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(703, 161);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 20;
            label7.Text = "Радиус";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(703, 214);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 21;
            label8.Text = "Высота";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 88);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 22;
            label9.Text = "Площадь куба";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 88);
            label10.Name = "label10";
            label10.Size = new Size(256, 15);
            label10.TabIndex = 23;
            label10.Text = "Площадь прямоугольного параллелепипеда";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(483, 88);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 24;
            label11.Text = "Площадь цилиндра";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(669, 88);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 25;
            label12.Text = "Площадь конуса";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(212, 20);
            label13.Name = "label13";
            label13.Size = new Size(387, 37);
            label13.TabIndex = 26;
            label13.Text = "Калькулятор площадей фигур";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxHeightCylinder);
            Controls.Add(textBoxRadiusCylinder);
            Controls.Add(textBoxHeightCone);
            Controls.Add(textBoxRadius);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxLength);
            Controls.Add(labelResult);
            Controls.Add(textBoxValue);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBoxValue;
        private Label labelResult;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private TextBox textBoxRadius;
        private TextBox textBoxHeightCone;
        private TextBox textBoxRadiusCylinder;
        private TextBox textBoxHeightCylinder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}