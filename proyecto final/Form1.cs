using MySql.Data.MySqlClient;

namespace proyecto_final
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK);
            }
            else if (txtcontrasena.Text == " ")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MySqlConnection conexion = new MySqlConnection("server=localhost; database=seguimientohseq; Uid =root; Pwd=;");
                conexion.Open();
                string consulta = "select * from administrador where usuario ='" + txtusuario.Text + "'and contrasena= '" + txtcontrasena.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {

                    this.Hide();
                    Administrador administrador = new Administrador();
                    administrador.Show();

                }
                else
                    if (txtusuario.Text != consulta)
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK);
                    txtusuario.TabIndex = 0;
                }

                conexion.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recuperacion recu = new Recuperacion();
            recu.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chmostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (txtcontrasena.UseSystemPasswordChar)
            {
                txtcontrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtcontrasena.UseSystemPasswordChar = true;
            }

            btn_ocultar.Visible = true;
            btn_mostrar.Visible = false;
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            if (txtcontrasena.UseSystemPasswordChar)
            {
                txtcontrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtcontrasena.UseSystemPasswordChar = true;
            }
            btn_ocultar.Visible = false;
            btn_mostrar.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}