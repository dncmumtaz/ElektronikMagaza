
namespace ElektronikMagaza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnMarkalar = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnUrunCesiti = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMagazalar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeler
            // 
            this.btnUyeler.BackColor = System.Drawing.Color.Cyan;
            this.btnUyeler.Location = new System.Drawing.Point(999, 270);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(128, 91);
            this.btnUyeler.TabIndex = 18;
            this.btnUyeler.Text = "ÜYELER";
            this.btnUyeler.UseVisualStyleBackColor = false;
            this.btnUyeler.Click += new System.EventHandler(this.btnUyeler_Click);
            // 
            // btnMarkalar
            // 
            this.btnMarkalar.BackColor = System.Drawing.Color.Cyan;
            this.btnMarkalar.Location = new System.Drawing.Point(801, 38);
            this.btnMarkalar.Name = "btnMarkalar";
            this.btnMarkalar.Size = new System.Drawing.Size(128, 91);
            this.btnMarkalar.TabIndex = 17;
            this.btnMarkalar.Text = "MARKALAR";
            this.btnMarkalar.UseVisualStyleBackColor = false;
            this.btnMarkalar.Click += new System.EventHandler(this.btnMarkalar_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Cyan;
            this.btnUrunler.Location = new System.Drawing.Point(284, 38);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(128, 91);
            this.btnUrunler.TabIndex = 12;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnUrunCesiti
            // 
            this.btnUrunCesiti.BackColor = System.Drawing.Color.Cyan;
            this.btnUrunCesiti.Location = new System.Drawing.Point(541, 493);
            this.btnUrunCesiti.Name = "btnUrunCesiti";
            this.btnUrunCesiti.Size = new System.Drawing.Size(128, 91);
            this.btnUrunCesiti.TabIndex = 30;
            this.btnUrunCesiti.Text = "ÜRÜN ÇEŞİTLERİ";
            this.btnUrunCesiti.UseVisualStyleBackColor = false;
            this.btnUrunCesiti.Click += new System.EventHandler(this.btnUrunCesiti_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Cyan;
            this.btnKategori.Location = new System.Drawing.Point(284, 378);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(128, 91);
            this.btnKategori.TabIndex = 29;
            this.btnKategori.Text = "KATEGORİLER";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMagazalar
            // 
            this.btnMagazalar.BackColor = System.Drawing.Color.Cyan;
            this.btnMagazalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMagazalar.Location = new System.Drawing.Point(42, 270);
            this.btnMagazalar.Name = "btnMagazalar";
            this.btnMagazalar.Size = new System.Drawing.Size(128, 91);
            this.btnMagazalar.TabIndex = 28;
            this.btnMagazalar.Text = "MAGAZALAR";
            this.btnMagazalar.UseVisualStyleBackColor = false;
            this.btnMagazalar.Click += new System.EventHandler(this.btnMagazalar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Cyan;
            this.btnCikis.Location = new System.Drawing.Point(801, 378);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(128, 91);
            this.btnCikis.TabIndex = 31;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElektronikMagaza.Properties.Resources.bacccck;
            this.ClientSize = new System.Drawing.Size(1204, 596);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUrunCesiti);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnMagazalar);
            this.Controls.Add(this.btnUyeler);
            this.Controls.Add(this.btnMarkalar);
            this.Controls.Add(this.btnUrunler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elektronik Mağazaları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnMarkalar;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnUrunCesiti;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMagazalar;
        private System.Windows.Forms.Button btnCikis;
    }
}

