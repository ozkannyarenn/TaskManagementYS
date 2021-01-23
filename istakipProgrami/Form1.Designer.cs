namespace istakipProgrami
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
            this.txt_kull = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_parola = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_giris = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_kayit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txt_kull
            // 
            this.txt_kull.Depth = 0;
            this.txt_kull.Hint = "Kullanıcı Adı";
            this.txt_kull.Location = new System.Drawing.Point(31, 87);
            this.txt_kull.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_kull.Name = "txt_kull";
            this.txt_kull.PasswordChar = '\0';
            this.txt_kull.SelectedText = "";
            this.txt_kull.SelectionLength = 0;
            this.txt_kull.SelectionStart = 0;
            this.txt_kull.Size = new System.Drawing.Size(252, 23);
            this.txt_kull.TabIndex = 9;
            this.txt_kull.UseSystemPasswordChar = false;
            // 
            // txt_parola
            // 
            this.txt_parola.Depth = 0;
            this.txt_parola.Hint = "Parola";
            this.txt_parola.Location = new System.Drawing.Point(31, 130);
            this.txt_parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '\0';
            this.txt_parola.SelectedText = "";
            this.txt_parola.SelectionLength = 0;
            this.txt_parola.SelectionStart = 0;
            this.txt_parola.Size = new System.Drawing.Size(252, 23);
            this.txt_parola.TabIndex = 10;
            this.txt_parola.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.Depth = 0;
            this.btn_giris.Location = new System.Drawing.Point(55, 181);
            this.btn_giris.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Primary = true;
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 11;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Depth = 0;
            this.btn_kayit.Location = new System.Drawing.Point(183, 181);
            this.btn_kayit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Primary = true;
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 12;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(314, 235);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.txt_kull);
            this.Name = "Form1";
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_kull;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_parola;
        private MaterialSkin.Controls.MaterialRaisedButton btn_giris;
        private MaterialSkin.Controls.MaterialRaisedButton btn_kayit;
    }
}

