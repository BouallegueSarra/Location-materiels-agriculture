using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PROJET_PFA
{
    public partial class CONN_ADMIN : Form
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

        public CONN_ADMIN()
        {
            InitializeComponent();
        }

        private void CONNECTION_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

            try
            {
                conn.Open();
                MySqlCommand sc = new MySqlCommand("select * from administrateur where emailAdmin='" + textBox1.Text + "'and mdpAdmin= '" + textBox2.Text + "'", conn);
                sc.ExecuteNonQuery();
                MySqlDataReader dr = sc.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                conn.Close();
                if (count == 1)
                {
                    Interface_ADMIN a = new Interface_ADMIN();
                    a.Show();
                    this.Close();
                }
                if (count < 1)
                {
                    MessageBox.Show("DES INFORMATION INCORRECT‼");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AUTRE ERREUR !!!", MessageBoxButtons.OK );
                conn.Close();
            }





        }

        private void retour_Click(object sender, EventArgs e)
        {
            Accueil AC = new Accueil();
            AC.Show();
            this.Close();
        }
    }
}
