namespace WinFormsPizza
{
    partial class FrmCliente
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
            TxtCorreo = new TextBox();
            label5 = new Label();
            TxtTlf = new TextBox();
            label4 = new Label();
            TxtApellido = new TextBox();
            label3 = new Label();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtNroDoc = new TextBox();
            label1 = new Label();
            BtnGuardar = new Button();
            BtnVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtCorreo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtTlf);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtNroDoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 178);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(140, 136);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(243, 23);
            TxtCorreo.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 140);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 18;
            label5.Text = "Correo:";
            // 
            // TxtTlf
            // 
            TxtTlf.Location = new Point(140, 107);
            TxtTlf.Name = "TxtTlf";
            TxtTlf.Size = new Size(243, 23);
            TxtTlf.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 111);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "Teléfono:";
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(140, 78);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(243, 23);
            TxtApellido.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 82);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Apellido:";
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
            // TxtNroDoc
            // 
            TxtNroDoc.Location = new Point(140, 20);
            TxtNroDoc.Name = "TxtNroDoc";
            TxtNroDoc.Size = new Size(116, 23);
            TxtNroDoc.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 10;
            label1.Text = "Nro Documento:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(277, 201);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 11;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(358, 201);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 12;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 235);
            Controls.Add(BtnVolver);
            Controls.Add(BtnGuardar);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtCorreo;
        private Label label5;
        private TextBox TxtTlf;
        private Label label4;
        private TextBox TxtApellido;
        private Label label3;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtNroDoc;
        private Label label1;
        private Button BtnGuardar;
        private Button BtnVolver;
    }
}