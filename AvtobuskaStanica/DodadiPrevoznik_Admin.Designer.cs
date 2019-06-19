namespace AvtobuskaStanica
{
    partial class DodadiPrevoznik_Admin
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
            this.txtImePrevoznik = new System.Windows.Forms.TextBox();
            this.txtLogoUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWebStrana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPrevoznik = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на превозник:";
            // 
            // txtImePrevoznik
            // 
            this.txtImePrevoznik.Location = new System.Drawing.Point(194, 51);
            this.txtImePrevoznik.MaxLength = 20;
            this.txtImePrevoznik.Name = "txtImePrevoznik";
            this.txtImePrevoznik.Size = new System.Drawing.Size(127, 22);
            this.txtImePrevoznik.TabIndex = 1;
            this.txtImePrevoznik.Validating += new System.ComponentModel.CancelEventHandler(this.txtImePrevoznik_Validating);
            // 
            // txtLogoUrl
            // 
            this.txtLogoUrl.Location = new System.Drawing.Point(194, 96);
            this.txtLogoUrl.Name = "txtLogoUrl";
            this.txtLogoUrl.Size = new System.Drawing.Size(127, 22);
            this.txtLogoUrl.TabIndex = 3;
            this.txtLogoUrl.Enter += new System.EventHandler(this.txtLogoUrl_Enter);
            this.txtLogoUrl.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogoUrl_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Патека до лого:";
            // 
            // txtWebStrana
            // 
            this.txtWebStrana.Location = new System.Drawing.Point(194, 138);
            this.txtWebStrana.MaxLength = 25;
            this.txtWebStrana.Name = "txtWebStrana";
            this.txtWebStrana.Size = new System.Drawing.Size(127, 22);
            this.txtWebStrana.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Веб страна:";
            // 
            // btnAddPrevoznik
            // 
            this.btnAddPrevoznik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPrevoznik.Location = new System.Drawing.Point(87, 191);
            this.btnAddPrevoznik.Name = "btnAddPrevoznik";
            this.btnAddPrevoznik.Size = new System.Drawing.Size(100, 34);
            this.btnAddPrevoznik.TabIndex = 25;
            this.btnAddPrevoznik.Text = "Додади Превозник";
            this.btnAddPrevoznik.UseVisualStyleBackColor = true;
            this.btnAddPrevoznik.Click += new System.EventHandler(this.btnAddPrevoznik_Click);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazhi.CausesValidation = false;
            this.btnOtkazhi.Location = new System.Drawing.Point(223, 191);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(100, 34);
            this.btnOtkazhi.TabIndex = 26;
            this.btnOtkazhi.Text = "Откажи";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // DodadiPrevoznik_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 273);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnAddPrevoznik);
            this.Controls.Add(this.txtWebStrana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogoUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImePrevoznik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DodadiPrevoznik_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додади Превозник";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrevoznik;
        private System.Windows.Forms.TextBox txtLogoUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWebStrana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPrevoznik;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}