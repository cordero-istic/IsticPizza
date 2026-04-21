namespace WinFormsPizza
{
    partial class FrmProducto
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
            TxtImageUrl = new TextBox();
            label5 = new Label();
            TxtUnidadMedida = new TextBox();
            label4 = new Label();
            TxtTipoProducto = new TextBox();
            label3 = new Label();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtDescripcion = new TextBox();
            label1 = new Label();
            TxtPrecio = new TextBox();
            label6 = new Label();
            BtnGuardar = new Button();
            BtnVolver = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtImageUrl);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtUnidadMedida);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtTipoProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtPrecio);
            groupBox1.Location = new Point(28, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 204);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Producto";
            // 
            // TxtImageUrl
            // 
            TxtImageUrl.Location = new Point(140, 136);
            TxtImageUrl.Name = "TxtImageUrl";
            TxtImageUrl.Size = new Size(243, 23);
            TxtImageUrl.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 140);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 18;
            label5.Text = "Imagen:";
            // 
            // TxtUnidadMedida
            // 
            TxtUnidadMedida.Location = new Point(140, 107);
            TxtUnidadMedida.Name = "TxtUnidadMedida";
            TxtUnidadMedida.Size = new Size(243, 23);
            TxtUnidadMedida.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 111);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 16;
            label4.Text = "Medida:";
            // 
            // TxtTipoProducto
            // 
            TxtTipoProducto.Location = new Point(140, 78);
            TxtTipoProducto.Name = "TxtTipoProducto";
            TxtTipoProducto.Size = new Size(243, 23);
            TxtTipoProducto.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 82);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(140, 49);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(243, 23);
            TxtNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(140, 20);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(116, 23);
            TxtDescripcion.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "Descripcion:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(140, 165);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(100, 23);
            TxtPrecio.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(276, 239);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(357, 239);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 12;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 170);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 20;
            label7.Text = "Precio:";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 276);
            Controls.Add(BtnVolver);
            Controls.Add(BtnGuardar);
            Controls.Add(groupBox1);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        // 🔹 Declaración de controles
        private GroupBox groupBox1;
        private TextBox TxtNombre, TxtDescripcion, TxtPrecio, TxtTipoProducto, TxtUnidadMedida, TxtImageUrl;
        private Label label1, label2, label3, label4, label5, label6;
        private Button BtnGuardar, BtnVolver;
        private Label label7;
    }
}