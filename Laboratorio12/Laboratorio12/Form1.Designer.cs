namespace Laboratorio12
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDistancia = new Label();
            txtbTiempo = new TextBox();
            txtbVelocidad = new TextBox();
            txtbDistancia = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 22);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Distancia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 71);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Tiempo(t):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 118);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Velocidad(v):";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(52, 224);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(92, 20);
            lblDistancia.TabIndex = 3;
            lblDistancia.Text = "Distancia(d):";
            // 
            // txtbTiempo
            // 
            txtbTiempo.Location = new Point(153, 68);
            txtbTiempo.Name = "txtbTiempo";
            txtbTiempo.Size = new Size(125, 27);
            txtbTiempo.TabIndex = 4;
            txtbTiempo.TextChanged += txtbTiempo_TextChanged;
            // 
            // txtbVelocidad
            // 
            txtbVelocidad.Location = new Point(153, 115);
            txtbVelocidad.Name = "txtbVelocidad";
            txtbVelocidad.Size = new Size(125, 27);
            txtbVelocidad.TabIndex = 5;
            txtbVelocidad.TextChanged += txtbVelocidad_TextChanged;
            // 
            // txtbDistancia
            // 
            txtbDistancia.Location = new Point(153, 221);
            txtbDistancia.Name = "txtbDistancia";
            txtbDistancia.ReadOnly = true;
            txtbDistancia.Size = new Size(125, 27);
            txtbDistancia.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(52, 162);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(153, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(253, 162);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtbDistancia);
            Controls.Add(txtbVelocidad);
            Controls.Add(txtbTiempo);
            Controls.Add(lblDistancia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDistancia;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        public TextBox txtbTiempo;
        public TextBox txtbVelocidad;
        public TextBox txtbDistancia;
    }
}
