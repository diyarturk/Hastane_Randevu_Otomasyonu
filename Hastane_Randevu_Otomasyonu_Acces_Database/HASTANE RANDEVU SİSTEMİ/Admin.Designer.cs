namespace HASTANE_RANDEVU_SİSTEMİ
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDoktorEkle = new System.Windows.Forms.Panel();
            this.btn_doktoriptal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.doktorekle = new System.Windows.Forms.Button();
            this.txt_doktor = new System.Windows.Forms.TextBox();
            this.btn_doktorsil = new System.Windows.Forms.Button();
            this.btn_doktorekle = new System.Windows.Forms.Button();
            this.doktorlar = new System.Windows.Forms.ListBox();
            this.btn_klinikekle = new System.Windows.Forms.Button();
            this.btn_kliniksil = new System.Windows.Forms.Button();
            this.pnlKlinikEkle = new System.Windows.Forms.Panel();
            this.btn_klinikiptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.klinikekle = new System.Windows.Forms.Button();
            this.txt_klinik = new System.Windows.Forms.TextBox();
            this.klinikler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDoktorEkle.SuspendLayout();
            this.pnlKlinikEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(407, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 25);
            this.button2.TabIndex = 29;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(447, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDoktorEkle
            // 
            this.pnlDoktorEkle.Controls.Add(this.btn_doktoriptal);
            this.pnlDoktorEkle.Controls.Add(this.label4);
            this.pnlDoktorEkle.Controls.Add(this.doktorekle);
            this.pnlDoktorEkle.Controls.Add(this.txt_doktor);
            this.pnlDoktorEkle.Location = new System.Drawing.Point(246, 287);
            this.pnlDoktorEkle.Name = "pnlDoktorEkle";
            this.pnlDoktorEkle.Size = new System.Drawing.Size(226, 75);
            this.pnlDoktorEkle.TabIndex = 65;
            this.pnlDoktorEkle.Visible = false;
            // 
            // btn_doktoriptal
            // 
            this.btn_doktoriptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_doktoriptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doktoriptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doktoriptal.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doktoriptal.ForeColor = System.Drawing.Color.White;
            this.btn_doktoriptal.Location = new System.Drawing.Point(11, 37);
            this.btn_doktoriptal.Name = "btn_doktoriptal";
            this.btn_doktoriptal.Size = new System.Drawing.Size(98, 31);
            this.btn_doktoriptal.TabIndex = 12;
            this.btn_doktoriptal.Text = "İptal";
            this.btn_doktoriptal.UseVisualStyleBackColor = false;
            this.btn_doktoriptal.Click += new System.EventHandler(this.btnDoktorIptal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(2, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ad Soyad :";
            // 
            // doktorekle
            // 
            this.doktorekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.doktorekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doktorekle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktorekle.ForeColor = System.Drawing.Color.White;
            this.doktorekle.Location = new System.Drawing.Point(113, 37);
            this.doktorekle.Name = "doktorekle";
            this.doktorekle.Size = new System.Drawing.Size(104, 31);
            this.doktorekle.TabIndex = 11;
            this.doktorekle.Text = "Ekle";
            this.doktorekle.UseVisualStyleBackColor = false;
            this.doktorekle.Click += new System.EventHandler(this.DoktorEkleTamam_Click);
            // 
            // txt_doktor
            // 
            this.txt_doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_doktor.Location = new System.Drawing.Point(86, 4);
            this.txt_doktor.Multiline = true;
            this.txt_doktor.Name = "txt_doktor";
            this.txt_doktor.Size = new System.Drawing.Size(133, 29);
            this.txt_doktor.TabIndex = 9;
            // 
            // btn_doktorsil
            // 
            this.btn_doktorsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_doktorsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doktorsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doktorsil.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doktorsil.ForeColor = System.Drawing.Color.White;
            this.btn_doktorsil.Location = new System.Drawing.Point(248, 253);
            this.btn_doktorsil.Name = "btn_doktorsil";
            this.btn_doktorsil.Size = new System.Drawing.Size(235, 32);
            this.btn_doktorsil.TabIndex = 59;
            this.btn_doktorsil.Text = "Doktor Sil";
            this.btn_doktorsil.UseVisualStyleBackColor = false;
            this.btn_doktorsil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btn_doktorekle
            // 
            this.btn_doktorekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_doktorekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doktorekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doktorekle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doktorekle.ForeColor = System.Drawing.Color.White;
            this.btn_doktorekle.Location = new System.Drawing.Point(246, 218);
            this.btn_doktorekle.Name = "btn_doktorekle";
            this.btn_doktorekle.Size = new System.Drawing.Size(237, 32);
            this.btn_doktorekle.TabIndex = 58;
            this.btn_doktorekle.Text = "Doktor Ekle";
            this.btn_doktorekle.UseVisualStyleBackColor = false;
            this.btn_doktorekle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // doktorlar
            // 
            this.doktorlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.doktorlar.ForeColor = System.Drawing.Color.White;
            this.doktorlar.FormattingEnabled = true;
            this.doktorlar.Location = new System.Drawing.Point(244, 31);
            this.doktorlar.Name = "doktorlar";
            this.doktorlar.Size = new System.Drawing.Size(240, 186);
            this.doktorlar.TabIndex = 60;
            this.doktorlar.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktor_SelectedIndexChanged);
            // 
            // btn_klinikekle
            // 
            this.btn_klinikekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_klinikekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_klinikekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_klinikekle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klinikekle.ForeColor = System.Drawing.Color.White;
            this.btn_klinikekle.Location = new System.Drawing.Point(4, 217);
            this.btn_klinikekle.Name = "btn_klinikekle";
            this.btn_klinikekle.Size = new System.Drawing.Size(238, 32);
            this.btn_klinikekle.TabIndex = 55;
            this.btn_klinikekle.Text = "Klinik Ekle";
            this.btn_klinikekle.UseVisualStyleBackColor = false;
            this.btn_klinikekle.Click += new System.EventHandler(this.btnKlinikEkle_Click);
            // 
            // btn_kliniksil
            // 
            this.btn_kliniksil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_kliniksil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kliniksil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kliniksil.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kliniksil.ForeColor = System.Drawing.Color.White;
            this.btn_kliniksil.Location = new System.Drawing.Point(4, 252);
            this.btn_kliniksil.Name = "btn_kliniksil";
            this.btn_kliniksil.Size = new System.Drawing.Size(238, 32);
            this.btn_kliniksil.TabIndex = 56;
            this.btn_kliniksil.Text = "Klinik Sil";
            this.btn_kliniksil.UseVisualStyleBackColor = false;
            this.btn_kliniksil.Click += new System.EventHandler(this.btnKlinikSil_Click);
            // 
            // pnlKlinikEkle
            // 
            this.pnlKlinikEkle.Controls.Add(this.btn_klinikiptal);
            this.pnlKlinikEkle.Controls.Add(this.label3);
            this.pnlKlinikEkle.Controls.Add(this.klinikekle);
            this.pnlKlinikEkle.Controls.Add(this.txt_klinik);
            this.pnlKlinikEkle.Location = new System.Drawing.Point(4, 287);
            this.pnlKlinikEkle.Name = "pnlKlinikEkle";
            this.pnlKlinikEkle.Size = new System.Drawing.Size(236, 72);
            this.pnlKlinikEkle.TabIndex = 64;
            this.pnlKlinikEkle.Visible = false;
            // 
            // btn_klinikiptal
            // 
            this.btn_klinikiptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_klinikiptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_klinikiptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_klinikiptal.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klinikiptal.ForeColor = System.Drawing.Color.White;
            this.btn_klinikiptal.Location = new System.Drawing.Point(23, 36);
            this.btn_klinikiptal.Name = "btn_klinikiptal";
            this.btn_klinikiptal.Size = new System.Drawing.Size(100, 31);
            this.btn_klinikiptal.TabIndex = 15;
            this.btn_klinikiptal.Text = "İptal";
            this.btn_klinikiptal.UseVisualStyleBackColor = false;
            this.btn_klinikiptal.Click += new System.EventHandler(this.btnKlinikİptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(20, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Klinik Ad :";
            // 
            // klinikekle
            // 
            this.klinikekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.klinikekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.klinikekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.klinikekle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klinikekle.ForeColor = System.Drawing.Color.White;
            this.klinikekle.Location = new System.Drawing.Point(127, 36);
            this.klinikekle.Name = "klinikekle";
            this.klinikekle.Size = new System.Drawing.Size(99, 31);
            this.klinikekle.TabIndex = 14;
            this.klinikekle.Text = "Ekle";
            this.klinikekle.UseVisualStyleBackColor = false;
            this.klinikekle.Click += new System.EventHandler(this.pnlKlinikEkleTamam_Click);
            // 
            // txt_klinik
            // 
            this.txt_klinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_klinik.Location = new System.Drawing.Point(96, 4);
            this.txt_klinik.Multiline = true;
            this.txt_klinik.Name = "txt_klinik";
            this.txt_klinik.Size = new System.Drawing.Size(137, 29);
            this.txt_klinik.TabIndex = 13;
            // 
            // klinikler
            // 
            this.klinikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.klinikler.ForeColor = System.Drawing.Color.White;
            this.klinikler.FormattingEnabled = true;
            this.klinikler.Location = new System.Drawing.Point(2, 30);
            this.klinikler.Name = "klinikler";
            this.klinikler.Size = new System.Drawing.Size(240, 186);
            this.klinikler.TabIndex = 61;
            this.klinikler.SelectedIndexChanged += new System.EventHandler(this.klinikler_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 36);
            this.label1.TabIndex = 66;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(485, 364);
            this.Controls.Add(this.pnlDoktorEkle);
            this.Controls.Add(this.klinikler);
            this.Controls.Add(this.btn_doktorsil);
            this.Controls.Add(this.pnlKlinikEkle);
            this.Controls.Add(this.btn_doktorekle);
            this.Controls.Add(this.doktorlar);
            this.Controls.Add(this.btn_kliniksil);
            this.Controls.Add(this.btn_klinikekle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "AdminPaneli";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pnlDoktorEkle.ResumeLayout(false);
            this.pnlDoktorEkle.PerformLayout();
            this.pnlKlinikEkle.ResumeLayout(false);
            this.pnlKlinikEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDoktorEkle;
        private System.Windows.Forms.Button btn_doktoriptal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button doktorekle;
        private System.Windows.Forms.TextBox txt_doktor;
        private System.Windows.Forms.Button btn_doktorsil;
        private System.Windows.Forms.Button btn_doktorekle;
        private System.Windows.Forms.ListBox doktorlar;
        private System.Windows.Forms.Button btn_klinikekle;
        private System.Windows.Forms.Button btn_kliniksil;
        private System.Windows.Forms.Panel pnlKlinikEkle;
        private System.Windows.Forms.Button btn_klinikiptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button klinikekle;
        private System.Windows.Forms.TextBox txt_klinik;
        private System.Windows.Forms.ListBox klinikler;
        private System.Windows.Forms.Label label1;
    }
}