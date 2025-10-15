namespace Laboratorio122
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
            label4 = new Label();
            label5 = new Label();
            btnPromedio = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            txbNota1 = new TextBox();
            txbNota2 = new TextBox();
            txbNota3 = new TextBox();
            txbPromedio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Nota Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 155);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Nota #1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 196);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Nota #2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 234);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Nota #3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 353);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Nota Promedio:";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(237, 282);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(94, 29);
            btnPromedio.TabIndex = 5;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(337, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(437, 282);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txbNota1
            // 
            txbNota1.Location = new Point(282, 152);
            txbNota1.Name = "txbNota1";
            txbNota1.Size = new Size(125, 27);
            txbNota1.TabIndex = 8;
            // 
            // txbNota2
            // 
            txbNota2.Location = new Point(282, 193);
            txbNota2.Name = "txbNota2";
            txbNota2.Size = new Size(125, 27);
            txbNota2.TabIndex = 9;
            // 
            // txbNota3
            // 
            txbNota3.Location = new Point(282, 231);
            txbNota3.Name = "txbNota3";
            txbNota3.Size = new Size(125, 27);
            txbNota3.TabIndex = 10;
            // 
            // txbPromedio
            // 
            txbPromedio.Location = new Point(319, 350);
            txbPromedio.Name = "txbPromedio";
            txbPromedio.Size = new Size(125, 27);
            txbPromedio.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbPromedio);
            Controls.Add(txbNota3);
            Controls.Add(txbNota2);
            Controls.Add(txbNota1);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnSalir;
        private TextBox txbNota1;
        private TextBox txbNota2;
        private TextBox txbNota3;
        private TextBox txbPromedio;
    }
}
