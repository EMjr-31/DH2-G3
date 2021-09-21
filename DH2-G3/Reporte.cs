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
            dataGridView1.DataSource = reporteAlum;
        }
    }
}
