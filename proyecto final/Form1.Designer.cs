namespace proyecto_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btn_ocultar = new Button();
            btn_mostrar = new Button();
            btnolvido = new Button();
            btninicio = new Button();
            label4 = new Label();
            label2 = new Label();
            txtcontrasena = new TextBox();
            txtusuario = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 70);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(947, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(143, 29);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(btn_ocultar);
            panel2.Controls.Add(btn_mostrar);
            panel2.Controls.Add(btnolvido);
            panel2.Controls.Add(btninicio);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtcontrasena);
            panel2.Controls.Add(txtusuario);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(645, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 464);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btn_ocultar
            // 
            btn_ocultar.FlatAppearance.BorderSize = 0;
            btn_ocultar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ocultar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ocultar.FlatStyle = FlatStyle.Flat;
            btn_ocultar.Image = Properties.Resources.ojos_cruzados;
            btn_ocultar.Location = new Point(461, 252);
            btn_ocultar.Name = "btn_ocultar";
            btn_ocultar.Size = new Size(57, 34);
            btn_ocultar.TabIndex = 11;
            btn_ocultar.UseVisualStyleBackColor = true;
            btn_ocultar.Click += btn_ocultar_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.FlatAppearance.BorderSize = 0;
            btn_mostrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_mostrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_mostrar.FlatStyle = FlatStyle.Flat;
            btn_mostrar.Image = Properties.Resources.ojo;
            btn_mostrar.Location = new Point(461, 253);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(57, 32);
            btn_mostrar.TabIndex = 10;
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btnolvido
            // 
            btnolvido.BackColor = Color.LightBlue;
            btnolvido.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnolvido.Location = new Point(89, 385);
            btnolvido.Name = "btnolvido";
            btnolvido.Size = new Size(366, 39);
            btnolvido.TabIndex = 4;
            btnolvido.Text = "¿Olvidaste tu contraseña?";
            btnolvido.UseVisualStyleBackColor = false;
            btnolvido.Click += button2_Click;
            // 
            // btninicio
            // 
            btninicio.BackColor = Color.LightBlue;
            btninicio.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btninicio.Location = new Point(89, 326);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(366, 39);
            btninicio.TabIndex = 3;
            btninicio.Text = "Iniciar sesión";
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 248);
            label4.Name = "label4";
            label4.Size = new Size(151, 42);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 48);
            label2.Name = "label2";
            label2.Size = new Size(197, 42);
            label2.TabIndex = 7;
            label2.Text = "Inicio de sesión";
            label2.Click += label2_Click_1;
            // 
            // txtcontrasena
            // 
            txtcontrasena.BackColor = Color.AliceBlue;
            txtcontrasena.BorderStyle = BorderStyle.FixedSingle;
            txtcontrasena.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontrasena.Location = new Point(293, 248);
            txtcontrasena.Multiline = true;
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(162, 39);
            txtcontrasena.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Anchor = AnchorStyles.Left;
            txtusuario.BackColor = Color.AliceBlue;
            txtusuario.BorderStyle = BorderStyle.FixedSingle;
            txtusuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(293, 152);
            txtusuario.Margin = new Padding(1);
            txtusuario.Name = "txtusuario";
            txtusuario.ShortcutsEnabled = false;
            txtusuario.Size = new Size(162, 35);
            txtusuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 152);
            label3.Name = "label3";
            label3.Size = new Size(104, 42);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(56, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(503, 468);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(2, 662);
            panel3.Name = "panel3";
            panel3.Size = new Size(1226, 64);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(421, 12);
            label5.Name = "label5";
            label5.Size = new Size(410, 19);
            label5.TabIndex = 2;
            label5.Text = "© Laura Osorio Giraldo.Todos los derechos reservados.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(546, 41);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 3;
            label6.Text = "versión número 1.0";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1227, 730);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtcontrasena;
        private TextBox txtusuario;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btninicio;
        private Button btnolvido;
        private Button btn_ocultar;
        private Button btn_mostrar;
        private Panel panel3;
        private Label label6;
        private Label label5;
    }
}