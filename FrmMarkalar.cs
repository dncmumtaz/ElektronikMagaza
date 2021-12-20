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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbMagaza; user ID=postgres; password=1234");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from markalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into markalar(marka_id,markaad,markasehir) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from markalar where marka_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update markalar set markaad=@p2, markasehir=@p3  where marka_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from listeleserino()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into serino(serino_id,marka_id,urun_id) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtYayinevi.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from serino where serino_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update serino set marka_id=@p2, urun_id=@p3 where serino_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtYayinevi.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from markalar where marka_id=@p1", baglanti);
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
            NpgsqlCommand komut = new NpgsqlCommand("select * from serino where serino_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
