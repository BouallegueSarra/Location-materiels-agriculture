using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_PFA
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            var confirmation = MessageBox.Show("Merci pour utiliser notre servise!","au revoir", MessageBoxButtons.OK);
            //this.Close();
            Application.Exit();

            /*var confirmation = MessageBox.Show("Etes-vous sure de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmation == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit(); // this.close()
            }*/
        }

        private void BTN_CON_ADMIN_Click(object sender, EventArgs e)
        {
            CONN_ADMIN AD = new CONN_ADMIN();
            AD.Show();
            this.Hide();
        }

        private void BTN_CON_UTILISATEUR_Click(object sender, EventArgs e)
        {
            CONN_UTILISATEUR UT = new CONN_UTILISATEUR();
            UT.Show();
            this.Hide();
            
        }
    }
}
