namespace SistemasVentas.VISTA.ProveeVista
{
    partial class ProveeEditarVista
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
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(393, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(462, 312);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(303, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(264, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 249);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 14;
            label4.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 206);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 165);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 12;
            label2.Text = "PROVEEDOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 118);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 11;
            label1.Text = "PRODUCTO";
            // 
            // button3
            // 
            button3.Location = new Point(554, 115);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 21;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(554, 162);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 22;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ProveeEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProveeEditarVista";
            Text = "ProveeEditarVista";
            Load += ProveeEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}