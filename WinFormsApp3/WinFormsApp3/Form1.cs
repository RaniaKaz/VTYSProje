using Npgsql;
using System.Data;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Odev2; user ID=postgres;" +
            "password=123456");
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int number;
            int.TryParse(textBox1.Text, out number);
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Siparis\" (\"Kod\", \"Tarih\", " +
                " \"RestoranKod\", \"MusteriTelNo\"," +
                "\"OdemeYontemi\") values (@p1,CURRENT_DATE,@p4,@p5,@p6)", baglanti);

            NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"SiparisYemek\" (\"YemekKod\", \"SiparisKod\") " +
                "values (@t1,@t2)", baglanti);


            komut.Parameters.AddWithValue("@p1", number);

            //komut.Parameters.AddWithValue("@p3", comboBox1.SelectedIndex.ToString());
            if (comboBox2.SelectedIndex != -1)
            {
                komut.Parameters.AddWithValue("@p4", 1);
            }
            else if (comboBox3.SelectedIndex != -1)
            {
                komut.Parameters.AddWithValue("@p4", 2);

            }
            else if (comboBox4.SelectedIndex != -1)
            {
                komut.Parameters.AddWithValue("@p4", 2);
            }
            komut.Parameters.AddWithValue("@p5", textBox2.Text);


            if (comboBox5.SelectedIndex == 0)
            {
                komut.Parameters.AddWithValue("@p6", 2);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                komut.Parameters.AddWithValue("@p6", 1);
            }

            komut1.Parameters.AddWithValue("@t2", number);
            if (comboBox2.SelectedIndex == 0)
            {
                komut1.Parameters.AddWithValue("@t1", 1);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                komut1.Parameters.AddWithValue("@t1", 2);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                komut1.Parameters.AddWithValue("@t1", 3);
            }
            if (comboBox4.SelectedIndex == 0)
            {
                komut1.Parameters.AddWithValue("@t1", 4);
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                komut1.Parameters.AddWithValue("@t1", 5);
            }
            if (comboBox5.SelectedIndex == 0)
            {
                komut1.Parameters.AddWithValue("@t1", 6);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                komut1.Parameters.AddWithValue("@t1", 7);
            }

            komut.ExecuteNonQuery();
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("siparis eklendi");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"Siparis\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "delete from \"Siparis\" where \"Kod\" = @p1";
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu, baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("siparis silindi");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update \"Siparis\" set \"OdemeYontemi\" = @p1 where " +
                "\"Kod\" = @p2";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            if (comboBox5.SelectedIndex == 0)
            {
                komut.Parameters.AddWithValue("@p1", 2);
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                komut.Parameters.AddWithValue("@p1", 1);
            }
            komut.Parameters.AddWithValue("@p2", int.Parse(textBox1.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncelleme islemi gerceklesti");

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select from \"Siparis\" where \"Kod\" = @p1";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
    }
}
