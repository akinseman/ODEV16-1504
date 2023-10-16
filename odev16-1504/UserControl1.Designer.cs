namespace odev16_1504
{
    partial class UserControl1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lidsya = new System.Windows.Forms.ListBox();
            this.lsuzunluk = new System.Windows.Forms.ListBox();
            this.ravıdoyo = new System.Windows.Forms.RadioButton();
            this.raresim = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnkontol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lidsya
            // 
            this.lidsya.FormattingEnabled = true;
            this.lidsya.Location = new System.Drawing.Point(142, 13);
            this.lidsya.Name = "lidsya";
            this.lidsya.Size = new System.Drawing.Size(169, 160);
            this.lidsya.TabIndex = 1;
            // 
            // lsuzunluk
            // 
            this.lsuzunluk.FormattingEnabled = true;
            this.lsuzunluk.Items.AddRange(new object[] {
            "mp4",
            "jpg",
            "mov",
            "pıng"});
            this.lsuzunluk.Location = new System.Drawing.Point(16, 13);
            this.lsuzunluk.Name = "lsuzunluk";
            this.lsuzunluk.Size = new System.Drawing.Size(120, 147);
            this.lsuzunluk.TabIndex = 2;
            this.lsuzunluk.TabStop = false;
            // 
            // ravıdoyo
            // 
            this.ravıdoyo.AutoSize = true;
            this.ravıdoyo.Location = new System.Drawing.Point(164, 56);
            this.ravıdoyo.Name = "ravıdoyo";
            this.ravıdoyo.Size = new System.Drawing.Size(89, 17);
            this.ravıdoyo.TabIndex = 3;
            this.ravıdoyo.TabStop = true;
            this.ravıdoyo.Text = "video dosyası";
            this.ravıdoyo.UseVisualStyleBackColor = true;
            // 
            // raresim
            // 
            this.raresim.AutoSize = true;
            this.raresim.Location = new System.Drawing.Point(164, 79);
            this.raresim.Name = "raresim";
            this.raresim.Size = new System.Drawing.Size(87, 17);
            this.raresim.TabIndex = 4;
            this.raresim.TabStop = true;
            this.raresim.Text = "resim dosyası";
            this.raresim.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnkontol
            // 
            this.btnkontol.Location = new System.Drawing.Point(38, 208);
            this.btnkontol.Name = "btnkontol";
            this.btnkontol.Size = new System.Drawing.Size(181, 37);
            this.btnkontol.TabIndex = 7;
            this.btnkontol.Text = "kontol et";
            this.btnkontol.UseVisualStyleBackColor = true;
            this.btnkontol.Click += new System.EventHandler(this.btnkontol_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnkontol);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.raresim);
            this.Controls.Add(this.ravıdoyo);
            this.Controls.Add(this.lsuzunluk);
            this.Controls.Add(this.lidsya);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lidsya;
        private System.Windows.Forms.ListBox lsuzunluk;
        private System.Windows.Forms.RadioButton ravıdoyo;
        private System.Windows.Forms.RadioButton raresim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnkontol;
    }
}
