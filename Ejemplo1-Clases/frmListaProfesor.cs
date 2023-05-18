using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class frmListaProfesor : Form
    {
        public frmListaProfesor()
        {
            InitializeComponent();
        }

        private void frmListaProfesor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Profesores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
