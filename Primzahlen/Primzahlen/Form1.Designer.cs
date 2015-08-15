namespace Primzahlen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_errechnen = new System.Windows.Forms.Button();
            this.numUD_maximum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_maximum)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_errechnen
            // 
            this.btn_errechnen.Location = new System.Drawing.Point(26, 51);
            this.btn_errechnen.Name = "btn_errechnen";
            this.btn_errechnen.Size = new System.Drawing.Size(75, 23);
            this.btn_errechnen.TabIndex = 0;
            this.btn_errechnen.Text = "Rechnen starten";
            this.btn_errechnen.UseVisualStyleBackColor = true;
            this.btn_errechnen.Click += new System.EventHandler(this.btn_errechnen_Click);
            // 
            // numUD_maximum
            // 
            this.numUD_maximum.Location = new System.Drawing.Point(26, 25);
            this.numUD_maximum.Name = "numUD_maximum";
            this.numUD_maximum.Size = new System.Drawing.Size(120, 20);
            this.numUD_maximum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numUD_maximum);
            this.Controls.Add(this.btn_errechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_maximum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_errechnen;
        private System.Windows.Forms.NumericUpDown numUD_maximum;


    }
}

