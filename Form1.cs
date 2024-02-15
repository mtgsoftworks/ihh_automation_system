using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Data.SQLite;
using System.IO;

namespace İHH_Otomasyon_Sistemi
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;

        public Form1()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
           //DataGridView doldur
            GetList();
        }
        void GetList()
        {
            con = new SQLiteConnection("Data Source= " + Application.StartupPath + "\\Database\\database.db;Version=3;");
            da = new SQLiteDataAdapter("Select *From personal_information", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personal_information");
            dataGridView1.DataSource = ds.Tables["personal_information"];
            con.Close();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into personal_information(adsoyad,tcno,dt,babadi,telno,ibanno,adres,eşadi,eştcno,kişisayısı,grup,uyruk,arşivno,yardım) Values ('" + adsoyad.Text + "','" + tcno.Text + "','" + dt.Text + "','" + babadı.Text + "','" + telno.Text + "','" + ibanno.Text + "','" + adres.Text + "','" + eşadı.Text + "','" + eştcno.Text + "','" + kişisayısı.Text + "','" + grub.Text + "','" + uyruk.Text + "','" + arşivno.Text + "','" + yardım.CheckState.ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                GetList(); 
                
                MessageBox.Show("Kayıt Tamamlandı!", "İHH Otomasyon Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                if (adsoyad.Text != "" && tcno.Text != "" && dt.Text != "" && babadı.Text != "" && telno.Text != "" && ibanno.Text != "" && adres.Text != "" && eşadı.Text != "" && eştcno.Text != "" && kişisayısı.Text != "" && grub.Text != "" && uyruk.Text != "" && arşivno.Text != "")
                {
                    
                }
                else
                {
                    MessageBox.Show("Boş alan geçmeyiniz!", "İHH Otomasyon Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.ToString());
            }
            
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)///güncelle
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Into personal_information set adsoyad='" + adsoyad.Text + "', tcno='" + tcno.Text + "', dt='" + dt.Text + "', babadı='" + babadı.Text + "', telno='" + telno.Text + "', ibanno='" + ibanno.Text + "', adres='" + adres.Text + "', eşadı='" + eşadı.Text + "' , eştcno='" + eştcno.Text + "' , grup='" + grub.Text + "', uyruk='" + uyruk.Text + "', arşivno='" + arşivno.Text + "', where tcno=" + tcno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();           
            MessageBox.Show("Kayıt Güncellendi");
            ds.Clear();
          
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)///kayıt sil
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show( tcno.Text +" no'lu Kişiyi Silmek İstediğnizden Emin Misiniz?", "İHH Otomasyon Sistemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from personal_information where tcno=" + tcno.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();              
            }
           
        }
    }
}
