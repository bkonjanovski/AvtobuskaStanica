namespace AvtobuskaStanica
{
    partial class KupiBilet_Guest
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
            this.txtPocetna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKrajna = new System.Windows.Forms.TextBox();
            this.pctPrevoznikLogo = new System.Windows.Forms.PictureBox();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVkupnoCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlobodni = new System.Windows.Forms.TextBox();
            this.chkStudentska = new System.Windows.Forms.CheckBox();
            this.chkPovraten = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numBrKarti = new System.Windows.Forms.NumericUpDown();
            this.chkChekirana = new System.Windows.Forms.CheckBox();
            this.pctMapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrevoznikLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrKarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPocetna
            // 
            this.txtPocetna.Enabled = false;
            this.txtPocetna.Location = new System.Drawing.Point(21, 168);
            this.txtPocetna.Name = "txtPocetna";
            this.txtPocetna.ReadOnly = true;
            this.txtPocetna.Size = new System.Drawing.Size(154, 22);
            this.txtPocetna.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Почетна дестинација:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Крајна дестинација:";
            // 
            // txtKrajna
            // 
            this.txtKrajna.Enabled = false;
            this.txtKrajna.Location = new System.Drawing.Point(226, 168);
            this.txtKrajna.Name = "txtKrajna";
            this.txtKrajna.ReadOnly = true;
            this.txtKrajna.Size = new System.Drawing.Size(154, 22);
            this.txtKrajna.TabIndex = 2;
            // 
            // pctPrevoznikLogo
            // 
            this.pctPrevoznikLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctPrevoznikLogo.Location = new System.Drawing.Point(24, 28);
            this.pctPrevoznikLogo.Name = "pctPrevoznikLogo";
            this.pctPrevoznikLogo.Size = new System.Drawing.Size(356, 92);
            this.pctPrevoznikLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrevoznikLogo.TabIndex = 4;
            this.pctPrevoznikLogo.TabStop = false;
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(186, 424);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(100, 34);
            this.btnKupi.TabIndex = 5;
            this.btnKupi.Text = "Купи билет";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Location = new System.Drawing.Point(314, 424);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(100, 34);
            this.btnOtkazhi.TabIndex = 6;
            this.btnOtkazhi.Text = "Откажи";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вкупна Цена:";
            // 
            // txtVkupnoCena
            // 
            this.txtVkupnoCena.Enabled = false;
            this.txtVkupnoCena.Location = new System.Drawing.Point(226, 326);
            this.txtVkupnoCena.Name = "txtVkupnoCena";
            this.txtVkupnoCena.ReadOnly = true;
            this.txtVkupnoCena.Size = new System.Drawing.Size(154, 22);
            this.txtVkupnoCena.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Слободни места:";
            // 
            // txtSlobodni
            // 
            this.txtSlobodni.Enabled = false;
            this.txtSlobodni.Location = new System.Drawing.Point(21, 240);
            this.txtSlobodni.Name = "txtSlobodni";
            this.txtSlobodni.ReadOnly = true;
            this.txtSlobodni.Size = new System.Drawing.Size(154, 22);
            this.txtSlobodni.TabIndex = 7;
            // 
            // chkStudentska
            // 
            this.chkStudentska.AutoSize = true;
            this.chkStudentska.Location = new System.Drawing.Point(21, 289);
            this.chkStudentska.Name = "chkStudentska";
            this.chkStudentska.Size = new System.Drawing.Size(106, 21);
            this.chkStudentska.TabIndex = 13;
            this.chkStudentska.Text = "Студентска";
            this.chkStudentska.UseVisualStyleBackColor = true;
            this.chkStudentska.CheckedChanged += new System.EventHandler(this.chkStudentska_CheckedChanged);
            // 
            // chkPovraten
            // 
            this.chkPovraten.AutoSize = true;
            this.chkPovraten.Location = new System.Drawing.Point(21, 327);
            this.chkPovraten.Name = "chkPovraten";
            this.chkPovraten.Size = new System.Drawing.Size(94, 21);
            this.chkPovraten.TabIndex = 14;
            this.chkPovraten.Text = "Повратен";
            this.chkPovraten.UseVisualStyleBackColor = true;
            this.chkPovraten.CheckedChanged += new System.EventHandler(this.chkPovraten_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Број на карти:";
            // 
            // numBrKarti
            // 
            this.numBrKarti.Location = new System.Drawing.Point(229, 241);
            this.numBrKarti.Name = "numBrKarti";
            this.numBrKarti.Size = new System.Drawing.Size(120, 22);
            this.numBrKarti.TabIndex = 17;
            this.numBrKarti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrKarti.ValueChanged += new System.EventHandler(this.numBrKarti_ValueChanged);
            // 
            // chkChekirana
            // 
            this.chkChekirana.AutoSize = true;
            this.chkChekirana.Checked = true;
            this.chkChekirana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChekirana.Location = new System.Drawing.Point(21, 366);
            this.chkChekirana.Name = "chkChekirana";
            this.chkChekirana.Size = new System.Drawing.Size(136, 21);
            this.chkChekirana.TabIndex = 18;
            this.chkChekirana.Text = "Чекирај веднаш";
            this.chkChekirana.UseVisualStyleBackColor = true;
            this.chkChekirana.CheckedChanged += new System.EventHandler(this.chkChekirana_CheckedChanged);
            // 
            // pctMapa
            // 
            this.pctMapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctMapa.Location = new System.Drawing.Point(442, 12);
            this.pctMapa.Name = "pctMapa";
            this.pctMapa.Size = new System.Drawing.Size(546, 452);
            this.pctMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMapa.TabIndex = 20;
            this.pctMapa.TabStop = false;
            // 
            // KupiBilet_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 479);
            this.Controls.Add(this.pctMapa);
            this.Controls.Add(this.chkChekirana);
            this.Controls.Add(this.numBrKarti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkPovraten);
            this.Controls.Add(this.chkStudentska);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVkupnoCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSlobodni);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.pctPrevoznikLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKrajna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPocetna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KupiBilet_Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Купи билет";
            this.Load += new System.EventHandler(this.KupiBilet_Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPrevoznikLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrKarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPocetna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKrajna;
        private System.Windows.Forms.PictureBox pctPrevoznikLogo;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVkupnoCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlobodni;
        private System.Windows.Forms.CheckBox chkStudentska;
        private System.Windows.Forms.CheckBox chkPovraten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBrKarti;
        private System.Windows.Forms.CheckBox chkChekirana;
        private System.Windows.Forms.PictureBox pctMapa;
    }
}