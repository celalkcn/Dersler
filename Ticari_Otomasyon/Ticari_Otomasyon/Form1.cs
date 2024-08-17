using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        FrmBankalar fr7 = new FrmBankalar();
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            {
                if (fr7 == null || fr7.IsDisposed)

                    fr7 = new FrmBankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FrmUrunler ar;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (ar == null || ar.IsDisposed)

                    ar = new FrmUrunler();
                ar.MdiParent = this;
                ar.Show();
            }
        }

        FrmPersonel fp;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (fp == null || fp.IsDisposed)
                    fp = new FrmPersonel();
                fp.MdiParent = this;
                fp.Show();
            }

        }
        FrmMusteriler ff;
        private void BtnMusterıler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (ff == null || ff.IsDisposed)
                    ff = new FrmMusteriler();
                ff.MdiParent = this;
                ff.Show();
            }



        }



        FrmFirmalar cc;

        private void BtnFırmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {  if (cc == null || cc.IsDisposed)
                    cc = new FrmFirmalar();
            cc.MdiParent = this;
            cc.Show();
            }
        }
        FrmRehber fr5;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (fr5 == null || fr5.IsDisposed)
                    fr5 = new FrmRehber();
                fr5.MdiParent = this;
                fr5.Show();
            }

        }
        FrmGiderler fr6;
        private void BtnGıderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (fr6 == null || fr6.IsDisposed)
                    fr6 = new FrmGiderler();
                fr6.MdiParent = this;
                fr6.Show();
            }

        }
        FrmFaturalar Fr8;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            {
                if (Fr8 == null || Fr8.IsDisposed)
                    Fr8 = new FrmFaturalar();
                Fr8.MdiParent = this;
                Fr8.Show();
            }



        }
    }
}
