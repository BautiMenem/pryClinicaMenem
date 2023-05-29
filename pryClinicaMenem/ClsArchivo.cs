using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryClinicaMenem
{
    internal class ClsArchivo
    {
        public string NombreArchivo { get; set; }

        public bool GrabarEspecialidad(ClsEspecialidad Especialidad)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);

                sw.WriteLine(Especialidad.Nombre + "," + Especialidad.Codigo);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool GrabarMedicos(ClsMedico Medico)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);

                sw.WriteLine(Medico.Matricula + "," + Medico.Nombre + "," + Medico.NumEspecialidad);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public List<ClsEspecialidad> ListarEspecialidad()
        {
            List<ClsEspecialidad> ListaEspecialidad = new List<ClsEspecialidad>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sw = new StreamReader(NombreArchivo);
                while (sw.EndOfStream == false)
                {
                    Linea = sw.ReadLine();
                    ClsEspecialidad NuevaEspecialidad = new ClsEspecialidad();
                    NuevaEspecialidad.Codigo = Linea.Split(',')[0];
                    NuevaEspecialidad.Nombre = Linea.Split(',')[1];
                    ListaEspecialidad.Add(NuevaEspecialidad);
                }
                sw.Close();
                sw.Dispose();
            }
            return ListaEspecialidad;
        }

        public List<ClsMedico> ListarMedicos()
        {
            List<ClsMedico> listMedico = new List<ClsMedico>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sw = new StreamReader(NombreArchivo);
                while (sw.EndOfStream == false)
                {
                    Linea = sw.ReadLine();
                    ClsMedico Medico = new ClsMedico();
                    Medico.Matricula = Linea.Split(',')[0];
                    Medico.Nombre = Linea.Split(',')[1];
                    Medico.NumEspecialidad = Linea.Split(',')[2];
                    listMedico.Add(Medico);
                }
                sw.Close();
                sw.Dispose();
            }
            return listMedico;
        }

        public bool BuscarNombreEspecialidad(string Nombre)
        {
            bool resultado = false;
            string Linea;
            string nombreLeido;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sw = new StreamReader(NombreArchivo);
                while (sw.EndOfStream == false)
                {
                    Linea = sw.ReadLine();
                    nombreLeido = Linea.Split(',')[0];
                    if (Nombre == nombreLeido)
                    {
                        resultado = true;
                        break;
                    }
                }
                sw.Close();
                sw.Dispose();
            }
            return resultado;
        }

        public bool BuscarNumeroEspecialidad(string Numero)
        {
            bool resultado = false;
            string Linea;
            string numLeido;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sw = new StreamReader(NombreArchivo);
                while (sw.EndOfStream == false)
                {
                    Linea = sw.ReadLine();
                    numLeido = Linea.Split(',')[1];
                    if (Numero == numLeido)
                    {
                        resultado = true;
                        break;
                    }
                }
                sw.Close();
                sw.Dispose();
            }
            return resultado;
        }

        public bool BuscarMatricula(string Matricula)
        {
            bool resultado = false;
            string Linea;
            string matLeida;

            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sw = new StreamReader(NombreArchivo);
                while (sw.EndOfStream == false)
                {
                    Linea = sw.ReadLine();
                    matLeida = Linea.Split(',')[0];
                    if (matLeida == Matricula)
                    {
                        resultado = true;
                        break;
                    }
                }
                sw.Close();
                sw.Dispose();
            }
            return resultado;
        }





    }

}
