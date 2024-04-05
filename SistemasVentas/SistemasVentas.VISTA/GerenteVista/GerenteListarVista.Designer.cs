namespace SistemasVentas.VISTA.GerenteVista
{
    partial class GerenteListarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenteListarVista));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            button15 = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(705, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 65);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 8);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 12;
            label2.Text = "SISTEMA DE VENTAS";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 64);
            panel4.Controls.Add(button15);
            panel4.Location = new Point(2, 488);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 52);
            panel4.TabIndex = 24;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.MenuHighlight;
            button15.DialogResult = DialogResult.OK;
            button15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(14, 7);
            button15.Name = "button15";
            button15.Size = new Size(110, 32);
            button15.TabIndex = 17;
            button15.Text = "MODIFICAR";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(636, 468);
            dataGridView1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button13);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(2, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 413);
            panel3.TabIndex = 22;
            // 
            // button14
            // 
            button14.BackColor = Color.CadetBlue;
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(11, 387);
            button14.Name = "button14";
            button14.Size = new Size(113, 23);
            button14.TabIndex = 26;
            button14.Text = "DETALLE INGRESO";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click_1;
            // 
            // button13
            // 
            button13.BackColor = Color.CadetBlue;
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(11, 358);
            button13.Name = "button13";
            button13.Size = new Size(113, 23);
            button13.TabIndex = 17;
            button13.Text = "DETALLE VENTA";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.CadetBlue;
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(11, 329);
            button12.Name = "button12";
            button12.Size = new Size(113, 23);
            button12.TabIndex = 25;
            button12.Text = "PROVEE";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click_1;
            // 
            // button11
            // 
            button11.BackColor = Color.CadetBlue;
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(11, 300);
            button11.Name = "button11";
            button11.Size = new Size(113, 23);
            button11.TabIndex = 24;
            button11.Text = "PRODUCTO";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button10
            // 
            button10.BackColor = Color.CadetBlue;
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(11, 271);
            button10.Name = "button10";
            button10.Size = new Size(113, 23);
            button10.TabIndex = 23;
            button10.Text = "VENTA";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.CadetBlue;
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(11, 242);
            button9.Name = "button9";
            button9.Size = new Size(113, 23);
            button9.TabIndex = 22;
            button9.Text = "INGRESO";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.CadetBlue;
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(11, 213);
            button8.Name = "button8";
            button8.Size = new Size(113, 23);
            button8.TabIndex = 21;
            button8.Text = "CLIENTE";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.CadetBlue;
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(11, 184);
            button7.Name = "button7";
            button7.Size = new Size(113, 23);
            button7.TabIndex = 20;
            button7.Text = "USUARIO ROL";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.CadetBlue;
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(11, 155);
            button6.Name = "button6";
            button6.Size = new Size(113, 23);
            button6.TabIndex = 19;
            button6.Text = "USUARIO";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.CadetBlue;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(12, 126);
            button5.Name = "button5";
            button5.Size = new Size(110, 23);
            button5.TabIndex = 18;
            button5.Text = "PROVEEDOR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(11, 97);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 16;
            button4.Text = "MARCA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(11, 68);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 15;
            button3.Text = "TIPO PRODUCTO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(11, 39);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 14;
            button2.Text = "ROL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(11, 10);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 13;
            button1.Text = "PERSONA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // GerenteListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 539);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "GerenteListarVista";
            Text = "GerenteListarVista";
            Load += GerenteListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel4;
        private Button button15;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}