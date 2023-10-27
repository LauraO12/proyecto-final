namespace proyecto_final
{
    partial class baseD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseD));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            btnbuscar = new Button();
            btnagregar = new Button();
            btneditar = new Button();
            panel2 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            fechaexpedicion = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            tiposangre = new DataGridViewTextBoxColumn();
            arl = new DataGridViewTextBoxColumn();
            eps = new DataGridViewTextBoxColumn();
            afp = new DataGridViewTextBoxColumn();
            alergias = new DataGridViewTextBoxColumn();
            medicamentos = new DataGridViewTextBoxColumn();
            contactoe = new DataGridViewTextBoxColumn();
            telefonoCE = new DataGridViewTextBoxColumn();
            lugarind = new DataGridViewTextBoxColumn();
            fechavcfts1 = new DataGridViewTextBoxColumn();
            estadoCFTSl = new DataGridViewTextBoxColumn();
            notaCFTSl = new DataGridViewTextBoxColumn();
            fechavcftsll = new DataGridViewTextBoxColumn();
            estadoll = new DataGridViewTextBoxColumn();
            notall = new DataGridViewTextBoxColumn();
            campolll = new DataGridViewTextBoxColumn();
            analisis = new DataGridViewTextBoxColumn();
            estadoriesgo = new DataGridViewTextBoxColumn();
            notariesgo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            fechatsa = new DataGridViewTextBoxColumn();
            estadotsa = new DataGridViewTextBoxColumn();
            fecharee = new DataGridViewTextBoxColumn();
            estadoreetsa = new DataGridViewTextBoxColumn();
            fechavexamen = new DataGridViewTextBoxColumn();
            fechaauxilios = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            moduloAgregarToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 75);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1051, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 76);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(178, 34);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(137, 187, 241);
            panel4.Controls.Add(btnbuscar);
            panel4.Controls.Add(btnagregar);
            panel4.Controls.Add(btneditar);
            panel4.Location = new Point(12, 566);
            panel4.Name = "panel4";
            panel4.Size = new Size(1331, 91);
            panel4.TabIndex = 7;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Transparent;
            btnbuscar.BackgroundImage = (Image)resources.GetObject("btnbuscar.BackgroundImage");
            btnbuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnbuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.Location = new Point(1189, 27);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(109, 44);
            btnbuscar.TabIndex = 11;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Transparent;
            btnagregar.BackgroundImage = (Image)resources.GetObject("btnagregar.BackgroundImage");
            btnagregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnagregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(257, 23);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(196, 52);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "Agregar Usuario";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.Transparent;
            btneditar.BackgroundImage = (Image)resources.GetObject("btneditar.BackgroundImage");
            btneditar.BackgroundImageLayout = ImageLayout.Stretch;
            btneditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.ForeColor = SystemColors.ButtonHighlight;
            btneditar.Location = new Point(36, 22);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(196, 51);
            btneditar.TabIndex = 7;
            btneditar.Text = "Editar información";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(12, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 73);
            panel2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(544, 12);
            label7.Name = "label7";
            label7.Size = new Size(260, 58);
            label7.TabIndex = 11;
            label7.Text = "BASE DE DATOS";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, cedula, fechaexpedicion, celular, correo, tiposangre, arl, eps, afp, alergias, medicamentos, contactoe, telefonoCE, lugarind, fechavcfts1, estadoCFTSl, notaCFTSl, fechavcftsll, estadoll, notall, campolll, analisis, estadoriesgo, notariesgo, rol, fechatsa, estadotsa, fecharee, estadoreetsa, fechavexamen, fechaauxilios });
            dataGridView1.Location = new Point(12, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1331, 331);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // cedula
            // 
            cedula.HeaderText = "CC";
            cedula.Name = "cedula";
            // 
            // fechaexpedicion
            // 
            fechaexpedicion.HeaderText = "Fecha Expedicion";
            fechaexpedicion.Name = "fechaexpedicion";
            // 
            // celular
            // 
            celular.HeaderText = "Celular";
            celular.Name = "celular";
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            // 
            // tiposangre
            // 
            tiposangre.HeaderText = "Tipo Sangre";
            tiposangre.Name = "tiposangre";
            // 
            // arl
            // 
            arl.HeaderText = "ARL";
            arl.Name = "arl";
            // 
            // eps
            // 
            eps.HeaderText = "EPS";
            eps.Name = "eps";
            // 
            // afp
            // 
            afp.HeaderText = "AFP";
            afp.Name = "afp";
            // 
            // alergias
            // 
            alergias.HeaderText = "Alergias";
            alergias.Name = "alergias";
            // 
            // medicamentos
            // 
            medicamentos.HeaderText = "Medicamentos";
            medicamentos.Name = "medicamentos";
            // 
            // contactoe
            // 
            contactoe.HeaderText = "Contacto Emergencia";
            contactoe.Name = "contactoe";
            // 
            // telefonoCE
            // 
            telefonoCE.HeaderText = "Telefono C.E";
            telefonoCE.Name = "telefonoCE";
            // 
            // lugarind
            // 
            lugarind.HeaderText = "Lugar Induccion";
            lugarind.Name = "lugarind";
            // 
            // fechavcfts1
            // 
            fechavcfts1.HeaderText = "Fecha de vencimiento CFTS FASE l";
            fechavcfts1.Name = "fechavcfts1";
            // 
            // estadoCFTSl
            // 
            estadoCFTSl.HeaderText = "Estado";
            estadoCFTSl.Name = "estadoCFTSl";
            // 
            // notaCFTSl
            // 
            notaCFTSl.HeaderText = "Nota";
            notaCFTSl.Name = "notaCFTSl";
            // 
            // fechavcftsll
            // 
            fechavcftsll.HeaderText = "Fecha vencimiento CFTS fase ll";
            fechavcftsll.Name = "fechavcftsll";
            // 
            // estadoll
            // 
            estadoll.HeaderText = "Estado:";
            estadoll.Name = "estadoll";
            // 
            // notall
            // 
            notall.HeaderText = "Nota";
            notall.Name = "notall";
            // 
            // campolll
            // 
            campolll.HeaderText = "campo/sitio fase lll";
            campolll.Name = "campolll";
            // 
            // analisis
            // 
            analisis.HeaderText = "analisis de riesgo";
            analisis.Name = "analisis";
            // 
            // estadoriesgo
            // 
            estadoriesgo.HeaderText = "Estado:";
            estadoriesgo.Name = "estadoriesgo";
            // 
            // notariesgo
            // 
            notariesgo.HeaderText = "Nota";
            notariesgo.Name = "notariesgo";
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            // 
            // fechatsa
            // 
            fechatsa.HeaderText = "Fecha TSA a partir del 2012";
            fechatsa.Name = "fechatsa";
            // 
            // estadotsa
            // 
            estadotsa.HeaderText = "Estado";
            estadotsa.Name = "estadotsa";
            // 
            // fecharee
            // 
            fecharee.HeaderText = "Fecha reentrenamiento TSA";
            fecharee.Name = "fecharee";
            // 
            // estadoreetsa
            // 
            estadoreetsa.HeaderText = "Estado";
            estadoreetsa.Name = "estadoreetsa";
            // 
            // fechavexamen
            // 
            fechavexamen.HeaderText = "Fecha vencimiento Examen medico/alturas";
            fechavexamen.Name = "fechavexamen";
            // 
            // fechaauxilios
            // 
            fechaauxilios.HeaderText = "Fecha primeros auxilios";
            fechaauxilios.Name = "fechaauxilios";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { moduloAgregarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1358, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "Modulo Agregar";
            // 
            // moduloAgregarToolStripMenuItem
            // 
            moduloAgregarToolStripMenuItem.Name = "moduloAgregarToolStripMenuItem";
            moduloAgregarToolStripMenuItem.Size = new Size(104, 20);
            moduloAgregarToolStripMenuItem.Text = "Modulo agregar";
            moduloAgregarToolStripMenuItem.Click += moduloAgregarToolStripMenuItem_Click;
            // 
            // baseD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1358, 669);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "baseD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Base de Datos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Button btneditar;
        private Panel panel2;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnbuscar;
        private Button btnagregar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn fechaexpedicion;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn tiposangre;
        private DataGridViewTextBoxColumn arl;
        private DataGridViewTextBoxColumn eps;
        private DataGridViewTextBoxColumn afp;
        private DataGridViewTextBoxColumn alergias;
        private DataGridViewTextBoxColumn medicamentos;
        private DataGridViewTextBoxColumn contactoe;
        private DataGridViewTextBoxColumn telefonoCE;
        private DataGridViewTextBoxColumn lugarind;
        private DataGridViewTextBoxColumn fechavcfts1;
        private DataGridViewTextBoxColumn estadoCFTSl;
        private DataGridViewTextBoxColumn notaCFTSl;
        private DataGridViewTextBoxColumn fechavcftsll;
        private DataGridViewTextBoxColumn estadoll;
        private DataGridViewTextBoxColumn notall;
        private DataGridViewTextBoxColumn campolll;
        private DataGridViewTextBoxColumn analisis;
        private DataGridViewTextBoxColumn estadoriesgo;
        private DataGridViewTextBoxColumn notariesgo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn fechatsa;
        private DataGridViewTextBoxColumn estadotsa;
        private DataGridViewTextBoxColumn fecharee;
        private DataGridViewTextBoxColumn estadoreetsa;
        private DataGridViewTextBoxColumn fechavexamen;
        private DataGridViewTextBoxColumn fechaauxilios;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem moduloAgregarToolStripMenuItem;
    }
}