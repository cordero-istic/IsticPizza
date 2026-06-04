namespace WinFormsPizza
{
    partial class FrmRegistrese
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
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtCorreo);
            groupBox1.Controls.Add(TxtApellido);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(98, 87);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(228, 23);
            TxtCorreo.TabIndex = 5;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(98, 60);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(228, 23);
            TxtApellido.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(98, 31);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(228, 23);
            TxtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 90);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(234, 175);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 1;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(315, 175);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 212);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(groupBox1);
            Name = "FrmRegistrese";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtCorreo;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Button BtnAceptar;
        private Button BtnCancelar;
    }
}