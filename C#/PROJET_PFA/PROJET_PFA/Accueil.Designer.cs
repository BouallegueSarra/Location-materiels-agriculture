namespace PROJET_PFA
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.BTN_CON_UTILISATEUR = new System.Windows.Forms.Button();
            this.BTN_CON_ADMIN = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CON_UTILISATEUR
            // 
            this.BTN_CON_UTILISATEUR.Location = new System.Drawing.Point(344, 70);
            this.BTN_CON_UTILISATEUR.Name = "BTN_CON_UTILISATEUR";
            this.BTN_CON_UTILISATEUR.Size = new System.Drawing.Size(110, 51);
            this.BTN_CON_UTILISATEUR.TabIndex = 1;
            this.BTN_CON_UTILISATEUR.Text = "Connecte En Tantque Utilisateur ";
            this.BTN_CON_UTILISATEUR.UseVisualStyleBackColor = true;
            this.BTN_CON_UTILISATEUR.Click += new System.EventHandler(this.BTN_CON_UTILISATEUR_Click);
            // 
            // BTN_CON_ADMIN
            // 
            this.BTN_CON_ADMIN.Location = new System.Drawing.Point(107, 70);
            this.BTN_CON_ADMIN.Name = "BTN_CON_ADMIN";
            this.BTN_CON_ADMIN.Size = new System.Drawing.Size(110, 51);
            this.BTN_CON_ADMIN.TabIndex = 2;
            this.BTN_CON_ADMIN.Text = "Connecte En Tantque Admin ";
            this.BTN_CON_ADMIN.UseVisualStyleBackColor = true;
            this.BTN_CON_ADMIN.Click += new System.EventHandler(this.BTN_CON_ADMIN_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.AccessibleDescription = "CLOSE";
            this.CLOSE.AccessibleName = "CLOSE";
            this.CLOSE.BackColor = System.Drawing.Color.IndianRed;
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(513, 12);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(40, 40);
            this.CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CLOSE.TabIndex = 3;
            this.CLOSE.TabStop = false;
            this.CLOSE.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 562);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.BTN_CON_ADMIN);
            this.Controls.Add(this.BTN_CON_UTILISATEUR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_CON_UTILISATEUR;
        private System.Windows.Forms.Button BTN_CON_ADMIN;
        private System.Windows.Forms.PictureBox CLOSE;
    }
}

