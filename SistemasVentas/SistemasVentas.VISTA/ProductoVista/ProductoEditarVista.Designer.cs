﻿namespace SistemasVentas.VISTA.ProductoVista
{
    partial class ProductoEditarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(469, 358);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(331, 358);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(243, 300);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(434, 23);
            textBox6.TabIndex = 25;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(243, 257);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(434, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(243, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(434, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(434, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 303);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 19;
            label6.Text = "DESCRIPCION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 260);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 18;
            label5.Text = "UNIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 213);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 17;
            label4.Text = "CODIGOBARRA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "MARCA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 72);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 14;
            label1.Text = "TIPO PRODUCTO";
            // 
            // button3
            // 
            button3.Location = new Point(587, 69);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 28;
            button3.Text = "SELECCONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(587, 118);
            button4.Name = "button4";
            button4.Size = new Size(90, 23);
            button4.TabIndex = 29;
            button4.Text = "SELECCONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProductoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoEditarVista";
            Text = "ProductoEditarVista";
            Load += ProductoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}