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

namespace Ticari_Otomasyon
{
    public partial class FrmFaturalar : Form
    {

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select* from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridControl1.DataSource = dt;   

        }

        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            

            }

        void Temizle()
        {
            TxtAlıcı.Text = "";
            TxtId.Text = "";
            Txtserino.Text = "";
            TxtSırano.Text = "";
            TxtTeslimalan.Text = "";
            TxtTeslimeden.Text = "";
            TxtVergid.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["FATURABILGIID"].ToString();
                TxtSırano.Text = dr["SIRANO"].ToString();
                Txtserino.Text = dr["SERI"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtAlıcı.Text = dr["ALICI"].ToString();
                TxtTeslimeden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimalan.Text = dr["TESLIMALAN"].ToString();
                TxtVergid.Text = dr["VERGIDAIRESI"].ToString();
            }


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM TBL_FATURABILGI WHERE FATURABILGIID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRESI=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 WHERE FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", Txtserino.Text);
            komut.Parameters.AddWithValue("@P2", TxtSırano.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.Parameters.AddWithValue("@P5", TxtVergid.Text);
            komut.Parameters.AddWithValue("@P6", TxtAlıcı.Text);
            komut.Parameters.AddWithValue("@P7", TxtTeslimeden.Text);
            komut.Parameters.AddWithValue("@P8", TxtTeslimalan.Text);
            komut.Parameters.AddWithValue("@P9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.id= dr["FATURABILGIID"].ToString();
            }
            fr.Show();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtFaturaıd.Text == "")
            {

                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRESI,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", Txtserino.Text);
                komut.Parameters.AddWithValue("@P2", TxtSırano.Text);
                komut.Parameters.AddWithValue("@P3", MskTarih.Text);
                komut.Parameters.AddWithValue("@P4", MskSaat.Text);
                komut.Parameters.AddWithValue("@P5", TxtVergid.Text);
                komut.Parameters.AddWithValue("@P6", TxtAlıcı.Text);
                komut.Parameters.AddWithValue("@P7", TxtTeslimeden.Text);
                komut.Parameters.AddWithValue("@P8", TxtTeslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (TxtFaturaıd.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtÜrünıd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaıd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
    }
}
