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
    public partial class baseD : Form
    {
        public baseD()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agg1 ag1 = new Agg1();
            ag1.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moduloAgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agg1 Agg = new Agg1();
            Agg.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar edit = new Editar();
            edit.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario crear = new CrearUsuario();
            crear.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar edit = new Editar();
            edit.Show();
        }
    }
}
