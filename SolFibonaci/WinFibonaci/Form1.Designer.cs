
namespace WinFibonaci
{
    partial class Form1
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
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.lblBrojElemenata = new System.Windows.Forms.Label();
            this.lstListaFib = new System.Windows.Forms.ListBox();
            this.btnIzlistaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(149, 60);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(105, 20);
            this.txtUnos.TabIndex = 0;
            // 
            // lblBrojElemenata
            // 
            this.lblBrojElemenata.AutoSize = true;
            this.lblBrojElemenata.Location = new System.Drawing.Point(34, 63);
            this.lblBrojElemenata.Name = "lblBrojElemenata";
            this.lblBrojElemenata.Size = new System.Drawing.Size(109, 13);
            this.lblBrojElemenata.TabIndex = 1;
            this.lblBrojElemenata.Text = "Unesi broj elemenata:";
            // 
            // lstListaFib
            // 
            this.lstListaFib.FormattingEnabled = true;
            this.lstListaFib.Location = new System.Drawing.Point(336, 60);
            this.lstListaFib.Name = "lstListaFib";
            this.lstListaFib.Size = new System.Drawing.Size(404, 355);
            this.lstListaFib.TabIndex = 2;
            // 
            // btnIzlistaj
            // 
            this.btnIzlistaj.Location = new System.Drawing.Point(77, 107);
            this.btnIzlistaj.Name = "btnIzlistaj";
            this.btnIzlistaj.Size = new System.Drawing.Size(163, 53);
            this.btnIzlistaj.TabIndex = 3;
            this.btnIzlistaj.Text = "Generisi Fib. niz";
            this.btnIzlistaj.UseVisualStyleBackColor = true;
            this.btnIzlistaj.Click += new System.EventHandler(this.btnIzlistaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzlistaj);
            this.Controls.Add(this.lstListaFib);
            this.Controls.Add(this.lblBrojElemenata);
            this.Controls.Add(this.txtUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.Label lblBrojElemenata;
        private System.Windows.Forms.ListBox lstListaFib;
        private System.Windows.Forms.Button btnIzlistaj;
    }
}

