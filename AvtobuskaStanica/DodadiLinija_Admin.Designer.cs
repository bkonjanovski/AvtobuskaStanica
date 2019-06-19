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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.txtKrajna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMapa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlobodni = new System.Windows.Forms.NumericUpDown();
            this.txtCena = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSlobodni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почетна дестинација:";
            // 
            // txtPocetna
            // 
            this.txtPocetna.Location = new System.Drawing.Point(197, 40);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.Size = new System.Drawing.Size(172, 22);
            this.txtPocetna.TabIndex = 1;
            this.txtPocetna.Validating += new System.ComponentModel.CancelEventHandler(this.txtPocetna_Validating);
            // 
            // txtKrajna
            // 
            this.txtKrajna.Location = new System.Drawing.Point(197, 92);
            this.txtKrajna.Name = "txtKrajna";
            this.txtKrajna.Size = new System.Drawing.Size(172, 22);
            this.txtKrajna.TabIndex = 3;
            this.txtKrajna.Validating += new System.ComponentModel.CancelEventHandler(this.txtKrajna_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Крајна дестинација:";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(112, 317);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(100, 34);
            this.btnDodadi.TabIndex = 4;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.CausesValidation = false;
            this.btnOtkazi.Location = new System.Drawing.Point(269, 317);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 34);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена:";
            // 
            // txtMapa
            // 
            this.txtMapa.Location = new System.Drawing.Point(197, 198);
            this.txtMapa.Name = "txtMapa";
            this.txtMapa.Size = new System.Drawing.Size(172, 22);
            this.txtMapa.TabIndex = 9;
            this.txtMapa.Enter += new System.EventHandler(this.txtMapa_Enter);
            this.txtMapa.Validating += new System.ComponentModel.CancelEventHandler(this.txtMapa_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мапа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Слободни Места:";
            // 
            // txtSlobodni
            // 
            this.txtSlobodni.Location = new System.Drawing.Point(197, 147);
            this.txtSlobodni.Name = "txtSlobodni";
            this.txtSlobodni.Size = new System.Drawing.Size(172, 22);
            this.txtSlobodni.TabIndex = 12;
            this.txtSlobodni.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtCena
            // 
            this.txtCena.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtCena.Location = new System.Drawing.Point(197, 246);
            this.txtCena.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(172, 22);
            this.txtCena.TabIndex = 13;
            this.txtCena.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ден.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // DodadiLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtSlobodni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMapa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.txtKrajna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPocetna);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DodadiLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додади Линија";
            ((System.ComponentModel.ISupportInitialize)(this.txtSlobodni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
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
        private System.Windows.Forms.TextBox txtMapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtSlobodni;
        private System.Windows.Forms.NumericUpDown txtCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}