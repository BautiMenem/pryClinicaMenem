using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryClinicaMenem
{
    public partial class frmMedico : Form
    {
        private string NombreArchivoMed;
        public frmMedico(string nombreArchivoMed)
        {
            InitializeComponent();
            NombreArchivoMed = nombreArchivoMed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + "Especialidades.txt"))
            {
                cboEspecialidad.Items.Clear();
                return;
            }

            ClsArchivo Especialidad = new ClsArchivo();
            Especialidad.NombreArchivo = Application.StartupPath + "\\" + "Especialidades.txt";

            List<ClsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cboEspecialidad.Items.Clear();

            foreach (ClsEspecialidad especialidad in ListaEspecialidad)
            {
                cboEspecialidad.Items.Add(especialidad.Nombre);
            }
        }

        private ClsMedico CrearMedico()
        {
            ClsMedico NuevoMedico = new ClsMedico();

            NuevoMedico.Matricula = txtMatricula.Text;
            NuevoMedico.Nombre = txtNombre.Text;
            NuevoMedico.NumEspecialidad = cboEspecialidad.Text;

            return NuevoMedico;
        }

        public bool ValidarDatos()
        {
            bool resultado = false;

            if (txtMatricula.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (cboEspecialidad.Text != "")
                    {
                        ClsArchivo Matricula = new ClsArchivo();
                        Matricula.NombreArchivo = NombreArchivoMed;

                        if (Matricula.BuscarMatricula(txtMatricula.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ClsMedico NuevoMedico = CrearMedico();
                ClsArchivo Medico = new ClsArchivo();
                Medico.NombreArchivo = NombreArchivoMed;
                Medico.GrabarMedicos(NuevoMedico);

                txtMatricula.Text = "";
                txtNombre.Text = "";
                cboEspecialidad.SelectedIndex = -1;
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a ingrsar los Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
