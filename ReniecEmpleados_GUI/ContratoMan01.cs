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
    public partial class ContratoMan01 : Form
    {
        ContratoBL objContratoBL = new ContratoBL();
        DataView dtv;
        public ContratoMan01()
        {
            InitializeComponent();
        }

        private void ContratoMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(string strFiltro)
        {
            dtv = new DataView(objContratoBL.ListarContrato());
            dtv.RowFilter = "Nom_emp like '%" + strFiltro + "%'";
            dtgContratos.DataSource = dtv;
            lblRegistros.Text = dtgContratos.Rows.Count.ToString();
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
