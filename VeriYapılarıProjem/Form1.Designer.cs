namespace VeriYapılarıProjem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            girisYap = new Button();
            kullaniciAdi = new Label();
            sifre = new Label();
            label1 = new Label();
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            SuspendLayout();
            // 
            // girisYap
            // 
            girisYap.BackColor = Color.FromArgb(192, 0, 0);
            girisYap.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            girisYap.Location = new Point(338, 279);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(203, 71);
            girisYap.TabIndex = 0;
            girisYap.Text = "Giriş Yap";
            girisYap.UseVisualStyleBackColor = false;
            girisYap.Click += button1_Click;
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.AutoSize = true;
            kullaniciAdi.BackColor = Color.FromArgb(192, 0, 0);
            kullaniciAdi.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciAdi.ForeColor = SystemColors.ControlText;
            kullaniciAdi.Location = new Point(66, 165);
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.Size = new Size(207, 39);
            kullaniciAdi.TabIndex = 1;
            kullaniciAdi.Text = "Kullanıcı Adı:";
            kullaniciAdi.Click += kullaniciAdi_Click;
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.BackColor = Color.FromArgb(192, 0, 0);
            sifre.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            sifre.ForeColor = SystemColors.ControlText;
            sifre.Location = new Point(182, 217);
            sifre.Name = "sifre";
            sifre.Size = new Size(91, 39);
            sifre.TabIndex = 2;
            sifre.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 152);
            label1.TabIndex = 3;
            label1.Text = "NAVAL HOTELE\r\n HOŞGELDİNİZ";
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKullaniciAdi.Location = new Point(292, 165);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(249, 39);
            TxtKullaniciAdi.TabIndex = 4;
            TxtKullaniciAdi.TextChanged += TxtKullaniciAdi_TextChanged;
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(292, 219);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(249, 39);
            TxtSifre.TabIndex = 5;
            TxtSifre.TextChanged += TxtSifre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1049, 622);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(sifre);
            Controls.Add(kullaniciAdi);
            Controls.Add(girisYap);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "NAVAL HOTEL YÖNETİCİ GİRİŞ SAYFASI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisYap;
        private Label kullaniciAdi;
        private Label sifre;
        private Label label1;
        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
    }
}