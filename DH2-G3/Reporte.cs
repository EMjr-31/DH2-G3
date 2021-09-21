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
    public partial class Reporte : Form
    {
        public List<alumno> reporteAlum = new List<alumno>();
        public Reporte()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            /*dataGridView1.DataSource = reporteAlum;*/
            /////Ingresando columnas programticamente
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Carnet";
            columna2.HeaderText = "Nombre";
            columna3.HeaderText = "Apellido";
            columna4.HeaderText = "Materia";
            columna5.HeaderText = "Promedio";
            dataGridView1.Columns.Add(columna1);
            dataGridView1.Columns.Add(columna2);
            dataGridView1.Columns.Add(columna3);
            dataGridView1.Columns.Add(columna4);
            dataGridView1.Columns.Add(columna5);

            int tam_vector = reporteAlum.Count;
            for (int i = 0; i < tam_vector; i++)
            {
                float acumulacion=0,promedio;
                acumulacion = reporteAlum[i].Calificaciones[0]+ reporteAlum[i].Calificaciones[1]+ reporteAlum[i].Calificaciones[2];
                promedio = acumulacion / 3;
                dataGridView1.Rows.Add(reporteAlum[i].Carnet, reporteAlum[i].Nombre, reporteAlum[i].Apellido, reporteAlum[i].Materia,promedio);
            }
            
        }
    }
}
