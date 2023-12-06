namespace PROJET_PFA
{
    partial class CONN_UTILISATEUR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONN_UTILISATEUR));
            this.MOT_DE_PASS = new System.Windows.Forms.Label();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CONNECTION = new System.Windows.Forms.Button();
            this.creer_compte = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.retour)).BeginInit();
            this.SuspendLayout();
            // 
            // MOT_DE_PASS
            // 
            this.MOT_DE_PASS.AutoSize = true;
            this.MOT_DE_PASS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MOT_DE_PASS.ForeColor = System.Drawing.SystemColors.Info;
            this.MOT_DE_PASS.Location = new System.Drawing.Point(211, 197);
            this.MOT_DE_PASS.Name = "MOT_DE_PASS";
            this.MOT_DE_PASS.Size = new System.Drawing.Size(87, 13);
            this.MOT_DE_PASS.TabIndex = 2;
            this.MOT_DE_PASS.Text = "MOT DE PASSE";
            this.MOT_DE_PASS.Click += new System.EventHandler(this.MOT_DE_PASS_Click);
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(314, 194);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.PasswordChar = '*';
            this.textBox_mdp.Size = new System.Drawing.Size(158, 20);
            this.textBox_mdp.TabIndex = 3;
            this.textBox_mdp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(314, 135);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(158, 20);
            this.textBox_address.TabIndex = 1;
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(211, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADRESSE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CONNECTION
            // 
            this.CONNECTION.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CONNECTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECTION.ForeColor = System.Drawing.SystemColors.Control;
            this.CONNECTION.Location = new System.Drawing.Point(352, 254);
            this.CONNECTION.Name = "CONNECTION";
            this.CONNECTION.Size = new System.Drawing.Size(134, 42);
            this.CONNECTION.TabIndex = 7;
            this.CONNECTION.Text = "CONNEXION";
            this.CONNECTION.UseVisualStyleBackColor = false;
            this.CONNECTION.Click += new System.EventHandler(this.CONNECTION_Click);
            // 
            // creer_compte
            // 
            this.creer_compte.BackColor = System.Drawing.Color.LimeGreen;
            this.creer_compte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creer_compte.Location = new System.Drawing.Point(195, 254);
            this.creer_compte.Name = "creer_compte";
            this.creer_compte.Size = new System.Drawing.Size(134, 42);
            this.creer_compte.TabIndex = 8;
            this.creer_compte.Text = "CREER COMPTE";
            this.creer_compte.UseVisualStyleBackColor = false;
            this.creer_compte.Click += new System.EventHandler(this.creer_compte_Click);
            // 
            // retour
            // 
            this.retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retour.Image = ((System.Drawing.Image)(resources.GetObject("retour.Image")));
            this.retour.Location = new System.Drawing.Point(577, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(40, 38);
            this.retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.retour.TabIndex = 9;
            this.retour.TabStop = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // CONN_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 352);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.creer_compte);
            this.Controls.Add(this.CONNECTION);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.MOT_DE_PASS);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CONN_UTILISATEUR";
            this.Text = "CONN_UTILISATEUR";
            this.Load += new System.EventHandler(this.CONN_UTILISATEUR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MOT_DE_PASS;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CONNECTION;
        private System.Windows.Forms.Button creer_compte;
        private System.Windows.Forms.PictureBox retour;
    }
}