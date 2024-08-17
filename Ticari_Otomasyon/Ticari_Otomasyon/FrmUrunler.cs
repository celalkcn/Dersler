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
using System.Security;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi(); // bağlantı adersini çağırdık
        void listele()                           // geriye değer döndürmeyen bir metod
        {
            DataTable dt = new DataTable();      // datatable sınıfından dt ismiyle bir nesne türettik
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti()); // ürünler tablosundan çek şartım yok , bgl.bağlantıyla ilişkilendirdik
            da.Fill(dt);                             //  da nın için dt ile doldur
            gridControl1.DataSource = dt;       // gridcontrol1. DataSource dt den gelen değer oldu 

        }


        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();                          // listele metodunu çağırmış olduk en son adım
            temizle();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        void temizle() {
            TxtAd.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskYıl.Text = "";
            NudAdet.Value = 0;
            TxtAlış.Text = "";
            TxtSatış.Text = "";
            RchDetay.Text = "";
            TxtId.Text = "";


        }

        private void BtnKaydet_Click(object sender, EventArgs e) // verileri kaydetme   
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNADI,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYıl.Text);
            komut.Parameters.AddWithValue("@p5",int.Parse(NudAdet.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlış.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatış.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery(); // DML komutlarını çalıştırıyor
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); // 1. parametre içerik  2. paramere başlık 3.paremetre message da kullanıcağımız button 4. parametre ise icon bilgilendirme 
            listele(); // en son da verilerimizi listeleyelim
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_URUNLER where ID=@p1",
                bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi" , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNADI"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYıl.Text = dr["YIL"].ToString();
            NudAdet.Value =decimal.Parse( dr["ADET"].ToString());
            TxtAlış.Text = dr["ALISFIYAT"].ToString();
            TxtSatış.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();



        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNADI=@P1, MARKA=@P2, MODEL=@P3,YIL=@P4, ADET=@P5, ALISFIYAT=@P6 ,SATISFIYAT=@P7, DETAY=@P8  WHERE ID = @P9 ", 
                bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYıl.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlış.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatış.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.Parameters.AddWithValue("@p9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // 1. parametre içerik  2. paramere başlık 3.paremetre message da kullanıcağımız button 4. parametre ise icon bilgilendirme 
            listele();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
