
namespace İHH_Otomasyon_Sistemi
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.adsoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tcno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.babadı = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.telno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ibanno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.adres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.eşadı = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.eştcno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.kişisayısı = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.grub = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.uyruk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.arşivno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.yardım = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Adı Soyadı:";
            // 
            // adsoyad
            // 
            this.adsoyad.Depth = 0;
            this.adsoyad.Hint = "";
            this.adsoyad.Location = new System.Drawing.Point(154, 86);
            this.adsoyad.MaxLength = 32767;
            this.adsoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.PasswordChar = '\0';
            this.adsoyad.SelectedText = "";
            this.adsoyad.SelectionLength = 0;
            this.adsoyad.SelectionStart = 0;
            this.adsoyad.Size = new System.Drawing.Size(223, 28);
            this.adsoyad.TabIndex = 1;
            this.adsoyad.TabStop = false;
            this.adsoyad.UseSystemPasswordChar = false;
            // 
            // tcno
            // 
            this.tcno.Depth = 0;
            this.tcno.Hint = "";
            this.tcno.Location = new System.Drawing.Point(154, 137);
            this.tcno.MaxLength = 32767;
            this.tcno.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcno.Name = "tcno";
            this.tcno.PasswordChar = '\0';
            this.tcno.SelectedText = "";
            this.tcno.SelectionLength = 0;
            this.tcno.SelectionStart = 0;
            this.tcno.Size = new System.Drawing.Size(223, 28);
            this.tcno.TabIndex = 3;
            this.tcno.TabStop = false;
            this.tcno.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(137, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "T.C. Kimlik No:";
            // 
            // dt
            // 
            this.dt.Depth = 0;
            this.dt.Hint = "";
            this.dt.Location = new System.Drawing.Point(154, 181);
            this.dt.MaxLength = 32767;
            this.dt.MouseState = MaterialSkin.MouseState.HOVER;
            this.dt.Name = "dt";
            this.dt.PasswordChar = '\0';
            this.dt.SelectedText = "";
            this.dt.SelectionLength = 0;
            this.dt.SelectionStart = 0;
            this.dt.Size = new System.Drawing.Size(223, 28);
            this.dt.TabIndex = 5;
            this.dt.TabStop = false;
            this.dt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 185);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Doğum Tarihi:";
            // 
            // babadı
            // 
            this.babadı.Depth = 0;
            this.babadı.Hint = "";
            this.babadı.Location = new System.Drawing.Point(154, 228);
            this.babadı.MaxLength = 32767;
            this.babadı.MouseState = MaterialSkin.MouseState.HOVER;
            this.babadı.Name = "babadı";
            this.babadı.PasswordChar = '\0';
            this.babadı.SelectedText = "";
            this.babadı.SelectionLength = 0;
            this.babadı.SelectionStart = 0;
            this.babadı.Size = new System.Drawing.Size(223, 28);
            this.babadı.TabIndex = 7;
            this.babadı.TabStop = false;
            this.babadı.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Baba Adı:";
            // 
            // telno
            // 
            this.telno.Depth = 0;
            this.telno.Hint = "";
            this.telno.Location = new System.Drawing.Point(154, 276);
            this.telno.MaxLength = 32767;
            this.telno.MouseState = MaterialSkin.MouseState.HOVER;
            this.telno.Name = "telno";
            this.telno.PasswordChar = '\0';
            this.telno.SelectedText = "";
            this.telno.SelectionLength = 0;
            this.telno.SelectionStart = 0;
            this.telno.Size = new System.Drawing.Size(223, 28);
            this.telno.TabIndex = 9;
            this.telno.TabStop = false;
            this.telno.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(11, 276);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(109, 24);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Telefon No:";
            // 
            // ibanno
            // 
            this.ibanno.Depth = 0;
            this.ibanno.Hint = "";
            this.ibanno.Location = new System.Drawing.Point(154, 325);
            this.ibanno.MaxLength = 32767;
            this.ibanno.MouseState = MaterialSkin.MouseState.HOVER;
            this.ibanno.Name = "ibanno";
            this.ibanno.PasswordChar = '\0';
            this.ibanno.SelectedText = "";
            this.ibanno.SelectionLength = 0;
            this.ibanno.SelectionStart = 0;
            this.ibanno.Size = new System.Drawing.Size(223, 28);
            this.ibanno.TabIndex = 11;
            this.ibanno.TabStop = false;
            this.ibanno.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(11, 329);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 24);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "İban No:";
            // 
            // adres
            // 
            this.adres.Depth = 0;
            this.adres.Hint = "";
            this.adres.Location = new System.Drawing.Point(154, 372);
            this.adres.MaxLength = 32767;
            this.adres.MouseState = MaterialSkin.MouseState.HOVER;
            this.adres.Name = "adres";
            this.adres.PasswordChar = '\0';
            this.adres.SelectedText = "";
            this.adres.SelectionLength = 0;
            this.adres.SelectionStart = 0;
            this.adres.Size = new System.Drawing.Size(223, 28);
            this.adres.TabIndex = 13;
            this.adres.TabStop = false;
            this.adres.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 376);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(132, 24);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "İkamet Adresi:";
            // 
            // eşadı
            // 
            this.eşadı.Depth = 0;
            this.eşadı.Hint = "";
            this.eşadı.Location = new System.Drawing.Point(625, 86);
            this.eşadı.MaxLength = 32767;
            this.eşadı.MouseState = MaterialSkin.MouseState.HOVER;
            this.eşadı.Name = "eşadı";
            this.eşadı.PasswordChar = '\0';
            this.eşadı.SelectedText = "";
            this.eşadı.SelectionLength = 0;
            this.eşadı.SelectionStart = 0;
            this.eşadı.Size = new System.Drawing.Size(223, 28);
            this.eşadı.TabIndex = 15;
            this.eşadı.TabStop = false;
            this.eşadı.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(442, 86);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 24);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Eş Adı:";
            // 
            // eştcno
            // 
            this.eştcno.Depth = 0;
            this.eştcno.Hint = "";
            this.eştcno.Location = new System.Drawing.Point(625, 129);
            this.eştcno.MaxLength = 32767;
            this.eştcno.MouseState = MaterialSkin.MouseState.HOVER;
            this.eştcno.Name = "eştcno";
            this.eştcno.PasswordChar = '\0';
            this.eştcno.SelectedText = "";
            this.eştcno.SelectionLength = 0;
            this.eştcno.SelectionStart = 0;
            this.eştcno.Size = new System.Drawing.Size(223, 28);
            this.eştcno.TabIndex = 17;
            this.eştcno.TabStop = false;
            this.eştcno.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(442, 133);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(163, 24);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Eş T.C. Kimlik No:";
            // 
            // kişisayısı
            // 
            this.kişisayısı.Depth = 0;
            this.kişisayısı.Hint = "";
            this.kişisayısı.Location = new System.Drawing.Point(625, 181);
            this.kişisayısı.MaxLength = 32767;
            this.kişisayısı.MouseState = MaterialSkin.MouseState.HOVER;
            this.kişisayısı.Name = "kişisayısı";
            this.kişisayısı.PasswordChar = '\0';
            this.kişisayısı.SelectedText = "";
            this.kişisayısı.SelectionLength = 0;
            this.kişisayısı.SelectionStart = 0;
            this.kişisayısı.Size = new System.Drawing.Size(223, 28);
            this.kişisayısı.TabIndex = 19;
            this.kişisayısı.TabStop = false;
            this.kişisayısı.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(442, 181);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(177, 24);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Handeki Kişi Sayısı:";
            // 
            // grub
            // 
            this.grub.Depth = 0;
            this.grub.Hint = "";
            this.grub.Location = new System.Drawing.Point(625, 232);
            this.grub.MaxLength = 32767;
            this.grub.MouseState = MaterialSkin.MouseState.HOVER;
            this.grub.Name = "grub";
            this.grub.PasswordChar = '\0';
            this.grub.SelectedText = "";
            this.grub.SelectionLength = 0;
            this.grub.SelectionStart = 0;
            this.grub.Size = new System.Drawing.Size(223, 28);
            this.grub.TabIndex = 21;
            this.grub.TabStop = false;
            this.grub.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(442, 232);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(130, 24);
            this.materialLabel11.TabIndex = 20;
            this.materialLabel11.Text = "Yardım Grubu:";
            // 
            // uyruk
            // 
            this.uyruk.Depth = 0;
            this.uyruk.Hint = "";
            this.uyruk.Location = new System.Drawing.Point(625, 280);
            this.uyruk.MaxLength = 32767;
            this.uyruk.MouseState = MaterialSkin.MouseState.HOVER;
            this.uyruk.Name = "uyruk";
            this.uyruk.PasswordChar = '\0';
            this.uyruk.SelectedText = "";
            this.uyruk.SelectionLength = 0;
            this.uyruk.SelectionStart = 0;
            this.uyruk.Size = new System.Drawing.Size(223, 28);
            this.uyruk.TabIndex = 23;
            this.uyruk.TabStop = false;
            this.uyruk.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(442, 280);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(73, 24);
            this.materialLabel12.TabIndex = 22;
            this.materialLabel12.Text = "Uyruğu:";
            // 
            // arşivno
            // 
            this.arşivno.Depth = 0;
            this.arşivno.Hint = "";
            this.arşivno.Location = new System.Drawing.Point(625, 329);
            this.arşivno.MaxLength = 32767;
            this.arşivno.MouseState = MaterialSkin.MouseState.HOVER;
            this.arşivno.Name = "arşivno";
            this.arşivno.PasswordChar = '\0';
            this.arşivno.SelectedText = "";
            this.arşivno.SelectionLength = 0;
            this.arşivno.SelectionStart = 0;
            this.arşivno.Size = new System.Drawing.Size(223, 28);
            this.arşivno.TabIndex = 25;
            this.arşivno.TabStop = false;
            this.arşivno.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(441, 329);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(144, 24);
            this.materialLabel13.TabIndex = 24;
            this.materialLabel13.Text = "Arşiv Numarası:";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(441, 376);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(164, 24);
            this.materialLabel14.TabIndex = 26;
            this.materialLabel14.Text = "Yardım Alıyor Mu?";
            // 
            // yardım
            // 
            this.yardım.AutoSize = true;
            this.yardım.Depth = 0;
            this.yardım.Font = new System.Drawing.Font("Roboto", 10F);
            this.yardım.Location = new System.Drawing.Point(625, 372);
            this.yardım.Margin = new System.Windows.Forms.Padding(0);
            this.yardım.MouseLocation = new System.Drawing.Point(-1, -1);
            this.yardım.MouseState = MaterialSkin.MouseState.HOVER;
            this.yardım.Name = "yardım";
            this.yardım.Ripple = true;
            this.yardım.Size = new System.Drawing.Size(111, 30);
            this.yardım.TabIndex = 27;
            this.yardım.Text = "Evet/Hayır";
            this.yardım.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(29, 461);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(108, 36);
            this.materialRaisedButton1.TabIndex = 28;
            this.materialRaisedButton1.Text = "Kayıt Ara";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(166, 461);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(99, 36);
            this.materialRaisedButton2.TabIndex = 29;
            this.materialRaisedButton2.Text = "Kayıt Sil";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(296, 461);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(106, 36);
            this.materialRaisedButton3.TabIndex = 30;
            this.materialRaisedButton3.Text = "Güncelle";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(425, 461);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(114, 36);
            this.materialRaisedButton4.TabIndex = 31;
            this.materialRaisedButton4.Text = "Kayıt Ekle";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 516);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.yardım);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.arşivno);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.uyruk);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.grub);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.kişisayısı);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.eştcno);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.eşadı);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.ibanno);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.babadı);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "İHH Otomasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField adsoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField tcno;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField dt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField babadı;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField telno;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField ibanno;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField adres;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField eşadı;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField eştcno;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField kişisayısı;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField grub;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField uyruk;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField arşivno;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialCheckBox yardım;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

