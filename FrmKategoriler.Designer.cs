
namespace ElektronikMagaza
{
    partial class FrmKategoriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnG�ncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKategoriler = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnG�ncelle1 = new System.Windows.Forms.Button();
            this.btnSil1 = new System.Windows.Forms.Button();
            this.btnEkle1 = new System.Windows.Forms.Button();
            this.btnListele1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAra2 = new System.Windows.Forms.Button();
            this.btnAra1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnG�ncelle
            // 
            this.btnG�ncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnG�ncelle.Location = new System.Drawing.Point(671, 134);
            this.btnG�ncelle.Name = "btnG�ncelle";
            this.btnG�ncelle.Size = new System.Drawing.Size(100, 23);
            this.btnG�ncelle.TabIndex = 106;
            this.btnG�ncelle.Text = "G�ncelle";
            this.btnG�ncelle.UseVisualStyleBackColor = false;
            this.btnG�ncelle.Click += new System.EventHandler(this.btnG�ncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Cyan;
            this.btnSil.Location = new System.Drawing.Point(671, 105);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 105;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnEkle.Location = new System.Drawing.Point(671, 76);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 104;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(511, 122);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 102;
            this.label2.Text = "Kategori Ad�:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(511, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 101;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Cyan;
            this.btnListele.Location = new System.Drawing.Point(671, 47);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 23);
            this.btnListele.TabIndex = 100;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Kategoriler ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(304, 220);
            this.dataGridView1.TabIndex = 98;
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(511, 496);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(100, 23);
            this.txtKitap.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Beige;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(405, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 140;
            this.label8.Text = "Kitap ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKategoriler
            // 
            this.txtKategoriler.Location = new System.Drawing.Point(511, 467);
            this.txtKategoriler.Name = "txtKategoriler";
            this.txtKategoriler.Size = new System.Drawing.Size(100, 23);
            this.txtKategoriler.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Beige;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(405, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 138;
            this.label9.Text = "Kategoriler ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(511, 438);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 23);
            this.txtKategori.TabIndex = 137;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Beige;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(405, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 136;
            this.label10.Text = "Kategori ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnG�ncelle1
            // 
            this.btnG�ncelle1.BackColor = System.Drawing.Color.Cyan;
            this.btnG�ncelle1.Location = new System.Drawing.Point(150, 496);
            this.btnG�ncelle1.Name = "btnG�ncelle1";
            this.btnG�ncelle1.Size = new System.Drawing.Size(100, 23);
            this.btnG�ncelle1.TabIndex = 135;
            this.btnG�ncelle1.Text = "G�ncelle";
            this.btnG�ncelle1.UseVisualStyleBackColor = false;
            this.btnG�ncelle1.Click += new System.EventHandler(this.btnG�ncelle1_Click);
            // 
            // btnSil1
            // 
            this.btnSil1.BackColor = System.Drawing.Color.Cyan;
            this.btnSil1.Location = new System.Drawing.Point(150, 467);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(100, 23);
            this.btnSil1.TabIndex = 134;
            this.btnSil1.Text = "Sil";
            this.btnSil1.UseVisualStyleBackColor = false;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // btnEkle1
            // 
            this.btnEkle1.BackColor = System.Drawing.Color.Cyan;
            this.btnEkle1.Location = new System.Drawing.Point(150, 438);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(100, 23);
            this.btnEkle1.TabIndex = 133;
            this.btnEkle1.Text = "Ekle";
            this.btnEkle1.UseVisualStyleBackColor = false;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // btnListele1
            // 
            this.btnListele1.BackColor = System.Drawing.Color.Cyan;
            this.btnListele1.Location = new System.Drawing.Point(150, 409);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(100, 23);
            this.btnListele1.TabIndex = 132;
            this.btnListele1.Text = "Listele";
            this.btnListele1.UseVisualStyleBackColor = false;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(695, 384);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(367, 220);
            this.dataGridView2.TabIndex = 131;
            // 
            // btnAra2
            // 
            this.btnAra2.BackColor = System.Drawing.Color.Cyan;
            this.btnAra2.Location = new System.Drawing.Point(150, 525);
            this.btnAra2.Name = "btnAra2";
            this.btnAra2.Size = new System.Drawing.Size(100, 23);
            this.btnAra2.TabIndex = 143;
            this.btnAra2.Text = "Ara";
            this.btnAra2.UseVisualStyleBackColor = false;
            this.btnAra2.Click += new System.EventHandler(this.btnAra2_Click);
            // 
            // btnAra1
            // 
            this.btnAra1.BackColor = System.Drawing.Color.Cyan;
            this.btnAra1.Location = new System.Drawing.Point(671, 163);
            this.btnAra1.Name = "btnAra1";
            this.btnAra1.Size = new System.Drawing.Size(100, 23);
            this.btnAra1.TabIndex = 142;
            this.btnAra1.Text = "Ara";
            this.btnAra1.UseVisualStyleBackColor = false;
            this.btnAra1.Click += new System.EventHandler(this.btnAra1_Click);
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::ElektronikMagaza.Properties.Resources.bacccck;
            this.ClientSize = new System.Drawing.Size(1074, 616);
            this.Controls.Add(this.btnAra2);
            this.Controls.Add(this.btnAra1);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKategoriler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnG�ncelle1);
            this.Controls.Add(this.btnSil1);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnG�ncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KATEGOR�LER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnG�ncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKitap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKategoriler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnG�ncelle1;
        private System.Windows.Forms.Button btnSil1;
        private System.Windows.Forms.Button btnEkle1;
        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAra2;
        private System.Windows.Forms.Button btnAra1;
    }
}