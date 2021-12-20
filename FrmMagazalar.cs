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
    public partial class FrmMagazalar : Form
    {
        public FrmMagazalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbMagaza; user ID=postgres; password=1234");

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from magazalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into magazalar(magazalar_id,magazaad,magazasehir) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mağaza Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from magazalar where magazalar_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mağaza Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update magazalar set magazaad=@p2, magazasehir=@p3  where magazalar_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mağaza Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from listelemagaza()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into magaza(magaza_id,magazalar_id,urun_id) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtKutuphane.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtKutuphaneler.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from magaza where magaza_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKutuphane.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update magaza set magazalar_id=@p2, urun_id=@p3 where magaza_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtKutuphane.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtKutuphane.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from magazalar where magazalar_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnAra2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from magaza where magaza_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtKutuphane.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
