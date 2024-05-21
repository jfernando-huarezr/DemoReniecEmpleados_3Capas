
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ReniecEmpleados_BL;

namespace ReniecEmpleados_GUI
{
    public partial class EmpleadoMan01 : Form
    {
        // Instancias
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;

        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            //  Invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los productos por defecto al 
            //momento de cargar el formulario

            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = "Nom_emp like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               /* // Codifique
                ProductoMan02 objMan02 = new ProductoMan02();
                objMan02.ShowDialog();

                //Refrescar el dtgDatos...
                CargarDatos(txtFiltro.Text.Trim());*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        
    }
}
