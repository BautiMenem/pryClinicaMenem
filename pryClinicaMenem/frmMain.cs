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
    public partial class frmMain : Form
    {
        private string NombreArchivoMed = "Medicos.txt";
        private string NombreArchivoEsp = "Especialidades.txt";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
            dgvInformacion.Rows.Clear();
            cboEspecialidad.SelectedIndex = -1;
        }

        private void btnEspecial_Click(object sender, EventArgs e)
        {
            frmEspecialida frm = new frmEspecialida(NombreArchivoEsp);
            frm.ShowDialog();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            frmMedico frm = new frmMedico(NombreArchivoMed);
            frm.ShowDialog();
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEspecialidad.Text = cboEspecialidad.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(NombreArchivoMed) || cboEspecialidad.Text == "")
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClsArchivo Medico = new ClsArchivo();
            Medico.NombreArchivo = NombreArchivoMed;
            List<ClsMedico> ListaMedicos = Medico.ListarMedicos();

            ClsArchivo Especialidad = new ClsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEsp;
            List<ClsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();

            dgvInformacion.Rows.Clear();

            bool control = false;
            foreach (ClsEspecialidad especialidad in ListaEspecialidad)
            {
                if (especialidad.Nombre == cboEspecialidad.Text)
                {
                    foreach (ClsMedico medico in ListaMedicos)
                    {
                        if (especialidad.Nombre == medico.NumEspecialidad)
                        {
                            dgvInformacion.Rows.Add(medico.Matricula, medico.Nombre);
                            control = true;
                        }
                    }
                }
            }

            if (control == false)
            {
                MessageBox.Show("No hay médicos registrados en esta especialidad.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Clear();
            cboEspecialidad.SelectedIndex = -1;
        }

        private void brnReiniciar_Click(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public void ListarEspecialidades()
        {
            if (!File.Exists(NombreArchivoEsp))
            {
                cboEspecialidad.Items.Clear();
                return;
            }

            ClsArchivo Especialidad = new ClsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEsp;
            List<ClsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cboEspecialidad.Items.Clear();

            foreach (ClsEspecialidad especialidad in ListaEspecialidad)
            {
                cboEspecialidad.Items.Add(especialidad.Nombre);
            }
        }
    }
}
