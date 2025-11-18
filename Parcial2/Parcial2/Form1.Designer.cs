namespace Parcial2
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
            txbHex = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnH_D = new Button();
            txbDecimal1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txbDecimal2 = new TextBox();
            btnO_D = new Button();
            label5 = new Label();
            label6 = new Label();
            txbOctal = new TextBox();
            btnReset1 = new Button();
            btnReset2 = new Button();
            btnHistorial = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txbHex
            // 
            txbHex.Location = new Point(143, 136);
            txbHex.Name = "txbHex";
            txbHex.Size = new Size(250, 47);
            txbHex.TabIndex = 1;
            txbHex.TextChanged += txbHex_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 46);
            label2.Name = "label2";
            label2.Size = new Size(245, 41);
            label2.TabIndex = 2;
            label2.Text = "Hex <-> Decimal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 136);
            label1.Name = "label1";
            label1.Size = new Size(76, 41);
            label1.TabIndex = 3;
            label1.Text = "Hex:";
            // 
            // btnH_D
            // 
            btnH_D.Location = new Point(399, 127);
            btnH_D.Name = "btnH_D";
            btnH_D.Size = new Size(188, 58);
            btnH_D.TabIndex = 4;
            btnH_D.Text = "<->";
            btnH_D.UseVisualStyleBackColor = true;
            btnH_D.Click += btnH_D_Click;
            // 
            // txbDecimal1
            // 
            txbDecimal1.Location = new Point(593, 136);
            txbDecimal1.Name = "txbDecimal1";
            txbDecimal1.Size = new Size(250, 47);
            txbDecimal1.TabIndex = 5;
            txbDecimal1.TextChanged += txbDecimal1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(849, 136);
            label3.Name = "label3";
            label3.Size = new Size(131, 41);
            label3.TabIndex = 6;
            label3.Text = ":Decimal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(848, 377);
            label4.Name = "label4";
            label4.Size = new Size(131, 41);
            label4.TabIndex = 12;
            label4.Text = ":Decimal";
            // 
            // txbDecimal2
            // 
            txbDecimal2.Location = new Point(592, 377);
            txbDecimal2.Name = "txbDecimal2";
            txbDecimal2.Size = new Size(250, 47);
            txbDecimal2.TabIndex = 11;
            txbDecimal2.TextChanged += txbDecimal2_TextChanged;
            // 
            // btnO_D
            // 
            btnO_D.Location = new Point(398, 368);
            btnO_D.Name = "btnO_D";
            btnO_D.Size = new Size(188, 58);
            btnO_D.TabIndex = 10;
            btnO_D.Text = "<->";
            btnO_D.UseVisualStyleBackColor = true;
            btnO_D.Click += btnO_D_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 377);
            label5.Name = "label5";
            label5.Size = new Size(94, 41);
            label5.TabIndex = 9;
            label5.Text = "Octal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 287);
            label6.Name = "label6";
            label6.Size = new Size(263, 41);
            label6.TabIndex = 8;
            label6.Text = "Octal <-> Decimal";
            // 
            // txbOctal
            // 
            txbOctal.Location = new Point(142, 377);
            txbOctal.Name = "txbOctal";
            txbOctal.Size = new Size(250, 47);
            txbOctal.TabIndex = 7;
            txbOctal.TextChanged += txbOctal_TextChanged;
            // 
            // btnReset1
            // 
            btnReset1.Location = new Point(398, 191);
            btnReset1.Name = "btnReset1";
            btnReset1.Size = new Size(188, 58);
            btnReset1.TabIndex = 13;
            btnReset1.Text = "Reset";
            btnReset1.UseVisualStyleBackColor = true;
            btnReset1.Click += btnReset1_Click;
            // 
            // btnReset2
            // 
            btnReset2.Location = new Point(398, 432);
            btnReset2.Name = "btnReset2";
            btnReset2.Size = new Size(188, 58);
            btnReset2.TabIndex = 14;
            btnReset2.Text = "Reset";
            btnReset2.UseVisualStyleBackColor = true;
            btnReset2.Click += btnReset2_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(399, 517);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(188, 58);
            btnHistorial.TabIndex = 15;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(12, 597);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1014, 414);
            listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 1026);
            Controls.Add(listBox1);
            Controls.Add(btnHistorial);
            Controls.Add(btnReset2);
            Controls.Add(btnReset1);
            Controls.Add(label4);
            Controls.Add(txbDecimal2);
            Controls.Add(btnO_D);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txbOctal);
            Controls.Add(label3);
            Controls.Add(txbDecimal1);
            Controls.Add(btnH_D);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txbHex);
            Name = "Form1";
            Text = "Conversor Numérico";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbHex;
        private Label label2;
        private Label label1;
        private Button btnH_D;
        private TextBox txbDecimal1;
        private Label label3;
        private Label label4;
        private TextBox txbDecimal2;
        private Button btnO_D;
        private Label label5;
        private Label label6;
        private TextBox txbOctal;
        private Button btnReset1;
        private Button btnReset2;
        private Button btnHistorial;
        private ListBox listBox1;
    }
}
