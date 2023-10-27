namespace proyecto_final
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            btnbase = new Button();
            panel5 = new Panel();
            txtid = new TextBox();
            label2 = new Label();
            btneditar = new Button();
            btnbuscar = new Button();
            txtvalidar = new TextBox();
            label9 = new Label();
            txtcorreo = new TextBox();
            label8 = new Label();
            btnguardar = new Button();
            txtcontrasena = new TextBox();
            txtusuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 76);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(778, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 76);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(80, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 86);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightBlue;
            label7.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(188, 25);
            label7.Name = "label7";
            label7.Size = new Size(556, 36);
            label7.TabIndex = 3;
            label7.Text = "Pantalla principal Administrador";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Controls.Add(btnbase);
            panel4.Location = new Point(80, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 468);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // btnbase
            // 
            btnbase.BackColor = Color.Azure;
            btnbase.BackgroundImage = (Image)resources.GetObject("btnbase.BackgroundImage");
            btnbase.BackgroundImageLayout = ImageLayout.Stretch;
            btnbase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnbase.ForeColor = Color.White;
            btnbase.Location = new Point(25, 175);
            btnbase.Name = "btnbase";
            btnbase.Size = new Size(180, 56);
            btnbase.TabIndex = 9;
            btnbase.Text = "Base de datos";
            btnbase.UseVisualStyleBackColor = false;
            btnbase.Click += btnbase_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightBlue;
            panel5.Controls.Add(txtid);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btneditar);
            panel5.Controls.Add(btnbuscar);
            panel5.Controls.Add(txtvalidar);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtcorreo);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(btnguardar);
            panel5.Controls.Add(txtcontrasena);
            panel5.Controls.Add(txtusuario);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(313, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 468);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // txtid
            // 
            txtid.BackColor = Color.AliceBlue;
            txtid.Enabled = false;
            txtid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.Location = new Point(334, 171);
            txtid.Name = "txtid";
            txtid.Size = new Size(140, 29);
            txtid.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 175);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 16;
            label2.Text = "Id:";
            label2.Click += label2_Click_1;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.SkyBlue;
            btneditar.Enabled = false;
            btneditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.Location = new Point(372, 406);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(93, 38);
            btneditar.TabIndex = 6;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.SkyBlue;
            btnbuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.Location = new Point(489, 113);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(73, 38);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtvalidar
            // 
            txtvalidar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtvalidar.BackColor = Color.AliceBlue;
            txtvalidar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtvalidar.Location = new Point(334, 113);
            txtvalidar.Multiline = true;
            txtvalidar.Name = "txtvalidar";
            txtvalidar.Size = new Size(140, 34);
            txtvalidar.TabIndex = 1;
            txtvalidar.TextChanged += txtvalidar_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(102, 115);
            label9.Name = "label9";
            label9.Size = new Size(193, 25);
            label9.TabIndex = 14;
            label9.Text = "Digite su contraseña :";
            // 
            // txtcorreo
            // 
            txtcorreo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtcorreo.BackColor = Color.AliceBlue;
            txtcorreo.Enabled = false;
            txtcorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcorreo.Location = new Point(253, 345);
            txtcorreo.Margin = new Padding(1);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.RightToLeft = RightToLeft.Yes;
            txtcorreo.ShortcutsEnabled = false;
            txtcorreo.Size = new Size(221, 29);
            txtcorreo.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(104, 354);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 12;
            label8.Text = "Correo :";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.SkyBlue;
            btnguardar.Enabled = false;
            btnguardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnguardar.Location = new Point(221, 406);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(93, 38);
            btnguardar.TabIndex = 7;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtcontrasena
            // 
            txtcontrasena.BackColor = Color.AliceBlue;
            txtcontrasena.Enabled = false;
            txtcontrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontrasena.Location = new Point(334, 293);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(140, 29);
            txtcontrasena.TabIndex = 4;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.AliceBlue;
            txtusuario.Enabled = false;
            txtusuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(334, 231);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(140, 29);
            txtusuario.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(102, 297);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 5;
            label6.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(104, 235);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(102, 60);
            label3.Name = "label3";
            label3.Size = new Size(410, 25);
            label3.TabIndex = 2;
            label3.Text = " con la debida seguridad y respeto que merece.";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 23);
            label4.Name = "label4";
            label4.Size = new Size(497, 25);
            label4.TabIndex = 3;
            label4.Text = "Estimado administrador, recuerde manejar la informacion";
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1042, 740);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += Administrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Button btnbase;
        private Label label3;
        private Button button5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtcontrasena;
        private TextBox txtusuario;
        private Button btnguardar;
        private TextBox txtcorreo;
        private Label label8;
        private TextBox txtvalidar;
        private Label label9;
        private Button btnbuscar;
        private Button btneditar;
        private TextBox txtid;
        private Label label2;
    }
}