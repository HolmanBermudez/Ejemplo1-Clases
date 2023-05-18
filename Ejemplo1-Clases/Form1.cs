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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentro Centro = new frmCentro(); 
            Centro.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProfesor Profesor = new frmProfesor();
            Profesor.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmestudiante Estudiante = new frmestudiante();
            Estudiante.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            Personal.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCentro ListaC = new frmListaCentro();
            ListaC.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestudiante Lisest = new frmestudiante();
            Lisest.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProfesor ListPro = new frmProfesor();
            ListPro.ShowDialog();   
        }

        private void listaDeTranbajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonal LisPerso = new frmPersonal();
            LisPerso.ShowDialog();
        }
    }
}
