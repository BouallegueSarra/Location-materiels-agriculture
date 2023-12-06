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
    public partial class Inscription_CLIENT : Form
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

        public Inscription_CLIENT()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Accueil AC = new Accueil();
            AC.Show();
            this.Close();

        }


        //---------------------------------------------------------------


        private void Inscription_Click(object sender, EventArgs e)
        {
            try
            {

                //verifier si les champs vide
                if (textBox_nom.Text == "" || textBox_prenom.Text == "" || textBox_email.Text == "" || textBox_mdp.Text == "" || textBox_tel.Text == "" )
                {
                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBox_sexe.SelectedIndex == -1)
                {
                    MessageBox.Show("Sexe Client non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    conn.Open();

                    string insertquery = "INSERT INTO agrimateriel.client (nom,prenom,emailClient,mdpClient,telephone,sexe) VALUES ('" + textBox_nom.Text + "','" + textBox_prenom.Text + "','" + textBox_email.Text + "','" + textBox_mdp.Text + "','" + textBox_tel.Text + "','" + comboBox_sexe.SelectedItem.ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(insertquery,conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Votre inscription a effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CONN_UTILISATEUR CN = new CONN_UTILISATEUR();
                        CN.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre inscription est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "AUTRE ERREUR !!!", MessageBoxButtons.OK);
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CONN_UTILISATEUR CN = new CONN_UTILISATEUR();
            CN.Show();
            this.Close();
        }
    }
}
