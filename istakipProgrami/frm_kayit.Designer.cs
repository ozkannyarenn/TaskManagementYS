namespace istakipProgrami
{
    partial class frm_kayit
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
            this.btn_kaydet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_ad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_soyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_kullanici = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_parola = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_tekrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Depth = 0;
            this.btn_kaydet.Location = new System.Drawing.Point(99, 305);
            this.btn_kaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Primary = true;
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 23;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Depth = 0;
            this.txt_ad.Hint = "Ad";
            this.txt_ad.Location = new System.Drawing.Point(24, 88);
            this.txt_ad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.PasswordChar = '\0';
            this.txt_ad.SelectedText = "";
            this.txt_ad.SelectionLength = 0;
            this.txt_ad.SelectionStart = 0;
            this.txt_ad.Size = new System.Drawing.Size(233, 23);
            this.txt_ad.TabIndex = 24;
            this.txt_ad.UseSystemPasswordChar = false;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Depth = 0;
            this.txt_soyad.Hint = "Soyad";
            this.txt_soyad.Location = new System.Drawing.Point(24, 133);
            this.txt_soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.PasswordChar = '\0';
            this.txt_soyad.SelectedText = "";
            this.txt_soyad.SelectionLength = 0;
            this.txt_soyad.SelectionStart = 0;
            this.txt_soyad.Size = new System.Drawing.Size(233, 23);
            this.txt_soyad.TabIndex = 25;
            this.txt_soyad.UseSystemPasswordChar = false;
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Depth = 0;
            this.txt_kullanici.Hint = "Kullanıcı Adı";
            this.txt_kullanici.Location = new System.Drawing.Point(24, 180);
            this.txt_kullanici.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.PasswordChar = '\0';
            this.txt_kullanici.SelectedText = "";
            this.txt_kullanici.SelectionLength = 0;
            this.txt_kullanici.SelectionStart = 0;
            this.txt_kullanici.Size = new System.Drawing.Size(233, 23);
            this.txt_kullanici.TabIndex = 26;
            this.txt_kullanici.UseSystemPasswordChar = false;
            // 
            // txt_parola
            // 
            this.txt_parola.Depth = 0;
            this.txt_parola.Hint = "Parola";
            this.txt_parola.Location = new System.Drawing.Point(24, 226);
            this.txt_parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.SelectedText = "";
            this.txt_parola.SelectionLength = 0;
            this.txt_parola.SelectionStart = 0;
            this.txt_parola.Size = new System.Drawing.Size(233, 23);
            this.txt_parola.TabIndex = 27;
            this.txt_parola.UseSystemPasswordChar = false;
            // 
            // txt_tekrar
            // 
            this.txt_tekrar.Depth = 0;
            this.txt_tekrar.Hint = "Parola Tekrarı";
            this.txt_tekrar.Location = new System.Drawing.Point(24, 273);
            this.txt_tekrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tekrar.Name = "txt_tekrar";
            this.txt_tekrar.PasswordChar = '*';
            this.txt_tekrar.SelectedText = "";
            this.txt_tekrar.SelectionLength = 0;
            this.txt_tekrar.SelectionStart = 0;
            this.txt_tekrar.Size = new System.Drawing.Size(233, 23);
            this.txt_tekrar.TabIndex = 28;
            this.txt_tekrar.UseSystemPasswordChar = false;
            // 
            // frm_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(287, 340);
            this.Controls.Add(this.txt_tekrar);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "frm_kayit";
            this.Text = "Kayıt Sayfası";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btn_kaydet;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_soyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_kullanici;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_parola;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tekrar;
    }
}