using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH2_G3
{
    public partial class Ingreso : Form
    {
        private List<alumno> Alumno = new List<alumno>();
        private int indice = -1;
        public Ingreso()
        {
            InitializeComponent();
        }
        //Actualizar la grid
        private void actualizargrip()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = Alumno;
        }
        ///Limpiar
        private void limpiar()
        {
            txtApellido.Clear();
            txtCarnet.Clear();
            txtMateria.Clear();
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNombre.Focus();
        }

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvAlumnos.SelectedRows[0];
            indice = dgvAlumnos.Rows.IndexOf(seleccion);
            alumno alum = Alumno[indice];
            txtApellido.Text = alum.Apellido;
            txtCarnet.Text = alum.Carnet;
            txtMateria.Text = alum.Materia;
            txtNombre.Text = alum.Nombre;
            txtNota1.Text = alum.Calificaciones[0].ToString();
            txtNota2.Text = alum.Calificaciones[1].ToString();
            txtNota3.Text = alum.Calificaciones[2].ToString();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            alumno alum = new alumno();
            alum.Apellido = txtApellido.Text;
            alum.Calificaciones[0] = float.Parse(txtNota1.Text);
            alum.Calificaciones[1] = float.Parse(txtNota2.Text);
            alum.Calificaciones[2] = float.Parse(txtNota3.Text);
            alum.Nombre = txtNombre.Text;
            alum.Carnet = txtCarnet.Text;
            alum.Materia = txtMateria.Text;
            if (indice > -1)
            {
                Alumno[indice] = alum;
                indice = -1;
            }
            else
            {
                Alumno.Add(alum);
            }
            actualizargrip();
            limpiar();
        }

        private void brnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte report = new Reporte();
            report.reporteAlum = Alumno;
            report.Show();
        }
    }
}
