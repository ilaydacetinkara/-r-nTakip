using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbEntitiyEntities db = new DbEntitiyEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();
            label5.Text = db.Tbl_Musterı.Count(x => x.DURUM == true).ToString();
            label7.Text = db.Tbl_Musterı.Count(x => x.DURUM == false).ToString();
            label11.Text = db.Tbl_Urun.Sum(y => y.STOK).ToString();
            label19.Text = db.Tbl_Satıs.Sum(z => z.FIYAT).ToString() + "TL";
            label13.Text = (from x in db.Tbl_Urun orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label15.Text = (from x in db.Tbl_Urun orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label9.Text = db.Tbl_Urun.Count(x => x.KATEGORI == 1).ToString();
            label23.Text = db.Tbl_Urun.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label17.Text = (from x in db.Tbl_Musterı select x.SEHIR).Distinct().Count().ToString();
            label21.Text = db.MARKAGETIR().FirstOrDefault();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
