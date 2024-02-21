namespace HASTANE_RANDEVU_SİSTEMİ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBL_RAST = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_uyeol = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_hatirlamiyom = new System.Windows.Forms.Button();
            this.txt_kodkimlik = new System.Windows.Forms.TextBox();
            this.txt_sifrekimlik = new System.Windows.Forms.TextBox();
            this.txt_tckimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_admingirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_RAST
            // 
            this.LBL_RAST.AutoSize = true;
            this.LBL_RAST.BackColor = System.Drawing.Color.Silver;
            this.LBL_RAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_RAST.Location = new System.Drawing.Point(267, 204);
            this.LBL_RAST.Name = "LBL_RAST";
            this.LBL_RAST.Size = new System.Drawing.Size(128, 42);
            this.LBL_RAST.TabIndex = 8;
            this.LBL_RAST.Text = "00000";
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_degistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_degistir.BackgroundImage")));
            this.btn_degistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_degistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_degistir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.btn_degistir.Location = new System.Drawing.Point(250, 200);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(23, 20);
            this.btn_degistir.TabIndex = 9;
            this.btn_degistir.TabStop = false;
            this.btn_degistir.Tag = "Değiştir";
            this.toolTip1.SetToolTip(this.btn_degistir, "Değiştir");
            this.btn_degistir.UseVisualStyleBackColor = false;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(333, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 25);
            this.button2.TabIndex = 26;
            this.button2.TabStop = false;
            this.button2.Text = "_";
            this.toolTip1.SetToolTip(this.button2, "Simge Durumuna Getir");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(371, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 25;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.toolTip1.SetToolTip(this.button1, "Kapat");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(544, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown_1);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove_1);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label7_MouseUp_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "GİZLE";
            this.toolTip1.SetToolTip(this.pictureBox3, "Göster/Gizle");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_uyeol
            // 
            this.btn_uyeol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_uyeol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyeol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_uyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeol.ForeColor = System.Drawing.Color.Black;
            this.btn_uyeol.Location = new System.Drawing.Point(16, 285);
            this.btn_uyeol.Name = "btn_uyeol";
            this.btn_uyeol.Size = new System.Drawing.Size(378, 30);
            this.btn_uyeol.TabIndex = 34;
            this.btn_uyeol.TabStop = false;
            this.btn_uyeol.Text = "Üye Ol";
            this.toolTip1.SetToolTip(this.btn_uyeol, "Üye Ol");
            this.btn_uyeol.UseVisualStyleBackColor = false;
            this.btn_uyeol.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_giris.Location = new System.Drawing.Point(16, 250);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(378, 31);
            this.btn_giris.TabIndex = 33;
            this.btn_giris.TabStop = false;
            this.btn_giris.Text = "Giriş";
            this.toolTip1.SetToolTip(this.btn_giris, "Giriş");
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_hatirlamiyom
            // 
            this.btn_hatirlamiyom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.btn_hatirlamiyom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hatirlamiyom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hatirlamiyom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hatirlamiyom.ForeColor = System.Drawing.Color.Snow;
            this.btn_hatirlamiyom.Location = new System.Drawing.Point(261, 164);
            this.btn_hatirlamiyom.Name = "btn_hatirlamiyom";
            this.btn_hatirlamiyom.Size = new System.Drawing.Size(135, 34);
            this.btn_hatirlamiyom.TabIndex = 32;
            this.btn_hatirlamiyom.TabStop = false;
            this.btn_hatirlamiyom.Text = "Hatırlamıyorum";
            this.toolTip1.SetToolTip(this.btn_hatirlamiyom, "Hatırlamıyorum");
            this.btn_hatirlamiyom.UseVisualStyleBackColor = false;
            this.btn_hatirlamiyom.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_kodkimlik
            // 
            this.txt_kodkimlik.BackColor = System.Drawing.Color.White;
            this.txt_kodkimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kodkimlik.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_kodkimlik.Location = new System.Drawing.Point(16, 208);
            this.txt_kodkimlik.MaxLength = 5;
            this.txt_kodkimlik.Multiline = true;
            this.txt_kodkimlik.Name = "txt_kodkimlik";
            this.txt_kodkimlik.Size = new System.Drawing.Size(228, 34);
            this.txt_kodkimlik.TabIndex = 31;
            this.txt_kodkimlik.TabStop = false;
            this.txt_kodkimlik.Text = "Güvenlik Kodunu Giriniz";
            this.toolTip1.SetToolTip(this.txt_kodkimlik, "Güvenlik Kodunu Giriniz");
            this.txt_kodkimlik.Click += new System.EventHandler(this.txt_kodkimlik_Click);
            this.txt_kodkimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_sifrekimlik
            // 
            this.txt_sifrekimlik.BackColor = System.Drawing.Color.White;
            this.txt_sifrekimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifrekimlik.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_sifrekimlik.Location = new System.Drawing.Point(16, 164);
            this.txt_sifrekimlik.Multiline = true;
            this.txt_sifrekimlik.Name = "txt_sifrekimlik";
            this.txt_sifrekimlik.Size = new System.Drawing.Size(210, 34);
            this.txt_sifrekimlik.TabIndex = 30;
            this.txt_sifrekimlik.TabStop = false;
            this.txt_sifrekimlik.Text = "Parolanızı Giriniz";
            this.toolTip1.SetToolTip(this.txt_sifrekimlik, "Parola Giriniz");
            this.txt_sifrekimlik.Click += new System.EventHandler(this.txt_sifrekimlik_Click);
            this.txt_sifrekimlik.TabIndexChanged += new System.EventHandler(this.txt_sifrekimlik_TabIndexChanged);
            this.txt_sifrekimlik.TabStopChanged += new System.EventHandler(this.txt_sifrekimlik_TabStopChanged);
            // 
            // txt_tckimlik
            // 
            this.txt_tckimlik.BackColor = System.Drawing.Color.White;
            this.txt_tckimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tckimlik.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_tckimlik.Location = new System.Drawing.Point(18, 119);
            this.txt_tckimlik.MaxLength = 11;
            this.txt_tckimlik.Multiline = true;
            this.txt_tckimlik.Name = "txt_tckimlik";
            this.txt_tckimlik.Size = new System.Drawing.Size(378, 34);
            this.txt_tckimlik.TabIndex = 29;
            this.txt_tckimlik.TabStop = false;
            this.txt_tckimlik.Text = "T.C Kimlik Numaranızı Giriniz";
            this.toolTip1.SetToolTip(this.txt_tckimlik, "T.C. Kimilk Numaranızı Giriniz");
            this.txt_tckimlik.Click += new System.EventHandler(this.txt_tckimlik_Click);
            this.txt_tckimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Merkezi Hekim Randevu Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(306, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(266, 359);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(126, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 349);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(140, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(139, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_3);
            // 
            // btn_admingirisi
            // 
            this.btn_admingirisi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_admingirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admingirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_admingirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admingirisi.ForeColor = System.Drawing.Color.Black;
            this.btn_admingirisi.Location = new System.Drawing.Point(16, 322);
            this.btn_admingirisi.Name = "btn_admingirisi";
            this.btn_admingirisi.Size = new System.Drawing.Size(378, 30);
            this.btn_admingirisi.TabIndex = 42;
            this.btn_admingirisi.TabStop = false;
            this.btn_admingirisi.Text = "Admin Girişi";
            this.toolTip1.SetToolTip(this.btn_admingirisi, "Admin Girişi");
            this.btn_admingirisi.UseVisualStyleBackColor = false;
            this.btn_admingirisi.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(408, 404);
            this.Controls.Add(this.btn_admingirisi);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uyeol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_hatirlamiyom);
            this.Controls.Add(this.txt_kodkimlik);
            this.Controls.Add(this.txt_sifrekimlik);
            this.Controls.Add(this.txt_tckimlik);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.LBL_RAST);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MHRS GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_RAST;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_uyeol;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_hatirlamiyom;
        private System.Windows.Forms.TextBox txt_kodkimlik;
        private System.Windows.Forms.TextBox txt_sifrekimlik;
        private System.Windows.Forms.TextBox txt_tckimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_admingirisi;
    }
}

