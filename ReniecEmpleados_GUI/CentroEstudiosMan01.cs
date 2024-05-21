using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReniecEmpleados_BL;

namespace ReniecEmpleados_GUI
{
    public partial class CentroEstudiosMan01 : Form
    {
        DataView dtv;
        CentroEstudiosBL objCentroEstudiosBL = new CentroEstudiosBL();
        public CentroEstudiosMan01()
        {
            InitializeComponent();
        }

        private void CentroEstudiosMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(string strFiltro)
        {
            dtv = new DataView(objCentroEstudiosBL.ListarCentroEstudios());
            dtv.RowFilter = "Des_Cestudio like '%" + strFiltro + "%'";
            dtgData.DataSource = dtv;
            lblRegistros.Text = dtgData.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
