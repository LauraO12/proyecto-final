namespace proyecto_final
{
    partial class Recuperacion
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtcorreo = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtcorreo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 368);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 45);
            label1.Name = "label1";
            label1.Size = new Size(515, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a recuperación de contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 93);
            label2.Name = "label2";
            label2.Size = new Size(607, 25);
            label2.TabIndex = 1;
            label2.Text = "Digite el correo de recuperación, si este coincide con la base de datos, ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 130);
            label3.Name = "label3";
            label3.Size = new Size(435, 25);
            label3.TabIndex = 2;
            label3.Text = "será enviado un mensaje con la nueva contraseña.";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(222, 210);
            txtcorreo.Multiline = true;
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(231, 33);
            txtcorreo.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(275, 283);
            button1.Name = "button1";
            button1.Size = new Size(126, 38);
            button1.TabIndex = 4;
            button1.Text = "Recuperar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Recuperacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(738, 409);
            Controls.Add(panel1);
            Name = "Recuperacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox txtcorreo;
        private Label label3;
        private Label label2;
    }
}