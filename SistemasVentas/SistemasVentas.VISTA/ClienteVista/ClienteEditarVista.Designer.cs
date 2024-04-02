namespace SistemasVentas.VISTA.ClienteVista
{
    partial class ClienteEditarVista
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(322, 262);
            button2.Name = "button2";
            button2.Size = new Size(95, 29);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(179, 262);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(6, 198);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 10;
            label3.Text = "CODIGO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(26, 144);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 9;
            label2.Text = "TIPO CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "PERSONA";
            // 
            // button3
            // 
            button3.Location = new Point(398, 83);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 16;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 56);
            panel1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(182, 8);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 0;
            label4.Text = "EDITAR CLIENTE";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(537, 320);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Panel panel1;
        private Label label4;
    }
}