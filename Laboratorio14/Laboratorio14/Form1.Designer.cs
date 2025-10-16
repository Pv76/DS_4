namespace Laboratorio14
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            tsbNuevo = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            label1 = new Label();
            tstId = new TextBox();
            tsbBuscar = new PictureBox();
            label2 = new Label();
            txtId = new TextBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            SuspendLayout();
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.Location = new Point(0, 0);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(64, 64);
            tsbNuevo.TabIndex = 0;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.Location = new Point(70, 0);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(64, 64);
            tsbGuardar.TabIndex = 1;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = Properties.Resources.cancelar;
            tsbCancelar.Location = new Point(140, 0);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(64, 64);
            tsbCancelar.TabIndex = 2;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = Properties.Resources.eliminar;
            tsbEliminar.Location = new Point(210, 0);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(64, 64);
            tsbEliminar.TabIndex = 3;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 41);
            label1.TabIndex = 4;
            label1.Text = "Buscar por ID:";
            label1.Click += label1_Click;
            // 
            // tstId
            // 
            tstId.Location = new Point(488, 6);
            tstId.Name = "tstId";
            tstId.Size = new Size(250, 47);
            tstId.TabIndex = 5;
            tstId.TextChanged += textBox1_TextChanged;
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.buscar;
            tsbBuscar.Location = new Point(744, 0);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(64, 64);
            tsbBuscar.TabIndex = 6;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 144);
            label2.Name = "label2";
            label2.Size = new Size(54, 41);
            label2.TabIndex = 7;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 141);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 47);
            txtId.TabIndex = 8;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 239);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 47);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 239);
            label3.Name = "label3";
            label3.Size = new Size(107, 41);
            label3.TabIndex = 9;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(592, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(720, 47);
            txtNombre.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 141);
            label4.Name = "label4";
            label4.Size = new Size(135, 41);
            label4.TabIndex = 11;
            label4.Text = "Nombre:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(554, 239);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(250, 47);
            txtStock.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 242);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 13;
            label5.Text = "Stock:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(72, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(228, 114);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 478);
            Controls.Add(btnSalir);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(tsbBuscar);
            Controls.Add(tstId);
            Controls.Add(label1);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbNuevo);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tsbNuevo;
        private PictureBox tsbGuardar;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
        private Label label1;
        private TextBox tstId;
        private PictureBox tsbBuscar;
        private Label label2;
        private TextBox txtId;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private Button btnSalir;
    }
}
