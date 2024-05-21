namespace ReniecEmpleados_GUI
{
    partial class CentroEstudiosMan01
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
            label1 = new Label();
            txtFiltro = new TextBox();
            dtgContratos = new DataGridView();
            label2 = new Label();
            lblRegistros = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgContratos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(246, 26);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(357, 27);
            txtFiltro.TabIndex = 1;
            // 
            // dtgContratos
            // 
            dtgContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgContratos.Location = new Point(12, 78);
            dtgContratos.Name = "dtgContratos";
            dtgContratos.RowHeadersWidth = 51;
            dtgContratos.Size = new Size(1113, 460);
            dtgContratos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(954, 568);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1033, 560);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(92, 28);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(616, 609);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 44);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(725, 609);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 44);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(829, 609);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1004, 609);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 44);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // CentroEstudiosMan01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1137, 680);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgContratos);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "CentroEstudiosMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Centro de Estudios";
            ((System.ComponentModel.ISupportInitialize)dtgContratos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgContratos;
        private Label label2;
        private Label lblRegistros;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
    }
}