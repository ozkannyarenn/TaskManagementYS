namespace istakipProgrami
{
    partial class frm_projeYarat
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_proje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_musteri = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_not = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-85, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-85, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-85, -21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proje Adı:";
            // 
            // txt_proje
            // 
            this.txt_proje.Depth = 0;
            this.txt_proje.Hint = "Proje İsmi";
            this.txt_proje.Location = new System.Drawing.Point(12, 82);
            this.txt_proje.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_proje.Name = "txt_proje";
            this.txt_proje.PasswordChar = '\0';
            this.txt_proje.SelectedText = "";
            this.txt_proje.SelectionLength = 0;
            this.txt_proje.SelectionStart = 0;
            this.txt_proje.Size = new System.Drawing.Size(330, 23);
            this.txt_proje.TabIndex = 15;
            this.txt_proje.UseSystemPasswordChar = false;
            // 
            // txt_musteri
            // 
            this.txt_musteri.Depth = 0;
            this.txt_musteri.Hint = "Müşteri İsmi";
            this.txt_musteri.Location = new System.Drawing.Point(12, 132);
            this.txt_musteri.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.PasswordChar = '\0';
            this.txt_musteri.SelectedText = "";
            this.txt_musteri.SelectionLength = 0;
            this.txt_musteri.SelectionStart = 0;
            this.txt_musteri.Size = new System.Drawing.Size(330, 23);
            this.txt_musteri.TabIndex = 16;
            this.txt_musteri.UseSystemPasswordChar = false;
            // 
            // txt_not
            // 
            this.txt_not.Depth = 0;
            this.txt_not.Hint = "Not Al";
            this.txt_not.Location = new System.Drawing.Point(12, 182);
            this.txt_not.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_not.Name = "txt_not";
            this.txt_not.PasswordChar = '\0';
            this.txt_not.SelectedText = "";
            this.txt_not.SelectionLength = 0;
            this.txt_not.SelectionStart = 0;
            this.txt_not.Size = new System.Drawing.Size(330, 23);
            this.txt_not.TabIndex = 17;
            this.txt_not.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 222);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(330, 36);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "Oluştur";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // frm_projeYarat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txt_not);
            this.Controls.Add(this.txt_musteri);
            this.Controls.Add(this.txt_proje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_projeYarat";
            this.Text = "Proje Oluşturma Sayfası";
            this.Load += new System.EventHandler(this.frm_projeYarat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_proje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_musteri;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_not;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}