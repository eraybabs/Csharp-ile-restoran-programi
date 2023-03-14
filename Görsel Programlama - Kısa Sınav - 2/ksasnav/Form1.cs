using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data;

using MySql.Data.MySqlClient;

namespace ksasnav

{
    public partial class Form1 : Form

    {

        MySqlDataReader dr;

        MySqlCommand cmd;

        MySqlConnection con;
        public Form1()

        {

            InitializeComponent();

            con = new MySqlConnection("Server = localhost; Database = spy; User = root; Pwd = ;");

        }

        private void button1_Click(object sender, EventArgs e)

        {

            string kullanici = textBox1.Text;

            string sifre = textBox2.Text;

            cmd = new MySqlCommand();

            con.Open();

            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Kullanicilar where kullanici_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";

            dr = cmd.ExecuteReader();

            if (dr.Read())

            {
                Form2 ff = new Form2();

                ff.Show();

                this.Hide();

            }

            else

            {

                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");

            }

            con.Close();

        }

    }

}