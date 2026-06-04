namespace WinFormsPizza
{
    partial class FrmCambiarClave
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
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            groupBox1 = new GroupBox();
            TxtConfirmar = new TextBox();
            TxtNueva = new TextBox();
            TxtAnterior = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(320, 179);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(239, 179);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 4;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtConfirmar);
            groupBox1.Controls.Add(TxtNueva);
            groupBox1.Controls.Add(TxtAnterior);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // TxtConfirmar
            // 
            TxtConfirmar.Location = new Point(98, 87);
            TxtConfirmar.Name = "TxtConfirmar";
            TxtConfirmar.Size = new Size(228, 23);
            TxtConfirmar.TabIndex = 5;
            // 
            // TxtNueva
            // 
            TxtNueva.Location = new Point(98, 60);
            TxtNueva.Name = "TxtNueva";
            TxtNueva.Size = new Size(228, 23);
            TxtNueva.TabIndex = 4;
            // 
            // TxtAnterior
            // 
            TxtAnterior.Location = new Point(98, 31);
            TxtAnterior.Name = "TxtAnterior";
            TxtAnterior.Size = new Size(228, 23);
            TxtAnterior.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 90);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirmar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Nueva:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Anterior:";
            // 
            // FrmCambiarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 216);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(groupBox1);
            Name = "FrmCambiarClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de Clave";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnAceptar;
        private GroupBox groupBox1;
        private TextBox TxtConfirmar;
        private TextBox TxtNueva;
        private TextBox TxtAnterior;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}