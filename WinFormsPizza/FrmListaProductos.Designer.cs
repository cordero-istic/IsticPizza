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
            TxtBuscaMarca = new TextBox();
            label2 = new Label();
            TxtBuscaTipo = new TextBox();
            BtnBuscar = new Button();
            label1 = new Label();
            dataGridProductos = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            BtnNuevo = new Button();
            BtnVolver = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtBuscaMarca);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtBuscaTipo);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // TxtBuscaMarca
            // 
            TxtBuscaMarca.Location = new Point(66, 56);
            TxtBuscaMarca.Name = "TxtBuscaMarca";
            TxtBuscaMarca.Size = new Size(240, 23);
            TxtBuscaMarca.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Marca:";
            // 
            // TxtBuscaTipo
            // 
            TxtBuscaTipo.Location = new Point(66, 26);
            TxtBuscaTipo.Name = "TxtBuscaTipo";
            TxtBuscaTipo.Size = new Size(240, 23);
            TxtBuscaTipo.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(620, 38);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(130, 36);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColTipo, ColPrecio, ColDescripcion });
            dataGridProductos.Location = new Point(12, 120);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProductos.Size = new Size(776, 284);
            dataGridProductos.TabIndex = 1;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "ProductoId";
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
            // ColTipo
            // 
            ColTipo.DataPropertyName = "TipoProducto";
            ColTipo.HeaderText = "Tipo";
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.DataPropertyName = "Precio";
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
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
            BtnNuevo.Location = new Point(470, 413);
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
            // BtnEditar
            // 
            BtnEditar.Location = new Point(551, 413);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 4;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(632, 413);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            ControlBox = false;
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnVolver);
            Controls.Add(BtnNuevo);
            Controls.Add(dataGridProductos);
            Controls.Add(groupBox1);
            Name = "FrmListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Productos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridProductos;
        private Button BtnNuevo;
        private Button BtnVolver;
        private Button BtnEditar;
        private Button BtnEliminar;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColDescripcion;
        private TextBox TxtBuscaTipo;
        private Button BtnBuscar;
        private Label label1;
        private TextBox TxtBuscaMarca;
        private Label label2;
    }
}