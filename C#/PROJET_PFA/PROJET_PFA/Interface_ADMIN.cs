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
using System.IO;

namespace PROJET_PFA
{
    public partial class Interface_ADMIN : Form
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=agrimateriel");

        public Interface_ADMIN()
        {
            InitializeComponent();
        }

        private void Interface_ADMIN_Load(object sender, EventArgs e)//tantque l'interface_ADMIN charger toutes les dataGrid sa va lancé 
        {
            try
            {
                conn.Open();
                MessageBox.Show(conn.State.ToString() + " : Vous pouver manipuler toutes", "Etat: Connection valide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualiserADMIN();
                actualiser();
                actualiser_COMMANDE();
                actualiser_MAT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter ! " + ex.ToString());
            }
        }



        private void Déconnection_Click(object sender, EventArgs e)
        {
            CONN_ADMIN A = new CONN_ADMIN();
            Interface_ADMIN IA = new Interface_ADMIN();
            A.Show();
            conn.Close();
            this.Hide(); //this.Close();
            //Application.Exit();            
        }


        // *************************************** Gestion de Client *************************************************


        private void actualiser()   //procédure qui permet de charger le contenu de la table client dans le Datagridview
        {
            MySqlCommand cmd = new MySqlCommand("select * from client", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_CL.DataSource = dt;
            dr.Close();

        }


        private void Inserter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_nomC.Text == "" || textBox_prenomC.Text == "" || textBox_emailC.Text == "" || textBox_mdpC.Text == "" || textBox_telC.Text == "")
                {
                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBox_sexeC.SelectedIndex == -1)
                {
                    MessageBox.Show("Type Client non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                else
                {

                    string insertquery = "INSERT INTO agrimateriel.client (nom,prenom,emailClient,mdpClient,telephone,sexe) VALUES ('" + textBox_nomC.Text + "','" + textBox_prenomC.Text + "','" + textBox_emailC.Text + "','" + textBox_mdpC.Text + "','" + textBox_telC.Text + "','" + comboBox_sexeC.SelectedItem.ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(insertquery, conn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Votre insertion a effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre insertion est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    actualiser();
                    viderCLIENT();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            viderCLIENT();
        }

        private void viderCLIENT() //fonction qui permet de vider les champs
        {
            textBox_idClient.Text = "";
            textBox_nomC.Text = "";
            textBox_prenomC.Text = "";
            textBox_emailC.Text = "";
            textBox_mdpC.Text = "";
            textBox_telC.Text = "";
            comboBox_sexeC.SelectedIndex = -1;
        }

        private bool rechercher_id(string s) //fonction qui permet de vérifier l'existence d'un client
        {

            bool p = false; int x;
            if (!int.TryParse(s, out x))
            {
                MessageBox.Show("saisir un idClient entier", "Erreur de type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_idClient.Text = "";
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "select * from client where idClient='" + x + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    p = true;

                dr.Close();
            }
            return p;
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (textBox_idClient.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ CIN vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_id(textBox_idClient.Text) == false) // vérification de l'existence du client dont le idClient est saisi dans la zone idClient
            {

                MessageBox.Show("Client Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idClient.Focus();
                textBox_idClient.SelectAll(); //selectionner le champ idClient pour une éventuelle resaisie
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("delete from client where idClient='{0}'", textBox_idClient.Text);
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Client bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nouveau.PerformClick(); //appeler le bouton nouveau pour vider les champs

                    actualiser();
                }

            }
        }

        private void Chercher_Click(object sender, EventArgs e)
        {
            if (textBox_idClient.Text == "")
                MessageBox.Show("Champ idClient vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_id(textBox_idClient.Text) == false)
            {

                MessageBox.Show("Client introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idClient.Focus();
                textBox_idClient.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from client where idClient='" + textBox_idClient.Text + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    dr.Read(); // un seul client 
                    textBox_nomC.Text = dr.GetString(1); // = dr[1].toString()
                    textBox_prenomC.Text = dr[2].ToString();
                    textBox_emailC.Text = dr[3].ToString();
                    textBox_mdpC.Text = dr[4].ToString();
                    textBox_telC.Text = dr[5].ToString();
                    comboBox_sexeC.SelectedItem = dr[6].ToString();

                }
                dr.Close();
                actualiser();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (textBox_nomC.Text == "" || textBox_prenomC.Text == "" || textBox_emailC.Text == "" || textBox_mdpC.Text == "" || textBox_telC.Text == "")
            {

                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rechercher_id(textBox_idClient.Text)) // vérification de l'existence du client dont le id est saisi dans la zone idClient
            {
                MessageBox.Show("Client Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idClient.Focus();
                textBox_idClient.SelectAll(); //selectionner le champ idClient pour une éventuelle resaisie
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("update client set nom='" + textBox_nomC.Text + "',prenom='" + textBox_prenomC.Text + "',emailClient='" + textBox_emailC.Text + "',mdpClient='" + textBox_mdpC.Text + "', telephone='" + textBox_telC.Text + "', sexe='" + comboBox_sexeC.SelectedItem.ToString() + "'where idClient='" + textBox_idClient.Text + "'");
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Client bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualiser();
                }
            }


        }


        // *************************************** Gestion d'Admin *************************************************


        private void viderADMIN() //fonction qui permet de vider les champs dans l'interface admin
        {
            textBox_idA.Text = "";
            textBox_idA.Select();
            textBox_nomA.Text = "";
            textBox_prenomA.Text = "";
            textBox_emailA.Text = "";
            textBox_mdpA.Text = "";

        }

        //BTN QUI Rremttre tout les champ a zero
        private void NouveauA_Click(object sender, EventArgs e)
        {
            viderADMIN();
        }

        private void actualiserADMIN()   //procédure qui permet de charger le contenu de la table Admin dans le Datagridview
        {
            MySqlCommand cmd = new MySqlCommand("select * from administrateur", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_ADMIN.DataSource = dt;
            dr.Close();

        }

        private void InserterA_Click(object sender, EventArgs e)
        {
            if (textBox_idA.Text == "" || textBox_nomA.Text == "" || textBox_prenomA.Text == "" || textBox_emailA.Text == "" || textBox_mdpA.Text == "")
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    string insertADMINquery = "INSERT INTO agrimateriel.administrateur (idAdmin,nomAdmin,prenomAdmin,emailAdmin,mdpAdmin) VALUES ('" + textBox_idA.Text + "','" + textBox_nomA.Text + "','" + textBox_prenomA.Text + "','" + textBox_emailA.Text + "','" + textBox_mdpA.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(insertADMINquery, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Votre insertion a effectué avec succès ", "Nouveau Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre insertion est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    actualiserADMIN();
                    viderADMIN();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "changé idAdmin, ce qui vous insreré est déja existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool rechercher_idADMIN(string s) //fonction qui permet de vérifier l'existence d'un Admin
        {
            bool p = false; int x;

            if (!int.TryParse(s, out x))
            {
                MessageBox.Show("saisir un idAdmin entier", "Erreur de type", MessageBoxButtons.OK);
                textBox_idA.Text = "";
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "select * from administrateur where idAdmin='" + x + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    p = true;

                dr.Close();
            }
            return p;
        }

        private void ModifierA_Click(object sender, EventArgs e)
        {
            if (textBox_idA.Text == "" || textBox_nomA.Text == "" || textBox_prenomA.Text == "" || textBox_emailA.Text == "" || textBox_mdpA.Text == "")
            {

                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!rechercher_idADMIN(textBox_idA.Text)) // vérification de l'existence du l'admin dont le id est saisi dans la zone idAdmin
            {
                MessageBox.Show("Admin Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idA.Focus();
                textBox_idA.SelectAll(); //selectionner le champ idAdmin pour une éventuelle resaisie
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("update administrateur set nomAdmin='" + textBox_nomA.Text + "',prenomAdmin='" + textBox_prenomA.Text + "',emailAdmin='" + textBox_emailA.Text + "',mdpAdmin='" + textBox_mdpA.Text + "'where idAdmin='" + textBox_idA.Text + "'");
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Admin bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualiserADMIN();
                }
            }

        }

        private void SupprimerA_Click(object sender, EventArgs e)
        {
            if (textBox_idA.Text == "") //controle de saisie
            {
                MessageBox.Show("Champ idAdmin vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_idADMIN(textBox_idA.Text) == false) // vérification de l'existence du l'admin dont le idAadmin est saisi dans la zone idAdmin
            {

                MessageBox.Show("Admin Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idA.Focus();
                textBox_idA.SelectAll(); //selectionner le champ idAdmin pour une éventuelle resaisie
                viderADMIN();
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("delete from administrateur where idAdmin='{0}'", textBox_idA.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Admin bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NouveauA.PerformClick(); //appeler le bouton nouveau pour vider les champs

                    actualiserADMIN();
                }

            }
        }

        private void ChercherA_Click(object sender, EventArgs e)
        {
            if (textBox_idA.Text == "") //controle de saisie sur le champ idAdmin
                MessageBox.Show("Champ idAdmin vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_idADMIN(textBox_idA.Text) == false) // vérification de l'existence du l'admin dont le idAdmin est saisi dans la zone idAdmin
            {

                MessageBox.Show("Admin introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idA.Focus();
                textBox_idA.SelectAll(); //selectionner le champ idAdmin pour une éventuelle resaisie
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from administrateur where idAdmin='" + textBox_idA.Text + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Read(); // un seul client 
                    textBox_nomA.Text = dr.GetString(1); // = dr[1].toString()
                    textBox_prenomA.Text = dr[2].ToString();
                    textBox_emailA.Text = dr[3].ToString();
                    textBox_mdpA.Text = dr[4].ToString();
                }
                dr.Close();
                actualiser();
            }
        }


        // *************************************** Gestion de Commande *************************************************


        private void viderCOMMANDE()
        {
            textBox_idCOM.Text = "";
            dateCOM.Value = DateTime.Now;
            time.Text = "00:00:00";
            NBR_H.Value = 0;
            textBox_PT.Text = "";
            textBox_idM.Text = "";
            textBox_idCL.Text = "";
        }

        private void actualiser_COMMANDE()
        {
            MySqlCommand cmd = new MySqlCommand("select * from commande", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_COM.DataSource = dt;
            dr.Close();

        }

        private bool rechercher_idCOM(string s)
        {
            bool p = false; int x;
            if (!int.TryParse(s, out x))
            {
                MessageBox.Show("saisir un idCommande de table Commande entier", "Erreur de type", MessageBoxButtons.OK);
                textBox_idCOM.Text = "";
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "select * from commande where idCommande='" + x + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    p = true;

                dr.Close();
            }
            return p;
        }

        private void NouveauCOM_Click(object sender, EventArgs e)
        {
            viderCOMMANDE(); 
        }

        private void SupprimerCOM_Click(object sender, EventArgs e)
        {

            if (textBox_idCOM.Text == "")
            {
                MessageBox.Show("Champ idCommande vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_idCOM(textBox_idCOM.Text) == false) // vérification de l'existence de la Commande dont le idCommande est saisi dans la zone idCommande
            {

                MessageBox.Show("Commande Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idCOM.Focus();
                textBox_idCOM.SelectAll(); //selectionner le champ idCommande pour une éventuelle resaisie
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("delete from commande where idCommande='{0}'", textBox_idCOM.Text);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Commande bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NouveauCOM.PerformClick(); //appeler le bouton nouveau pour vider les champs

                    actualiser_COMMANDE();
                }

            }
        }

        private void ChercherCOM_Click(object sender, EventArgs e)
        {
            if (textBox_idCOM.Text == "")
                MessageBox.Show("Champ idCommande vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_idCOM(textBox_idCOM.Text) == false)
            {

                MessageBox.Show("Commande introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idCOM.Focus();
                textBox_idCOM.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from commande where idCommande='" + textBox_idCOM.Text + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    dr.Read();
                    dateCOM.Value = dr.GetDateTime(1);
                    time.Text= dr.GetString(2);
                    NBR_H.Value = dr.GetInt32(3);
                    textBox_PT.Text = dr.GetString(4);
                    textBox_idM.Text = dr.GetString(5);
                    textBox_idCL.Text = dr.GetString(6);

                }
                dr.Close();
                actualiser_COMMANDE();
            }
        }

        private void InserterCOM_Click(object sender, EventArgs e)
        {
            try
            {
            if (NBR_H.Value == 0 || textBox_PT.Text == "" || time.Text=="")
            {
                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateCOM.Value < DateTime.Now)//controle de saisir sur le date
            {
                MessageBox.Show("verifier votre date, Champ invalide !!", "champ incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (rechercher_id(textBox_idCL.Text) == false)//controle de saisir si existe un client avec cette idClient OU NN
            {
                MessageBox.Show("Champ idClient n'existe dans la liste Client!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (rechercher_id(textBox_idCL.Text) == false)//controle de saisir si existe un client avec cette idClient OU NN
            {
                MessageBox.Show("Champ idClient n'existe dans la liste Client!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (!rechercher_idMAT(textBox_idM.Text))//controle de saisir si existe une matirel avec cette idMatriel OU NN
            {
                MessageBox.Show("Champ idMateriel n'existe dans le liste Materiel!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                    string insertCOMMANDEquery = "INSERT INTO agrimateriel.commande (dateCommande,heureDebut,nbrHeure,prixTotal,idMateriel,idClient) VALUES ('" + dateCOM.Text + "','" + time.Text + "','" + NBR_H.Value + "','" + textBox_PT.Text + "','" + textBox_idM.Text + "','" + textBox_idCL.Text + "')";
                MySqlCommand cmd = new MySqlCommand(insertCOMMANDEquery, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Votre insertion a effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Pobleme, votre insertion est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualiser_COMMANDE();
                viderCOMMANDE();
            }
            
        }
        catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
        private void ModifierCOM_Click(object sender, EventArgs e)
        {

            try
            {
                if (NBR_H.Value == 0 || textBox_PT.Text == "" || textBox_idM.Text == "" || textBox_idCL.Text == ""|| time.Text=="")
                {

                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!rechercher_idCOM(textBox_idCOM.Text)) // vérification de l'existence du client dont le id est saisi dans la zone idClient
                {
                    MessageBox.Show("Commande Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox_idCOM.Focus();
                    textBox_idCOM.SelectAll(); //selectionner le champ idClient pour une éventuelle resaisie
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = String.Format("update commande set dateCommande='" +  this.dateCOM.Text  + "',heureDebut='" + time.Text + "', nbrHeure='" + NBR_H.Value + "',prixTotal='" + textBox_PT.Text + "',idMateriel='" + textBox_idM.Text + "',idClient='" + textBox_idCL.Text + "'where idCommande='" + textBox_idCOM.Text + "'");
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Commande bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualiser_COMMANDE();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        // *************************************** Gestion de Materiel *************************************************

        private void actualiser_MAT()
        {
            MySqlCommand cmd = new MySqlCommand("select * from annoncemateriel", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView_MAT.DataSource = dt;
            dr.Close();

        }

        private void viderMAT()
        {
            textBox_idMateriel.Text = "";
            textBox_nomMateriel.Text = "";
            textBox_categorie.Text = "";
            textBox_adresse.Text = "";
            textBox_description.Text = "";
            dateAjoutM.Value = DateTime.Now;
            textBox_prixHeure.Text = "";
            comboBox_etat.SelectedIndex = -1;
            textBox_idClientMAT.Text = "";
            photo_MAT.Image =  null ;
        }

        private void NouveauMAT_Click(object sender, EventArgs e)
        {
            viderMAT();
        }

        private bool rechercher_idMAT(string s) 
        {
            bool p = false; int x;

            if (!int.TryParse(s, out x))
            {
                MessageBox.Show("saisir un idMateriel entier", "Erreur de type", MessageBoxButtons.OK);
                textBox_idMateriel.Text = "";
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "select * from annoncemateriel where idMateriel='" + x + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    p = true;

                dr.Close();
            }
            return p;
        }

        private void SupprimerMAT_Click(object sender, EventArgs e)
        {
            if (textBox_idMateriel.Text == "")
            {
                MessageBox.Show("Champ idMatriel vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rechercher_idMAT(textBox_idMateriel.Text) == false) 
            {

                MessageBox.Show("Materiel Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idMateriel.Focus();
                textBox_idMateriel.SelectAll(); 
            }
            else
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("delete from annoncemateriel where idMateriel='{0}'", textBox_idMateriel.Text);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Materiel bien Supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NouveauMAT.PerformClick();

                    actualiser_MAT();
                }

            }
        }

        private void ChercherMAT_Click(object sender, EventArgs e)
        {
            if (textBox_idMateriel.Text == "")
                MessageBox.Show("Champ idMateriel vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_idMAT(textBox_idMateriel.Text) == false)
            {

                MessageBox.Show("Materiel introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idMateriel.Focus();
                textBox_idMateriel.SelectAll();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from annoncemateriel where idMateriel='" + textBox_idMateriel.Text + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    dr.Read(); // un seul client 
                    textBox_nomC.Text = dr.GetString(1);

                    textBox_nomMateriel.Text = dr.GetString(1);
                    textBox_categorie.Text = dr.GetString(2);
                    textBox_description.Text = dr.GetString(3);
                    textBox_adresse.Text = dr.GetString(4);

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

                    dateAjoutM.Value = dr.GetDateTime(6);
                    textBox_prixHeure.Text = dr.GetString(7); ;
                    comboBox_etat.SelectedIndex = dr.GetInt32(8); ;
                    textBox_idClientMAT.Text = dr.GetString(9);


                }
                dr.Close();
                actualiser_MAT();
            }
        }

        private void photo_MAT_Click(object sender, EventArgs e)//Permet de charger une photo dans le PictureBox
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p!=null)
            {
                open.Filter = "(*.jpg;*.png;*.jpeg;*.bmp)| *.jpg; *.png; *.jpeg; *.bmp";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);

                }
            }


        }

        //modifMAT manque fy photo
        private void ModifierMAT_Click(object sender, EventArgs e)
        {
            if (textBox_nomMateriel.Text == "" || textBox_categorie.Text == "" || textBox_adresse.Text == "" || textBox_description.Text == "" || textBox_prixHeure.Text == "" || textBox_idClientMAT.Text == "")
            {

                MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboBox_etat.SelectedIndex == -1)
            {
                MessageBox.Show("Type etat non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //else if (photo_MAT.Image == null)
            //{
            //    MessageBox.Show("photo non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            else if (!rechercher_idMAT(textBox_idMateriel.Text)) 
            {
                MessageBox.Show("Materiel Introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idMateriel.Focus();
                textBox_idMateriel.SelectAll(); 
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format("update annoncemateriel set nomMateriel='" + textBox_nomMateriel.Text + "',categorie='" + textBox_categorie.Text + "',description='" + textBox_description.Text + "',adresse='" + textBox_adresse.Text + "', photo='" + photo_MAT.Image + "',dateAjout='" + this.dateAjoutM.Text + "',prixHeure='" + textBox_prixHeure.Text + "',etat = '" + comboBox_etat.SelectedItem.ToString() + "', idClient='" + textBox_idClientMAT.Text + "' where idMateriel='" + textBox_idMateriel.Text + "'");
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Materiel bien Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualiser_MAT();
                }
            }


        }

        //insertMAT mazelt ne9sa 
        private void InserterMAT_Click(object sender, EventArgs e)
        {
            //if (photo_MAT!= null)
            //    { 
            //        string fnom = textBox_idMateriel.Text + ".jpg";
            //        string dossier = "C:\\Users\\khouildi\\source\\repos\\PROJET_PFA\\image";
            //        string S = System.IO.Path.Combine(dossier, fnom);
            //    }

            try
            {
                if (textBox_nomMateriel.Text == "" || textBox_categorie.Text == "" || textBox_description.Text == "" || textBox_adresse.Text == "" || dateAjoutM.Text == "" || textBox_prixHeure.Text == "" || textBox_idClientMAT.Text == "")
                {
                    MessageBox.Show("Champ vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBox_etat.SelectedIndex == -1)
                {
                    MessageBox.Show("etat non saisi!!", "champ Invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (photo_MAT!= null)
                {
                    string fnom = textBox_idMateriel.Text + ".jpg";
                    string dossier = "C:\\Users\\khouildi\\source\\repos\\PROJET_PFA\\image";
                    string Sy = System.IO.Path.Combine(dossier, fnom);
                }


                else
                {
                    //prob fel photo
                    string insertMATquery = "INSERT INTO agrimateriel.annoncemateriel (nomMateriel,categorie,description,adresse,photo,dateAjout,prixHeure,etat,idClient) VALUES ('" + textBox_nomMateriel.Text + "','" + textBox_categorie.Text + "','" + textBox_description.Text + "','" + textBox_adresse.Text + "','vide','" + dateAjoutM.Text + "','" + textBox_prixHeure.Text + "', '" + comboBox_etat.SelectedItem.ToString() + "','" + textBox_idClientMAT.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(insertMATquery, conn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Votre insertion a effectué avec succès ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Pobleme, votre insertion est perturbé", "Perturbation au cœur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    actualiser();
                    viderCLIENT();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }
}
