namespace ReniecEmpleados_GUI
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            contratosToolStripMenuItem = new ToolStripMenuItem();
            centroDeEstudiosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1102, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, contratosToolStripMenuItem, centroDeEstudiosToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(124, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(216, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // contratosToolStripMenuItem
            // 
            contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            contratosToolStripMenuItem.Size = new Size(216, 26);
            contratosToolStripMenuItem.Text = "Contratos";
            contratosToolStripMenuItem.Click += contratosToolStripMenuItem_Click;
            // 
            // centroDeEstudiosToolStripMenuItem
            // 
            centroDeEstudiosToolStripMenuItem.Name = "centroDeEstudiosToolStripMenuItem";
            centroDeEstudiosToolStripMenuItem.Size = new Size(216, 26);
            centroDeEstudiosToolStripMenuItem.Text = "Centro de Estudios";
            centroDeEstudiosToolStripMenuItem.Click += centroDeEstudiosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblSesion });
            statusStrip1.Location = new Point(0, 692);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1102, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonFace;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(59, 20);
            lblEquipo.Text = "Equipo:";
            // 
            // lblSesion
            // 
            lblSesion.BackColor = SystemColors.Info;
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(137, 20);
            lblSesion.Text = "Tiempo conectado:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 718);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reniec Empleados";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem contratosToolStripMenuItem;
        private ToolStripMenuItem centroDeEstudiosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblSesion;
    }
}