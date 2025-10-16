namespace Laboratorio13
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
            btnConectar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.BackColor = SystemColors.Highlight;
            btnConectar.ForeColor = Color.WhiteSmoke;
            btnConectar.Location = new Point(342, 68);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(396, 144);
            btnConectar.TabIndex = 0;
            btnConectar.Text = " Conectar y desconectar de SQL Server";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(342, 258);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 455);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 816);
            Controls.Add(listBox1);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConectar;
        private ListBox listBox1;
    }
}
