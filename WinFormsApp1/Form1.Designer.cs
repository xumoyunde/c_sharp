﻿namespace WinFormsApp1
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            checkedRadioButton = new RadioButton();
            checkedCheckBox = new RadioButton();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 206);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 0;
            button1.Text = "O'zgartirish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(470, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(470, 184);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(470, 223);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 127);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 8;
            label1.Text = "Elementlar sonini kiriting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 127);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 9;
            label2.Text = "Element nomini kiriting";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(97, 267);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 11;
            button2.Text = "Yaratish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkedRadioButton
            // 
            checkedRadioButton.AutoSize = true;
            checkedRadioButton.Location = new Point(97, 202);
            checkedRadioButton.Name = "checkedRadioButton";
            checkedRadioButton.Size = new Size(135, 19);
            checkedRadioButton.TabIndex = 12;
            checkedRadioButton.TabStop = true;
            checkedRadioButton.Text = "RadioButton yaratish";
            checkedRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkedCheckBox
            // 
            checkedCheckBox.AutoSize = true;
            checkedCheckBox.Location = new Point(97, 227);
            checkedCheckBox.Name = "checkedCheckBox";
            checkedCheckBox.Size = new Size(122, 19);
            checkedCheckBox.TabIndex = 13;
            checkedCheckBox.TabStop = true;
            checkedCheckBox.Text = "CheckBox yaratish";
            checkedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(97, 359);
            button3.Name = "button3";
            button3.Size = new Size(194, 47);
            button3.TabIndex = 14;
            button3.Text = "Tanlangan elementni o'chirish";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(button3);
            Controls.Add(checkedCheckBox);
            Controls.Add(checkedRadioButton);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private RadioButton checkedRadioButton;
        private RadioButton checkedCheckBox;
        private Button button3;
    }
}