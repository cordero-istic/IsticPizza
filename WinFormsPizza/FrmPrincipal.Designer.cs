namespace WinFormsPizza
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            button1 = new Button();
            BtnClientes = new Button();
            pictureBox1 = new PictureBox();
            BtnProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(72, 55);
            button1.Name = "button1";
            button1.Size = new Size(224, 72);
            button1.TabIndex = 0;
            button1.Text = "Tomar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            BtnClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClientes.Location = new Point(480, 55);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(224, 72);
            BtnClientes.TabIndex = 1;
            BtnClientes.Text = "Clientes";
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BtnProductos
            // 
            BtnProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProductos.Location = new Point(72, 386);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(224, 72);
            BtnProductos.TabIndex = 3;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = true;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(BtnProductos);
            Controls.Add(pictureBox1);
            Controls.Add(BtnClientes);
            Controls.Add(button1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ISTIC Pizza - Versión 0.1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button BtnClientes;
        private PictureBox pictureBox1;
        private Button BtnProductos;
    }
}
