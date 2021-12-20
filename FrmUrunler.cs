using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElektronikMagaza
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbMagaza; user ID=postgres; password=1234");

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from viewurunlar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into urunlar(urun_id,barkod,urunAd,teshir_id) values(@p1,@p2,@p3,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtBarkod.Text));
            komut1.Parameters.AddWithValue("@p3", txtKitapad.Text);
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtDurumid.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from urunlar where urun_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update urunlar set barkod=@p2, urunAd=@p3,teshir_id=@p6  where urun_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtBarkod.Text));
            komut3.Parameters.AddWithValue("@p3", txtKitapad.Text);
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtDurumid.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from urunlar where urun_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
