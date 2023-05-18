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
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (VerInss() && VerSal())
            {
                DialogResult x = MessageBox.Show("Revice los datos antes de continuar", "Confirmar", MessageBoxButtons.YesNo);
            
                
                if (x == DialogResult.Yes)
                {
                    {
                        Datos.Profesores.Add(new Profesor(textInss.Text, double.Parse(textSalario.Text)));
                    }
                    DialogResult y = MessageBox.Show("Se han ingresado correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    DialogResult y = MessageBox.Show("Por favor no deje ningun campo vacio", "Confirmar", MessageBoxButtons.OK);
                }
            }
        }
        private bool VerInss()
        {
            if (string.IsNullOrEmpty(textInss.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerSal()
        {
            if (string.IsNullOrEmpty(textSalario.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult z = MessageBox.Show("¿Esta seguro de que quiere salir?", "Confimar", MessageBoxButtons.YesNo);
            if (z == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
