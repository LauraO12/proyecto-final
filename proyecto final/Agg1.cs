using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Agg1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=seguimientohseq; Uid =root; Pwd=;");
        public Agg1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void aggVacuna_Click(object sender, EventArgs e)
        {
            if (txtarl.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {

                conexion.Open();
                string nombre_Arl = txtarl.Text;
                string cadena = "insert into arl(nombre_ARL) values ('" + nombre_Arl + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("ARL registrada correctamente");
                txtarl.Text = "";

                conexion.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseD based = new baseD();
            based.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtafp.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();

                string Nombre = txtafp.Text;
                string cadena = "insert into afp(Nombre) values ('" + Nombre + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("AFP registrada correctamente");
                txtafp.Text = "";

                conexion.Close();
            }
        }

        private void txteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagg1_Click(object sender, EventArgs e)
        {
            if (txteps.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string nombre_Eps = txteps.Text;
                string cadena = "insert into eps(nombre_Eps) values ('" + nombre_Eps + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Eps registrada correctamente");
                txteps.Text = "";

                conexion.Close();
            }
        }

        private void btnagg2_Click(object sender, EventArgs e)
        {
            if (txtvacuna.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string nombrevacuna = txtvacuna.Text;
                string cadena = "insert into vacunas(Nombre_Vacuna) values ('" + nombrevacuna + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("vacuna registrada correctamente");
                txtvacuna.Text = "";

                conexion.Close();
            }
        }

        private void aggCampo_Click(object sender, EventArgs e)
        {
            if (txtcampo.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string nombreCampo = txtcampo.Text;
                string cadena = "insert into campo(nombre_Campo) values ('" + nombreCampo + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("campo registrado correctamente");
                txtcampo.Text = "";

                conexion.Close();
            }
        }

        private void aggCursos_Click(object sender, EventArgs e)
        {
            if (txtcurso.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string Nombre_Curso = txtcurso.Text;
                string cadena = "insert into curso( Nombre_Curso) values ('" + Nombre_Curso + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Curso registrado correctamente");
                txtcurso.Text = "";
            }
        }

        private void AggLugar_Click(object sender, EventArgs e)
        {
            if (txtlugar.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string nombre_lugar = txtlugar.Text;
                string cadena = "insert into lugar( Nombre_Lugar) values ('" + nombre_lugar + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Lugar registrado correctamente");
                txtlugar.Text = "";
            }
        }

        private void campo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fabricante_Click(object sender, EventArgs e)
        {
        }

        private void agg5_Click(object sender, EventArgs e)
        {
            if (txtfabricante.Text == "")
            {

                MessageBox.Show("Campo de texto vacio");
            }
            else
            {
                conexion.Open();
                string NombreFabricante = txtlugar.Text;
                string cadena = "insert into fabricante(NombreFabricante) values ('" + NombreFabricante + "')";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Nombre del fabricante registrado correctamente");
                txtfabricante.Text = "";
            }
        }
    }
}
