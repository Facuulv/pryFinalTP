using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinalTP
{
    public partial class CargaAlumnos : Form
    {
        public CargaAlumnos()
        {
            InitializeComponent();
        }

        private void CargaAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.Columns.Add("col0", "Alumno");
            dgvAlumnos.Columns.Add("col1", "1° Parcial IE");
            dgvAlumnos.Columns.Add("col2", "2° Parcial IEFI");
            dgvAlumnos.Columns.Add("col3", "Trabajo Practico");
            dgvAlumnos.Columns.Add("col4", "Promedio");

            Inhabilitados();
            ValoresInicio();
        }
        public void ValoresInicio()
        {
            txtAlumno.Text = string.Empty;
            numParcial1.Value = 0;
            numParcial2.Value = 0;
            numTp.Value = 0;

            numCargarFilas.Minimum = 5;
            numParcial1.Maximum = 10;
            numParcial2.Maximum = 10;
            numTp.Maximum = 10;

        }

        int filas = 0;
        int indice = 0;
        int desaprobado = 0;
        int[,] matriz;
        private void numCargarFilas_ValueChanged(object sender, EventArgs e)
        {
            filas = Convert.ToInt32(numCargarFilas.Value);
            matriz = new int[filas, 4];
        }

        private void btnFilas_Click(object sender, EventArgs e)
        {
            btnCargarAlumno.Enabled = true;
            txtAlumno.Enabled = true;
            numParcial1.Enabled = true;
            numParcial2.Enabled = true;
            numTp.Enabled = true;
            numCargarFilas.Enabled = false;
            btnFilas.Enabled = false;
        }

        private void btnCargarAlumno_Click(object sender, EventArgs e)
        {
            if (indice < filas)
            {
                if (txtAlumno.Text != "")
                {
                    string alumno = txtAlumno.Text;
                    int par1 = Convert.ToInt32(numParcial1.Value);
                    int par2 = Convert.ToInt32(numParcial2.Value);
                    int tp = Convert.ToInt32(numTp.Value);
                    int promedio = (par1 + par2 + tp) / 3;

                    dgvAlumnos.Rows.Add(alumno, par1, par2, tp, promedio);
                    matriz[indice, 0] = par1;
                    matriz[indice, 1] = par2;
                    matriz[indice, 2] = tp;
                    matriz[indice, 3] = promedio;
                    if (par1 < 4)
                    {
                        desaprobado++;
                    }
                    if (par2 < 4)
                    {
                        desaprobado++;
                    }
                    if (tp < 4)
                    {
                        desaprobado++;
                    }

                    ValoresInicio();
                    indice++;
                    lblCantFilas.Text = indice.ToString() + "/" + filas.ToString();

                    if (indice == filas)
                    {
                        MessageBox.Show("Carga Completada", "Atencion");
                        Inhabilitados();
                    }
                } else
                {
                    MessageBox.Show("Debe colocar nombre y apellido del alumno", "Error");
                }
            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            decimal prom_gral = 0;
            int cant_prom = 0;
            int aprobado = 0;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                int promo = 0;
                for (int c = 0; c < matriz.GetLength(1) - 1; c++)
                {
                    if (matriz[f, c] >= 4)
                    {
                        aprobado++;
                    } 
                    promo += matriz[f, c];
                }
                prom_gral += promo / 3;
                if (promo/3 >= 7)
                {
                    cant_prom++;
                }                
            }

            lblAprobados.Text = aprobado.ToString();
            lblDesaprobados.Text = desaprobado.ToString();
            lblPromo.Text = cant_prom.ToString();
            lblPromGral.Text = (prom_gral / filas).ToString("F1");
        }
        public void Inhabilitados()
        {
            btnCargarAlumno.Enabled = false;
            txtAlumno.Enabled = false;
            numParcial1.Enabled = false;
            numParcial2.Enabled = false;
            numTp.Enabled = false;            
        }
    }
}
