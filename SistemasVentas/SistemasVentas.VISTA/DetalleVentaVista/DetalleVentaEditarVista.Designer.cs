﻿namespace SistemasVentas.VISTA.DetalleVentaVista
{
    partial class DetalleVentaEditarVista
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            button2.Location = new Point(490, 328);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(330, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(242, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(443, 23);
            textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(242, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(443, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(443, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 269);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 16;
            label5.Text = "SUBTOTAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 226);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 15;
            label4.Text = "PRECIOVENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 185);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 14;
            label3.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 143);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 13;
            label2.Text = "PRODUCTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 103);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "VENTA";
            // 
            // button3
            // 
            button3.Location = new Point(590, 100);
            button3.Name = "button3";
            button3.Size = new Size(95, 23);
            button3.TabIndex = 24;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(590, 140);
            button4.Name = "button4";
            button4.Size = new Size(95, 23);
            button4.TabIndex = 25;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DetalleVentaEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleVentaEditarVista";
            Text = "DetalleVentaEditarVista";
            Load += DetalleVentaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}