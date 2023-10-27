using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final
{


    public partial class Administrador : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=seguimientohseq; Uid =root; Pwd=;");
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario Cusu = new CrearUsuario();
            Cusu.Show();
        }

        private void btnbase_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string usuario = txtusuario.Text;
            string contrasena = txtcontrasena.Text;
            string correo = txtcorreo.Text;
            string id = txtid.Text;

            string cadena = "update administrador SET usuario = @usuario, contrasena = @contrasena, Correo = @correo Where id_Administrador = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@id", id);

            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
            {
                txtid.Text = "";
                txtusuario.Text = "";
                txtcontrasena.Text = "";
                txtcorreo.Text = "";

                MessageBox.Show("Se editaron los datos correctamente");
            }
            else
            {
                MessageBox.Show("No se pudieron eliminar los datos");
            }
            btnguardar.Enabled = false;
            txtvalidar.Enabled = true;
            btnbuscar.Enabled = true;
            conexion.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string contra = txtvalidar.Text;
            string cadena = "select * from administrador where contrasena = @contra";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@contra", contra);
            MySqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                txtcorreo.Text = "";
                txtid.AppendText(registros["id_Administrador"].ToString());
                txtusuario.AppendText(registros["usuario"].ToString());
                txtcontrasena.AppendText(registros["contrasena"].ToString());
                txtcorreo.Text = registros["correo"].ToString();
                btneditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontro la información del administrador");
            }
            conexion.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
            txtcontrasena.Enabled = true;
            txtcorreo.Enabled = true;
            txtusuario.Enabled = true;
            txtvalidar.Enabled = false;
            txtid.Enabled = false;
            btnbuscar.Enabled = false;
            btneditar.Enabled = false;

        }

        private void txtvalidar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
