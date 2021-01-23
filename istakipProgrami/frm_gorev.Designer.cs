namespace istakipProgrami
{
    partial class frm_gorev
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
            this.cmb_gorevli = new System.Windows.Forms.ComboBox();
            this.txt_baslik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_aciklama = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_kaydet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // cmb_gorevli
            // 
            this.cmb_gorevli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gorevli.FormattingEnabled = true;
            this.cmb_gorevli.Location = new System.Drawing.Point(12, 112);
            this.cmb_gorevli.Name = "cmb_gorevli";
            this.cmb_gorevli.Size = new System.Drawing.Size(210, 21);
            this.cmb_gorevli.TabIndex = 3;
            // 
            // txt_baslik
            // 
            this.txt_baslik.Depth = 0;
            this.txt_baslik.Hint = "Başlık";
            this.txt_baslik.Location = new System.Drawing.Point(12, 152);
            this.txt_baslik.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.PasswordChar = '\0';
            this.txt_baslik.SelectedText = "";
            this.txt_baslik.SelectionLength = 0;
            this.txt_baslik.SelectionStart = 0;
            this.txt_baslik.Size = new System.Drawing.Size(210, 23);
            this.txt_baslik.TabIndex = 7;
            this.txt_baslik.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Görevli";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Depth = 0;
            this.txt_aciklama.Hint = "Açıklama";
            this.txt_aciklama.Location = new System.Drawing.Point(12, 191);
            this.txt_aciklama.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.PasswordChar = '\0';
            this.txt_aciklama.SelectedText = "";
            this.txt_aciklama.SelectionLength = 0;
            this.txt_aciklama.SelectionStart = 0;
            this.txt_aciklama.Size = new System.Drawing.Size(210, 23);
            this.txt_aciklama.TabIndex = 9;
            this.txt_aciklama.UseSystemPasswordChar = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Depth = 0;
            this.btn_kaydet.Location = new System.Drawing.Point(12, 233);
            this.btn_kaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Primary = true;
            this.btn_kaydet.Size = new System.Drawing.Size(210, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_gorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 279);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.cmb_gorevli);
            this.Name = "frm_gorev";
            this.Text = "Gorevler Sayfası";
            this.Load += new System.EventHandler(this.frm_gorev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_gorevli;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_baslik;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_aciklama;
        private MaterialSkin.Controls.MaterialRaisedButton btn_kaydet;
    }
}