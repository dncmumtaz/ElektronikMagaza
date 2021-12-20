
namespace ElektronikMagaza
{
    partial class FrmUrunCesiti
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
            this.btnGüncelle = new System.Windows.Forms.Button();
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
            this.txtBasim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGüncelle1 = new System.Windows.Forms.Button();
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
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnGüncelle.Location = new System.Drawing.Point(770, 126);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGüncelle.TabIndex = 97;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Cyan;
            this.btnSil.Location = new System.Drawing.Point(770, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 96;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnEkle.Location = new System.Drawing.Point(770, 68);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 95;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(601, 113);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "Ürün Çeþiti:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(601, 84);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 92;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Cyan;
            this.btnListele.Location = new System.Drawing.Point(770, 39);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 23);
            this.btnListele.TabIndex = 91;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "Ürün Çeþiti ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(360, 200);
            this.dataGridView1.TabIndex = 89;
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(601, 535);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(100, 23);
            this.txtKitap.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Beige;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(495, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 107;
            this.label8.Text = "Ürün ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBasim
            // 
            this.txtBasim.Location = new System.Drawing.Point(601, 506);
            this.txtBasim.Name = "txtBasim";
            this.txtBasim.Size = new System.Drawing.Size(100, 23);
            this.txtBasim.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Beige;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(495, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 105;
            this.label9.Text = "Ürün Çeþiti ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(601, 477);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 23);
            this.txtTur.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Beige;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(495, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 103;
            this.label10.Text = "Ürün Çeþiti ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGüncelle1
            // 
            this.btnGüncelle1.BackColor = System.Drawing.Color.Cyan;
            this.btnGüncelle1.Location = new System.Drawing.Point(272, 534);
            this.btnGüncelle1.Name = "btnGüncelle1";
            this.btnGüncelle1.Size = new System.Drawing.Size(100, 23);
            this.btnGüncelle1.TabIndex = 102;
            this.btnGüncelle1.Text = "Güncelle";
            this.btnGüncelle1.UseVisualStyleBackColor = false;
            this.btnGüncelle1.Click += new System.EventHandler(this.btnGüncelle1_Click);
            // 
            // btnSil1
            // 
            this.btnSil1.BackColor = System.Drawing.Color.Cyan;
            this.btnSil1.Location = new System.Drawing.Point(272, 505);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(100, 23);
            this.btnSil1.TabIndex = 101;
            this.btnSil1.Text = "Sil";
            this.btnSil1.UseVisualStyleBackColor = false;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // btnEkle1
            // 
            this.btnEkle1.BackColor = System.Drawing.Color.Cyan;
            this.btnEkle1.Location = new System.Drawing.Point(272, 476);
            this.btnEkle1.Name = "btnEkle1";
            this.btnEkle1.Size = new System.Drawing.Size(100, 23);
            this.btnEkle1.TabIndex = 100;
            this.btnEkle1.Text = "Ekle";
            this.btnEkle1.UseVisualStyleBackColor = false;
            this.btnEkle1.Click += new System.EventHandler(this.btnEkle1_Click);
            // 
            // btnListele1
            // 
            this.btnListele1.BackColor = System.Drawing.Color.Cyan;
            this.btnListele1.Location = new System.Drawing.Point(272, 447);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(100, 23);
            this.btnListele1.TabIndex = 99;
            this.btnListele1.Text = "Listele";
            this.btnListele1.UseVisualStyleBackColor = false;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(770, 424);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(360, 200);
            this.dataGridView2.TabIndex = 98;
            // 
            // btnAra2
            // 
            this.btnAra2.BackColor = System.Drawing.Color.Cyan;
            this.btnAra2.Location = new System.Drawing.Point(272, 563);
            this.btnAra2.Name = "btnAra2";
            this.btnAra2.Size = new System.Drawing.Size(100, 23);
            this.btnAra2.TabIndex = 134;
            this.btnAra2.Text = "Ara";
            this.btnAra2.UseVisualStyleBackColor = false;
            this.btnAra2.Click += new System.EventHandler(this.btnAra2_Click);
            // 
            // btnAra1
            // 
            this.btnAra1.BackColor = System.Drawing.Color.Cyan;
            this.btnAra1.Location = new System.Drawing.Point(770, 155);
            this.btnAra1.Name = "btnAra1";
            this.btnAra1.Size = new System.Drawing.Size(100, 23);
            this.btnAra1.TabIndex = 133;
            this.btnAra1.Text = "Ara";
            this.btnAra1.UseVisualStyleBackColor = false;
            this.btnAra1.Click += new System.EventHandler(this.btnAra1_Click);
            // 
            // FrmUrunCesiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ElektronikMagaza.Properties.Resources.bacccck;
            this.ClientSize = new System.Drawing.Size(1158, 645);
            this.Controls.Add(this.btnAra2);
            this.Controls.Add(this.btnAra1);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBasim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGüncelle1);
            this.Controls.Add(this.btnSil1);
            this.Controls.Add(this.btnEkle1);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUrunCesiti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunCesiti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunCesiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
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
        private System.Windows.Forms.TextBox txtBasim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGüncelle1;
        private System.Windows.Forms.Button btnSil1;
        private System.Windows.Forms.Button btnEkle1;
        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAra2;
        private System.Windows.Forms.Button btnAra1;
    }
}