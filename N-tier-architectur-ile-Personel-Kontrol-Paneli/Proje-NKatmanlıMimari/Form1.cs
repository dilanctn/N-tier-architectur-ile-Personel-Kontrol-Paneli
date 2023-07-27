using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_DataAccessLayer;//
using EntityLayerr;//
using LogicLayer;//


namespace Proje_NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TXTAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehır.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            ent.Gorev = TxtGorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtID.Text);
            ent.Ad = TXTAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehır.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            ent.Gorev = TxtGorev.Text;
            LogicPersonel.LLPersonelGuncelle(ent);
        }
    }
}
