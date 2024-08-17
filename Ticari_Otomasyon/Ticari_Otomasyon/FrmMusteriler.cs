using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Ticari_Otomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        void sehirlistesi () 
            {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti()); 
            SqlDataReader dr = komut.ExecuteReader(); // komut kümesiyle ilişkilendirdik
            while(dr.Read())                         // okuma işlemi sürdüğü sürece
                {
                Cbİl.Properties.Items.Add(dr[0]);  // combabox eklediğinde önüne properties geliyor dr den gelen 0. indeks
                 }
            bgl.baglanti().Close();
            }


        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            temizle();

        }

        private void Cbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbİlçe.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER WHERE SEHIR = @P1",bgl.baglanti()); // SEÇİLEN İNDEX DEĞERİNDEN ŞEHİR BİLGİSİNİ ALIYORUZ
            komut.Parameters.AddWithValue("@p1",Cbİl.SelectedIndex + 1 ); // parametre1 cmİL in şeçilen indeksinden gelen değeri 1 arttırmamızın sebebi index başlangıcı c# da "0" sql de "1"
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) // dr komutu okuma işlemi yaptığı müddetçe 2. cmbox içine ekleme yapıcak 
            {
                Cbİlçe.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRESI,ADRES) VALUES ( @P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cbİl.Text);
            komut.Parameters.AddWithValue("@p8", Cbİlçe.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@p10", RchAdres.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBL_MUSTERILER Where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",TxtId.Text);
            komutsil.ExecuteNonQuery(); // TABLO ÜZERİNDE DEĞİŞİKLİK OLDUĞUNDA OLUYOR EKLE ,GÜNCELLER, SİL 
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //datarow da dr nesnesi türettik.Bu komuta gridcontrolde seçilen satırın veri değerini bu dr komutuna atadık dr nulldan farklı olduğu müdetçe bunu yap

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cbİl.Text = dr["IL"].ToString();
                Cbİlçe.Text = dr["ILCE"].ToString();
                TxtVergiD.Text = dr["VERGIDAIRESI"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }       
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTc.Text = "";
            RchAdres.Text = "";
            Cbİl.Text = "";
            Cbİlçe.Text = "";
            TxtVergiD.Text = "";
            RchAdres.Text = "";


        }


        private void BtnGüncelle_Click(object sender, EventArgs e)
        {



            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@P1, SOYAD=@P2, TELEFON=@P3, TELEFON2=@P4 ,TC=@P5 , MAIL=@P6, IL = @P7 , ILCE=@P8 , VERGIDAIRESI=@P9 , ADRES = @P10 where ID = @P11", bgl.baglanti());
            // where bütün alanlar güncellenmemesi için yapılıyor :&/

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cbİl.Text);
            komut.Parameters.AddWithValue("@p8", Cbİlçe.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@p10", RchAdres.Text);
            komut.Parameters.AddWithValue("@p11", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }



}






