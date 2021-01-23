namespace istakipProgrami
{
    partial class frm_gorevli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kaydet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 153);
            this.panel1.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Depth = 0;
            this.btn_kaydet.Location = new System.Drawing.Point(12, 238);
            this.btn_kaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Primary = true;
            this.btn_kaydet.Size = new System.Drawing.Size(172, 23);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_gorevli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(200, 279);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.panel1);
            this.Name = "frm_gorevli";
            this.Text = "Görevli Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frm_gorevli_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_kaydet;
    }
}