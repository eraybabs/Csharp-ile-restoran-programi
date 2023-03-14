using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Data.SqlClient;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data;

using MySql.Data.MySqlClient;

namespace ksasnav

{
    public partial class Form3 : Form

    {

        MySqlDataReader dr;

        MySqlCommand cmd;

        MySqlConnection con;

        public Form3()

        {

            InitializeComponent();

            con = new MySqlConnection("Server=localhost;Database=spy;user=root;Pwd=;SslMode=none");

        }

        private void artirbtn_Click(object sender, EventArgs e)

        {

            string icecek_miktari = "0";

            string yiyecek_miktari = "0";

            string temizlik_miktari = "0";

            if (icecektxt.Text != "")

            {

                icecek_miktari = icecektxt.Text;

            }

            if (yiyecektxt.Text != "")

            {

                yiyecek_miktari = yiyecektxt.Text;

            }

            if (malzemetxt.Text != "")

            {

                temizlik_miktari = malzemetxt.Text;

            }

            con.Open();

            cmd = new MySqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "INSERT into stoklar (icecek, yiyecek, temizlik) VALUES (" + icecektxt.Text + ", " + yiyecektxt.Text + ", " + malzemetxt.Text + ");";
          
            cmd.ExecuteNonQuery();

            con.Close();

        }

        private void azaltbtn_Click(object sender, EventArgs e)

        {

            con.Open();

            cmd = new MySqlCommand();

            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO stoklar (icecek, yiyecek, temizlik) VALUES (-" + icecektxt.Text + ",- " + yiyecektxt.Text + ", -" + malzemetxt.Text + ")";

            cmd.ExecuteNonQuery();

            con.Close();

        }
        private void Form3_Load_1(object sender, EventArgs e)

        {
                listView1.View = View.Details;

                listView1.FullRowSelect = true;

                listView1.Columns.Add("yiyecek", 100);

                listView1.Columns.Add("içecek", 100);

                listView1.Columns.Add("temizlik", 100);

                listView1.Columns.Add("kayıt tarihi", 100);

                con = new MySqlConnection("Server=localhost;Database=spy;user=root;Pwd=;SslMode=none");

                cmd = new MySqlCommand();

            con.Open();

            cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM stoklar";

                dr = cmd.ExecuteReader();

                string yiyecekler;

                string icecekler;

                string temizlikler;

                string tarihler;

            string[] eray = new string[4];

            while (dr.Read())

                {

                    yiyecekler = dr.GetString(1);

                    icecekler = dr.GetString(2);

                    temizlikler = dr.GetString(3);

                    tarihler = dr.GetString(4);

                    eray[0] = yiyecekler;

                    eray[1] = icecekler;

                    eray[2] = temizlikler;

                    eray[3] = tarihler;

                    ListViewItem malzeme;

                     malzeme = new ListViewItem(eray);

                    listView1.Items.Add(malzeme);

                }

                con.Close();
            }

    }

    }