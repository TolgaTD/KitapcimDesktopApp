using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kitapcim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Veri tabanı bağlantısı oluşturdum
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\kitapcim.mdb");

        

        void listele()//Listele butonunu kullanmak üzere geriye değer döndürmeyen bir metod yazdım
        {
            // Listele butonuna basıldığı zaman Kitaplar isimli Tablo tüm verileriyle ekrana yazdırılacak
            DataTable dt = new DataTable(); // dt isimli bir veri tablosu oluşturdum
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt; //DataGridView nesnesine kaynak olarak dt'yi gösterdim
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            listele(); 
            
            // Listele butonuna basıldığı takdirde Listele metodu aktifleşecek ve veritabanındaki
            // kitapları bilgileriyle birlikte listeleyecek
        }

        string stok = "";
        private void button_kaydet_Click(object sender, EventArgs e)
        {

            
            baglanti.Open(); // Veri tabanı bağlantısını açtım
            string query = $"insert into kitaplar(kitapAd,yazar,tur,sayfa,stok,resim) values " +
            $"('{textBoxAD.Text}','{textBoxYAZAR.Text}','{comboBoxTUR.Text}','{textBoxSAYFA.Text}','{stok}'," +
            $"'{textBoxResim.Text}')";
            OleDbCommand kaydet = new OleDbCommand(query, baglanti); //kaydet işlevini oluşturdum
            kaydet.ExecuteNonQuery();//Sorguyu çalıştırdım
            baglanti.Close();//bağlantıyı kapattım
            MessageBox.Show("İşlem Başarılı, Kitap Sisteme Kaydedildi!",
            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//mesaj kutusuyla bilgi verdim
            listele();
        }

        private void stok_var_CheckedChanged(object sender, EventArgs e)
        {
            stok = "1";
        }

        private void stok_yok_CheckedChanged(object sender, EventArgs e)
        {
            stok = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            //DataGridView'de listelenen hücrelerden birine tıkladığımızda o hücrenin
            //bulunduğu satırdaki bilgileri araçlara getirmek için yazdığım kod bloğu

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxYAZAR.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxTUR.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxSAYFA.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxResim.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            pictureBox2.ImageLocation = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                stok_var.Checked = true;
            }

            else
            {
                stok_yok.Checked = true;
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {  
            //Veri tabanına eklediğim kitapları silmek için yazdığım kod bloğu

            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("Delete from kitaplar where kitapid=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", textBoxID.Text); ;
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçtiğiniz kitap başarıyla silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void button_guncelle_Click(object sender, EventArgs e)
        { 
            //Veri tabanında var olan kitapların çeşitli bilgilerini değiştirmek ve güncellemek için yazdığım kod bloğu

            baglanti.Open();
            var stok = 0;
            if (stok_var.Checked == true)
            stok = 1;
            string query = $"UPDATE kitaplar set kitapAd='{textBoxAD.Text.Replace("'","''")}'" +
            $",yazar='{textBoxYAZAR.Text}',tur='{comboBoxTUR.Text}',sayfa={textBoxSAYFA.Text},stok={stok}" +
            $",resim='{textBoxResim.Text}' where kitapid={Convert.ToInt32(textBoxID.Text)}";
            OleDbCommand guncelle2 = new OleDbCommand(query, baglanti);
            guncelle2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlanmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void buttonbul_Click(object sender, EventArgs e)
        {
            //Kitabın tam ismini yazarak bulabileceğimiz arama butonunun kod bloğu

            baglanti.Open();
            OleDbCommand bul = new OleDbCommand($"Select * From kitaplar Where kitapAd='{textboxara.Text}'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void buttonbul2_Click(object sender, EventArgs e)
        {
            //kitabın isminin birkaç harfini yazarak bulabileceğimiz arama butonunun kod bloğu

            baglanti.Open();
            OleDbCommand bul = new OleDbCommand("Select * From kitaplar Where kitapAd Like '%" + textboxara.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(bul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resim seçme butonunun kod bloğu, seçilen resmin yolunu textbox'a ekliyor

            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            textBoxResim.Text = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            //Temizleme butonunun kod bloğu, basıldığı takdirde seçili ve yazılı tüm bilgileri temizliyor 

            textBoxAD.Text = "";
            textBoxResim.Text = "";
            textBoxSAYFA.Text = "";
            textBoxYAZAR.Text = "";
            comboBoxTUR.SelectedIndex = 0;
            stok_var.Checked = false;
            stok_yok.Checked = false;
            pictureBox2.Image = null;
            textBoxID.Text = "";
        }
    }
}
