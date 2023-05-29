using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClinicaMenem
{
    public partial class frmEspecialida : Form
    {
        private string NombreArchivoEsp;
        public frmEspecialida(string NombreArchivo)
        {
            InitializeComponent();
            NombreArchivoEsp = NombreArchivo;
        }

        private ClsEspecialidad CrearEspecialidad()
        {
            ClsEspecialidad NuevaEspecialidad = new ClsEspecialidad();

            NuevaEspecialidad.Nombre = txtIdent.Text;
            NuevaEspecialidad.Codigo = txtNombre.Text;

            return NuevaEspecialidad;
        }

        private void frmEspecialida_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ClsEspecialidad NuevaEspecialidad = CrearEspecialidad();
                ClsArchivo Especialidad = new ClsArchivo();
                Especialidad.NombreArchivo = NombreArchivoEsp;
                Especialidad.GrabarEspecialidad(NuevaEspecialidad);

                txtIdent.Text = "";
                txtNombre.Text = "";
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a intentarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtIdent.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    ClsArchivo Especialidad = new ClsArchivo();
                    Especialidad.NombreArchivo = NombreArchivoEsp;

                    if (Especialidad.BuscarNumeroEspecialidad(txtIdent.Text) == false)
                    {
                        if (Especialidad.BuscarNombreEspecialidad(txtNombre.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
