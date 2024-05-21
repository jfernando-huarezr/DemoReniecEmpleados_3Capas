using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReniecEmpleados_GUI
{
    public partial class MDIPrincipal : Form
    {
        TimeSpan horaEntrada = new TimeSpan();
        Computer miEquipo = new Computer();
        String miRed;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //Mostramos datos del equipo
            miRed = (miEquipo.Network.IsAvailable == true) ? "Equipo con conexion a red disponible" : "Equipo sin conexion a red disponible";
            lblEquipo.Text = $"Equipo: {miEquipo.Name}. {miRed}";

            //Registramos la hora de inicio de ejecucion
            horaEntrada = DateTime.Now.TimeOfDay;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostramos fecha y hora del sistema en el texto del MDI
            this.Text = "Reniec Empleados " + DateTime.Now.ToString();

            //Mostramos el tiempo segundo a segundo de iniciada la sesion
            lblSesion.Text = $"Tiempo: {DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8)}";
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta = MessageBox.Show("¿Seguro de salir de Reniec Empleados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //evaluamos respuesta
            if (vrpta == DialogResult.No)
            {
                //Si respondio que no, se cancela el cierre del formulario
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<EmpleadoMan01>(); ;
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<ContratoMan01>();
        }

        private void centroDeEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CentroEstudiosMan01>();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            // verificar si el formulario esta abierto
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is T)
                {
                    // Trae el formulario al frente
                    frm.BringToFront();
                    return;
                }
            }

            // si no existe, crea un nuevo formulario
            T newForm = new T
            {
                MdiParent = this
            };

            newForm.Show();
        }
    }
}
