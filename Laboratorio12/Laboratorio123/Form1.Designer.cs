namespace Laboratorio123
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
            btnSemiP = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            txbLadoA = new TextBox();
            txbLadoB = new TextBox();
            txbLadoC = new TextBox();
            txbSemiP = new TextBox();
            txbArea = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 71);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Lado A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Lado B:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 164);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Lado C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 275);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 3;
            label4.Text = "Calculo de SemiPerimetro: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 328);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Calculo de Area:";
            // 
            // btnSemiP
            // 
            btnSemiP.Location = new Point(111, 209);
            btnSemiP.Name = "btnSemiP";
            btnSemiP.Size = new Size(94, 29);
            btnSemiP.TabIndex = 5;
            btnSemiP.Text = "SemiPerimetro";
            btnSemiP.UseVisualStyleBackColor = true;
            btnSemiP.Click += btnSemiP_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(211, 209);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(94, 29);
            btnArea.TabIndex = 6;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(311, 209);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(411, 209);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txbLadoA
            // 
            txbLadoA.Location = new Point(180, 68);
            txbLadoA.Name = "txbLadoA";
            txbLadoA.Size = new Size(125, 27);
            txbLadoA.TabIndex = 9;
            // 
            // txbLadoB
            // 
            txbLadoB.Location = new Point(180, 112);
            txbLadoB.Name = "txbLadoB";
            txbLadoB.Size = new Size(125, 27);
            txbLadoB.TabIndex = 10;
            // 
            // txbLadoC
            // 
            txbLadoC.Location = new Point(180, 161);
            txbLadoC.Name = "txbLadoC";
            txbLadoC.Size = new Size(125, 27);
            txbLadoC.TabIndex = 11;
            // 
            // txbSemiP
            // 
            txbSemiP.Location = new Point(299, 272);
            txbSemiP.Name = "txbSemiP";
            txbSemiP.Size = new Size(125, 27);
            txbSemiP.TabIndex = 12;
            // 
            // txbArea
            // 
            txbArea.Location = new Point(226, 325);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(125, 27);
            txbArea.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbArea);
            Controls.Add(txbSemiP);
            Controls.Add(txbLadoC);
            Controls.Add(txbLadoB);
            Controls.Add(txbLadoA);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiP);
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
        private Button btnSemiP;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalir;
        private TextBox txbLadoA;
        private TextBox txbLadoB;
        private TextBox txbLadoC;
        private TextBox txbSemiP;
        private TextBox txbArea;
    }
}
