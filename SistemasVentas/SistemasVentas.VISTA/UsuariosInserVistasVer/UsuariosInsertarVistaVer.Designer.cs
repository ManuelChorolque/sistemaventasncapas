namespace SistemasVentas.VISTA.UsuariosInserVistasVer
{
    partial class UsuariosInsertarVistaVer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "PERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 92);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 141);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 194);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "FECHA REGISTRO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(584, 45);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 5;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(511, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 138);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(508, 23);
            textBox3.TabIndex = 7;
            textBox3.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Location = new Point(283, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(485, 286);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(508, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // UsuariosInsertarVistaVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuariosInsertarVistaVer";
            Text = "UsuariosInsertarVistaVer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
    }
}