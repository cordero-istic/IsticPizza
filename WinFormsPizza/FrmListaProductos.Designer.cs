namespace WinFormsPizza
{
    partial class FrmListaProductos
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
            groupBox1 = new GroupBox();
            dataGridProductos = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            BtnNuevo = new Button();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColDescripcion });
            dataGridProductos.Location = new Point(12, 120);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.Size = new Size(776, 284);
            dataGridProductos.TabIndex = 1;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "IdProducto";
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 200;
            // 
            // ColDescripcion
            // 
            ColDescripcion.DataPropertyName = "Descripcion";
            ColDescripcion.HeaderText = "Descripción";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            ColDescripcion.Width = 200;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(632, 413);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 23);
            BtnNuevo.TabIndex = 2;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(713, 413);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 3;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FrmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            ControlBox = false;
            Controls.Add(BtnVolver);
            Controls.Add(BtnNuevo);
            Controls.Add(dataGridProductos);
            Controls.Add(groupBox1);
            Name = "FrmListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridProductos;
        private Button BtnNuevo;
        private Button BtnVolver;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColDescripcion;
    }
}