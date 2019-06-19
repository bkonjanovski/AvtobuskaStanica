namespace AvtobuskaStanica
{
    partial class DodadiLinija
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.txtKrajna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtMapa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlobodni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почетна дестинација";
            // 
            // txtPocetna
            // 
            this.txtPocetna.Location = new System.Drawing.Point(289, 50);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.Size = new System.Drawing.Size(172, 22);
            this.txtPocetna.TabIndex = 1;
            // 
            // txtKrajna
            // 
            this.txtKrajna.Location = new System.Drawing.Point(289, 114);
            this.txtKrajna.Name = "txtKrajna";
            this.txtKrajna.Size = new System.Drawing.Size(172, 22);
            this.txtKrajna.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Крајна дестинација";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(46, 401);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(186, 45);
            this.btnDodadi.TabIndex = 4;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(286, 401);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(186, 45);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(289, 170);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(172, 22);
            this.txtCena.TabIndex = 7;
            // 
            // txtMapa
            // 
            this.txtMapa.Location = new System.Drawing.Point(289, 233);
            this.txtMapa.Name = "txtMapa";
            this.txtMapa.Size = new System.Drawing.Size(172, 22);
            this.txtMapa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мапа";
            // 
            // txtSlobodni
            // 
            this.txtSlobodni.Location = new System.Drawing.Point(286, 298);
            this.txtSlobodni.Name = "txtSlobodni";
            this.txtSlobodni.Size = new System.Drawing.Size(172, 22);
            this.txtSlobodni.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Слободни Места";
            // 
            // DodadiLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 504);
            this.Controls.Add(this.txtSlobodni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMapa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.txtKrajna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPocetna);
            this.Controls.Add(this.label1);
            this.Name = "DodadiLinija";
            this.Text = "DodadiLinija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPocetna;
        private System.Windows.Forms.TextBox txtKrajna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtMapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlobodni;
        private System.Windows.Forms.Label label5;
    }
}