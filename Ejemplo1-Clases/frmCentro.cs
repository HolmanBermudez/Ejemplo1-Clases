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
    public partial class frmCentro : Form
    {
        public frmCentro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCentro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(VerNom() && VerDirec() && VerTel() && VerEmail() )
            {
                DialogResult x= MessageBox.Show("Revice los datos antes de continuar", "Confirmar", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    {
                        Datos.Centros.Add(new Centro(textnombre.Text, textDireccion.Text, textTelefono.Text, textEmail.Text));
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
        private bool VerNom()
        {
            if(string.IsNullOrEmpty(textnombre.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerDirec()
        {
            if (string.IsNullOrEmpty(textDireccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerTel()
        {
            if (string.IsNullOrEmpty(textTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerEmail()
        {
            if (string.IsNullOrEmpty(textEmail.Text))
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

        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
