using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace ksasnav

{
    public partial class Form2 : Form

    {
        public Form2()

        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
