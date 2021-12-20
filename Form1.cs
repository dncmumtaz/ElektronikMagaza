using ElektronikMagaza;

namespace ElektronikMagaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler frmUrunler = new FrmUrunler();
            frmUrunler.ShowDialog();
        }


        private void btnMarkalar_Click(object sender, EventArgs e)
        {
            FrmMarkalar frmMarkalar = new FrmMarkalar();
            frmMarkalar.ShowDialog();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            FrmUyeler frmUyeler = new FrmUyeler();
            frmUyeler.ShowDialog();
        }

        private void btnMagazalar_Click(object sender, EventArgs e)
        {
            FrmMagazalar frmMagazalar = new FrmMagazalar();
            frmMagazalar.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategoriler frmKategoriler = new FrmKategoriler();
            frmKategoriler.ShowDialog();
        }

        private void btnUrunCesiti_Click(object sender, EventArgs e)
        {
            FrmUrunCesiti frmUrunCesiti = new FrmUrunCesiti();
            frmUrunCesiti.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}