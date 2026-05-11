namespace CeviriUygulamasi
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
            txtSonuc = new TextBox();
            txtGiris = new TextBox();
            cmbDil = new ComboBox();
            btnCevir = new Button();
            SuspendLayout();
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(306, 244);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(297, 25);
            txtSonuc.TabIndex = 0;
            // 
            // txtGiris
            // 
            txtGiris.Location = new Point(3, 244);
            txtGiris.Name = "txtGiris";
            txtGiris.Size = new Size(297, 25);
            txtGiris.TabIndex = 1;
            // 
            // cmbDil
            // 
            cmbDil.FormattingEnabled = true;
            cmbDil.Location = new Point(179, 202);
            cmbDil.Name = "cmbDil";
            cmbDil.Size = new Size(121, 25);
            cmbDil.TabIndex = 2;
            // 
            // btnCevir
            // 
            btnCevir.Location = new Point(528, 284);
            btnCevir.Name = "btnCevir";
            btnCevir.Size = new Size(75, 23);
            btnCevir.TabIndex = 3;
            btnCevir.Text = "button1";
            btnCevir.UseVisualStyleBackColor = true;
            btnCevir.Click += btnCevir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 510);
            Controls.Add(btnCevir);
            Controls.Add(cmbDil);
            Controls.Add(txtGiris);
            Controls.Add(txtSonuc);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "Hızlı Çeviri v1.0";
            Click += btnCevir_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSonuc;
        private TextBox txtGiris;
        private ComboBox cmbDil;
        private Button btnCevir;
    }
}
