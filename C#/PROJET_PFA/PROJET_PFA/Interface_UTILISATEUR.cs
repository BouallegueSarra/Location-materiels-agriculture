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
    public partial class Interface_UTILISATEUR : Form
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

        public Interface_UTILISATEUR()
        {
            InitializeComponent();
        }

        //******************************** passer commande *****************************************

        private void vider()
        {
            nmat.Text = "";
            pheure.Text = "";
            datecomm.Value = DateTime.Now;
            hdebut.Text = "00:00:00";
            nbheure.Value = 6;
        }

        private void Interface_UTILISATEUR_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show(conn.State.ToString() + " : Bienvenue dans notre service ", "Etat: Connection valide", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter ! " + ex.ToString());
            }
        }

        private void NouvComm_Click(object sender, EventArgs e)
        {
            vider();
        }

        private bool rechercher_nmat(string s) //fonction qui permet de vérifier l'existence d'un client
        {
            bool p = false;
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select * from annoncemateriel where idMateriel='" + s + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;

            dr.Close();

            return p;
        }

        private void phmat_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.png;*.jpeg;*.bmp)| *.jpg; *.png; *.jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);

                }
            }
        }

        private void cherchmat_Click(object sender, EventArgs e)
        {
            if (nmat.Text == "")
                MessageBox.Show("Champ idCommande vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (rechercher_nmat(nmat.Text) == false)
            {

                MessageBox.Show("Materiel introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nmat.Focus();
                nmat.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from annoncemateriel where nomMateriel='" + nmat.Text + "' ";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    dr.Read();
                    pheure.Text = dr.GetString(7);

                }
                dr.Close();

            }
        }

        private void confcomm_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmat.Text == "" || rechercher_nmat(nmat.Text) == false)
                {
                    MessageBox.Show("Materiel introuvable, Saisir nom du matreil", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nmat.Focus();
                    nmat.SelectAll();
                }
                else if (hdebut.Text == "" || nbheure.Text == "")
                {
                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (datecomm.Value < DateTime.Now)//controle de saisir sur le date
                {
                    MessageBox.Show("verifier votre date, Champ invalide !!", "champ incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    /*
                    //manque fy requette prixtotal
                    MySqlCommand cmdaff = new MySqlCommand("select prixHeure*nbrHeure from annoncemateriel A, commande C where A.idMateriel='"+ textBox_idM.Text+ "' AND A.idClient='"+ textBox_idCL.Text+ "' ", conn);
                    MySqlDataReader datar = cmdaff.ExecuteReader();
                    MessageBox.Show("test non terminer");
                    if (datar.HasRows)
                    {
                        datar.Read(); // un seul client 
                        MessageBox.Show("test terminer");
                        int.TryParse(datar.GetString(0), out int PH);
                        int PT = datar.GetInt32(0);
                        textBox_PT.Text = PT.ToString();
                    }
                    datar.Close();
                    */
                    int x;
                    if (!int.TryParse(pheure.Text, out x))
                    {
                        MessageBox.Show("Problem du prix matriel ", "Erreur !!!", MessageBoxButtons.OK);
                        pheure.Text = "";
                    }

                    //string insertCOMMANDEquery = "INSERT INTO agrimateriel.commande(dateCommande, heureDebut, nbrHeure, prixTotal, idMateriel, idClient) select '" + datecomm.Text + "','" + hdebut.Text + "','" + nbheure.Value + "','" + x * nbheure.Value + "', m.idMateriel , c.idClient FROM annoncemateriel m, client c WHERE m.nomMateriel = '" + nmat.Text + "' AND c.emailClient = '" + textBox_address.Text + "' ";
                    string insertCOMMANDEquery = "INSERT INTO agrimateriel.commande (dateCommande,heureDebut,nbrHeure,prixTotal,idMateriel,idClient) select '" + datecomm.Text + "','" + hdebut.Text + "','" + nbheure.Value + "','" + x * nbheure.Value + "', idMateriel , idClient FROM annoncemateriel WHERE nomMateriel ='" + nmat.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(insertCOMMANDEquery, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Votre commande est passer effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre commande est perturbé", "Perturbation au cœur commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    vider();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //******************************** ajoute matriel *****************************************

        private void vider_mat_c()
        {
            idmat.Text = "";
            nommat.Text = "";
            catmat.Text = "";
            admat.Text = "";
            descmat.Text = "";
            datemat.Value = DateTime.Now;
            prixhmat.Text = "";
            comboBoxetatmat.SelectedIndex = -1;
            idc.Text = "";
            pmat.Image = null;
        }

        private void nouv_mat_c_Click(object sender, EventArgs e)
        {
            vider_mat_c();
        }

        private void pmat_Click(object sender, EventArgs e)//proc ajouter une photo dans le picturebox
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.png;*.jpeg;*.bmp)| *.jpg; *.png; *.jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);

                }
            }
        }

        private void ins_mat_c_Click(object sender, EventArgs e)
        {
            try
            {
                if (nommat.Text == "" || catmat.Text == "" || descmat.Text == "" || admat.Text == "" || datemat.Text == "" || prixhmat.Text == "" || idc.Text == "")
                {
                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBoxetatmat.SelectedIndex == -1)
                {
                    MessageBox.Show("etat non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pmat != null)
                {
                    string fnom = idmat.Text + ".jpg";
                    string dossier = "C:\\Users\\khouildi\\source\\repos\\PROJET_PFA\\image";
                    string Sy = System.IO.Path.Combine(dossier, fnom);
                }


                else
                {
                    //prob fel photo
                    string insertMATquery = "INSERT INTO agrimateriel.annoncemateriel (nomMateriel,categorie,description,adresse,photo,dateAjout,prixHeure,etat,idClient) VALUES ('" + nommat.Text + "','" + catmat.Text + "','" + descmat.Text + "','" + admat.Text + "','vide','" + datemat.Text + "','" + prixhmat.Text + "', '" + comboBoxetatmat.SelectedItem.ToString() + "','" + idc.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(insertMATquery, conn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Votre insertion a effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre insertion est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    vider_mat_c();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supp_mat_c_Click(object sender, EventArgs e)
        {
            if (idmat.Text == "")
            {
                MessageBox.Show("Champ idMatriel vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_nmat(idmat.Text) == false)//manque fy rech
            {

                MessageBox.Show("Materiel Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                idmat.Focus();
                idmat.SelectAll();
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("delete from annoncemateriel where idMateriel='{0}'", idmat.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Materiel bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nouv_mat_c.PerformClick();

                }

            }
        }

        private void cherch_mat_c_Click(object sender, EventArgs e)
        {
            if (idmat.Text == "")
                MessageBox.Show("Champ idMateriel vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_nmat(idmat.Text) == false)
            {

                MessageBox.Show("Materiel introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                idmat.Focus();
                idmat.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from annoncemateriel where idMateriel='" + idmat.Text + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    dr.Read(); // un seul client 
                    //textBox_nomC.Text = dr.GetString(1);

                    nommat.Text = dr.GetString(1);
                    catmat.Text = dr.GetString(2);
                    descmat.Text = dr.GetString(3);
                    admat.Text = dr.GetString(4);

                    ////photo_MAT.Image = null; //dr.GetString(5); 
                    //byte[] img= null;
                    //if (dr.GetString(5) != null)
                    //{
                    //    string photo_MAT = (string)dr[5];
                    //}
                    //else
                    //{
                    //    //MemoryStream ms = new MemoryStream(img);
                    //    //photo_MAT.Image = Image.FormStream(ms);
                    //    MessageBox.Show("image non valide..!!!");
                    //}

                    datemat.Value = dr.GetDateTime(6);
                    prixhmat.Text = dr.GetString(7); ;
                    comboBoxetatmat.SelectedIndex = dr.GetInt32(8); ;
                    idc.Text = dr.GetString(9);

                }
                dr.Close();
            }
        }

        private void modif_mat_c_Click(object sender, EventArgs e)
        {
            if (nommat.Text == "" || catmat.Text == "" || admat.Text == "" || descmat.Text == "" || prixhmat.Text == "" || idc.Text == "")
            {

                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboBoxetatmat.SelectedIndex == -1)
            {
                MessageBox.Show("Type etat non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //else if (pmat.Image == null)
            //{
            //    MessageBox.Show("photo non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            else if (!rechercher_nmat(idmat.Text))
            {
                MessageBox.Show("Materiel Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                idmat.Focus();
                idmat.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("update annoncemateriel set nomMateriel='" + nommat.Text + "',categorie='" + catmat.Text + "',description='" + descmat.Text + "',adresse='" + admat.Text + "',dateAjout='" + this.datemat.Text + "',prixHeure='" + prixhmat.Text + "',etat = '" + comboBoxetatmat.SelectedItem.ToString() + "', idClient='" + idc.Text + "' where idMateriel='" + idmat.Text + "'");
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Materiel bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Déconnection_Click(object sender, EventArgs e)
        {
            CONN_UTILISATEUR U = new CONN_UTILISATEUR();
            U.Show();
            conn.Close();
            this.Hide();
        }
    }
}