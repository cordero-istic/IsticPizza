namespace WinFormsPizza
{
    partial class FrmListaClientes
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
            dataGridClientes = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            BtnNuevo = new Button();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
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
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColApellido });
            dataGridClientes.Location = new Point(12, 120);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.Size = new Size(776, 284);
            dataGridClientes.TabIndex = 1;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "IdCliente";
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
            // ColApellido
            // 
            ColApellido.DataPropertyName = "Apellido";
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            ColApellido.Width = 200;
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
            Controls.Add(dataGridClientes);
            Controls.Add(groupBox1);
            Name = "FrmListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Clientes";
            Load += FrmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridClientes;
        private Button BtnNuevo;
        private Button BtnVolver;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
    }
}