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
    public partial class CONN_UTILISATEUR : Form
    {
        public CONN_UTILISATEUR()
        {
            InitializeComponent();
        }

        private void CONN_UTILISATEUR_Load(object sender, EventArgs e)
        {

        }

        //connecter a un compte utilisateur
        private void CONNECTION_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

            try
            {
                conn.Open();
                MySqlCommand sc = new MySqlCommand("select * from client where emailClient='" + textBox_address.Text + "'and mdpClient= '" + textBox_mdp.Text + "'", conn);
                sc.ExecuteNonQuery();
                MySqlDataReader dr = sc.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    Interface_UTILISATEUR I_UT = new Interface_UTILISATEUR();
                    Accueil AC = new Accueil();
                    I_UT.Show();
                    AC.Close();
                    this.Close();
                }
                if (count < 1)
                {
                    MessageBox.Show("Verifier votre coordonnée‼");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
            

        }

        //creer compte utilisateur
        private void creer_compte_Click(object sender, EventArgs e)
        {

            Inscription_CLIENT Insc_C = new Inscription_CLIENT();
            Insc_C.Show();
            this.Close();

        }


        //retour pour choisier qui se connecte
        private void retour_Click(object sender, EventArgs e)
        {
            Accueil AC = new Accueil();
            AC.Show();
            this.Close();

        }

        private void MOT_DE_PASS_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
