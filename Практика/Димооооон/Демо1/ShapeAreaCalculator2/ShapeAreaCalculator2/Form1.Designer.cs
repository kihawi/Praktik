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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(151, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(347, 214);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(456, 214);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(138, 256);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 4;
            textBoxValue.TextChanged += textBoxValue_Text;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(326, 389);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "label1";
            labelResult.Click += labelResult_Click;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(289, 255);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 6;
            textBoxLength.TextChanged += textBoxLenght_Text;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(289, 284);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 7;
            textBoxWidth.TextChanged += textBoxWidht_Text;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(289, 313);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 8;
            textBoxHeight.TextChanged += textBoxHeight_Text;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(431, 255);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(100, 23);
            textBoxRadius.TabIndex = 10;
            textBoxRadius.TextChanged += textBoxRadius_Text;
            // 
            // textBoxHeightCone
            // 
            textBoxHeightCone.Location = new Point(431, 284);
            textBoxHeightCone.Name = "textBoxHeightCone";
            textBoxHeightCone.Size = new Size(100, 23);
            textBoxHeightCone.TabIndex = 11;
            textBoxHeightCone.TextChanged += textBoxHeightCone_Text;
            // 
            // textBoxRadiusCylinder
            // 
            textBoxRadiusCylinder.Location = new Point(553, 255);
            textBoxRadiusCylinder.Name = "textBoxRadiusCylinder";
            textBoxRadiusCylinder.Size = new Size(100, 23);
            textBoxRadiusCylinder.TabIndex = 12;
            textBoxRadiusCylinder.TextChanged += textBoxRadiusCylinder_Text;
            // 
            // textBoxHeightCylinder
            // 
            textBoxHeightCylinder.Location = new Point(553, 284);
            textBoxHeightCylinder.Name = "textBoxHeightCylinder";
            textBoxHeightCylinder.Size = new Size(100, 23);
            textBoxHeightCylinder.TabIndex = 13;
            textBoxHeightCylinder.TextChanged += textBoxHeightCylinder_Text;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}