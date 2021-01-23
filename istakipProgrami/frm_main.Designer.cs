namespace istakipProgrami
{
    partial class frm_main
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
            this.btn_hareket = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_kullanici = new MaterialSkin.Controls.MaterialLabel();
            this.btn_projeOlustur = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_gecen = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tahmin = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_seciliProje = new System.Windows.Forms.GroupBox();
            this.btn_gorevEkle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_gorevliEkle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmb_projeler = new System.Windows.Forms.ComboBox();
            this.list_todo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_progress = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_done = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4.SuspendLayout();
            this.grp_seciliProje.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hareket
            // 
            this.btn_hareket.Depth = 0;
            this.btn_hareket.Location = new System.Drawing.Point(31, 440);
            this.btn_hareket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_hareket.Name = "btn_hareket";
            this.btn_hareket.Primary = true;
            this.btn_hareket.Size = new System.Drawing.Size(221, 44);
            this.btn_hareket.TabIndex = 13;
            this.btn_hareket.Text = "Görev Hareketleri";
            this.btn_hareket.UseVisualStyleBackColor = true;
            this.btn_hareket.Click += new System.EventHandler(this.btn_hareket_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Projeler";
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Depth = 0;
            this.lbl_kullanici.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_kullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_kullanici.Location = new System.Drawing.Point(24, 29);
            this.lbl_kullanici.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(84, 19);
            this.lbl_kullanici.TabIndex = 5;
            this.lbl_kullanici.Text = "Kullanici ID";
            // 
            // btn_projeOlustur
            // 
            this.btn_projeOlustur.Depth = 0;
            this.btn_projeOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_projeOlustur.Location = new System.Drawing.Point(28, 56);
            this.btn_projeOlustur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_projeOlustur.Name = "btn_projeOlustur";
            this.btn_projeOlustur.Primary = true;
            this.btn_projeOlustur.Size = new System.Drawing.Size(224, 40);
            this.btn_projeOlustur.TabIndex = 5;
            this.btn_projeOlustur.Text = "Yeni Proje Oluştur";
            this.btn_projeOlustur.UseVisualStyleBackColor = true;
            this.btn_projeOlustur.Click += new System.EventHandler(this.btn_projeOlustur_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_gecen);
            this.groupBox4.Controls.Add(this.lbl_tahmin);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(31, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 118);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Süre Hesaplama (DAKİKA)";
            // 
            // lbl_gecen
            // 
            this.lbl_gecen.AutoSize = true;
            this.lbl_gecen.Depth = 0;
            this.lbl_gecen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_gecen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_gecen.Location = new System.Drawing.Point(104, 73);
            this.lbl_gecen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_gecen.Name = "lbl_gecen";
            this.lbl_gecen.Size = new System.Drawing.Size(21, 19);
            this.lbl_gecen.TabIndex = 13;
            this.lbl_gecen.Text = "...";
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.Depth = 0;
            this.lbl_tahmin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_tahmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tahmin.Location = new System.Drawing.Point(104, 36);
            this.lbl_tahmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(21, 19);
            this.lbl_tahmin.TabIndex = 12;
            this.lbl_tahmin.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Geçen Süre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tahmini Süre:";
            // 
            // grp_seciliProje
            // 
            this.grp_seciliProje.Controls.Add(this.btn_gorevEkle);
            this.grp_seciliProje.Controls.Add(this.btn_gorevliEkle);
            this.grp_seciliProje.Enabled = false;
            this.grp_seciliProje.Location = new System.Drawing.Point(31, 169);
            this.grp_seciliProje.Name = "grp_seciliProje";
            this.grp_seciliProje.Size = new System.Drawing.Size(221, 118);
            this.grp_seciliProje.TabIndex = 8;
            this.grp_seciliProje.TabStop = false;
            this.grp_seciliProje.Text = "Seçili Projeye;";
            // 
            // btn_gorevEkle
            // 
            this.btn_gorevEkle.Depth = 0;
            this.btn_gorevEkle.Location = new System.Drawing.Point(15, 30);
            this.btn_gorevEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_gorevEkle.Name = "btn_gorevEkle";
            this.btn_gorevEkle.Primary = true;
            this.btn_gorevEkle.Size = new System.Drawing.Size(195, 23);
            this.btn_gorevEkle.TabIndex = 12;
            this.btn_gorevEkle.Text = "Görev Ekle";
            this.btn_gorevEkle.UseVisualStyleBackColor = true;
            this.btn_gorevEkle.Click += new System.EventHandler(this.btn_gorevEkle_Click);
            // 
            // btn_gorevliEkle
            // 
            this.btn_gorevliEkle.Depth = 0;
            this.btn_gorevliEkle.Location = new System.Drawing.Point(15, 73);
            this.btn_gorevliEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_gorevliEkle.Name = "btn_gorevliEkle";
            this.btn_gorevliEkle.Primary = true;
            this.btn_gorevliEkle.Size = new System.Drawing.Size(195, 23);
            this.btn_gorevliEkle.TabIndex = 5;
            this.btn_gorevliEkle.Text = "Görevli Ekle";
            this.btn_gorevliEkle.UseVisualStyleBackColor = true;
            this.btn_gorevliEkle.Click += new System.EventHandler(this.btn_gorevliEkle_Click);
            // 
            // cmb_projeler
            // 
            this.cmb_projeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projeler.FormattingEnabled = true;
            this.cmb_projeler.Location = new System.Drawing.Point(28, 121);
            this.cmb_projeler.Name = "cmb_projeler";
            this.cmb_projeler.Size = new System.Drawing.Size(224, 21);
            this.cmb_projeler.TabIndex = 1;
            this.cmb_projeler.SelectedIndexChanged += new System.EventHandler(this.cmb_projeler_SelectedIndexChanged);
            // 
            // list_todo
            // 
            this.list_todo.BackColor = System.Drawing.SystemColors.Control;
            this.list_todo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_todo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_todo.FormattingEnabled = true;
            this.list_todo.Location = new System.Drawing.Point(3, 16);
            this.list_todo.Name = "list_todo";
            this.list_todo.Size = new System.Drawing.Size(300, 415);
            this.list_todo.TabIndex = 1;
            this.list_todo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDoubleClick);
            this.list_todo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_todo);
            this.groupBox1.Location = new System.Drawing.Point(332, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_progress);
            this.groupBox2.Location = new System.Drawing.Point(661, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 434);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In Progress";
            // 
            // list_progress
            // 
            this.list_progress.AllowDrop = true;
            this.list_progress.BackColor = System.Drawing.SystemColors.Control;
            this.list_progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_progress.FormattingEnabled = true;
            this.list_progress.Location = new System.Drawing.Point(3, 16);
            this.list_progress.Name = "list_progress";
            this.list_progress.Size = new System.Drawing.Size(300, 415);
            this.list_progress.TabIndex = 1;
            this.list_progress.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_progress_DragDrop);
            this.list_progress.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_progress_DragEnter);
            this.list_progress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDoubleClick);
            this.list_progress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_done);
            this.groupBox3.Location = new System.Drawing.Point(991, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 434);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Done";
            // 
            // list_done
            // 
            this.list_done.BackColor = System.Drawing.SystemColors.Control;
            this.list_done.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_done.FormattingEnabled = true;
            this.list_done.Location = new System.Drawing.Point(3, 16);
            this.list_done.Name = "list_done";
            this.list_done.Size = new System.Drawing.Size(300, 415);
            this.list_done.TabIndex = 1;
            this.list_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_done_DragDrop);
            this.list_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_done_DragEnter);
            this.list_done.DoubleClick += new System.EventHandler(this.list_done_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.btn_hareket);
            this.panel2.Controls.Add(this.lbl_kullanici);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.cmb_projeler);
            this.panel2.Controls.Add(this.grp_seciliProje);
            this.panel2.Controls.Add(this.btn_projeOlustur);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 497);
            this.panel2.TabIndex = 5;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1316, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_main";
            this.Text = "Ana Islem Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grp_seciliProje.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_projeler;
        private System.Windows.Forms.ListBox list_todo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_progress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox list_done;
        private System.Windows.Forms.GroupBox grp_seciliProje;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_projeOlustur;
        private MaterialSkin.Controls.MaterialLabel lbl_kullanici;
        private MaterialSkin.Controls.MaterialRaisedButton btn_gorevEkle;
        private MaterialSkin.Controls.MaterialRaisedButton btn_gorevliEkle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_tahmin;
        private MaterialSkin.Controls.MaterialLabel lbl_gecen;
        private MaterialSkin.Controls.MaterialRaisedButton btn_hareket;
        private System.Windows.Forms.Panel panel2;
    }
}