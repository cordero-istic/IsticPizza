namespace WinFormsPizza
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            BtnCancelar = new Button();
            BtnIngresar = new Button();
            groupBox1 = new GroupBox();
            TxtClave = new TextBox();
            label2 = new Label();
            TxtUsuario = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(497, 160);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 0;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(416, 160);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(75, 23);
            BtnIngresar.TabIndex = 3;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtClave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(236, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 116);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // TxtClave
            // 
            TxtClave.Location = new Point(94, 63);
            TxtClave.Name = "TxtClave";
            TxtClave.PasswordChar = '@';
            TxtClave.Size = new Size(216, 23);
            TxtClave.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(94, 34);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(216, 23);
            TxtUsuario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 212);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(BtnIngresar);
            Controls.Add(BtnCancelar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnIngresar;
        private GroupBox groupBox1;
        private TextBox TxtClave;
        private Label label2;
        private TextBox TxtUsuario;
        private Label label1;
        private PictureBox pictureBox1;
    }
}