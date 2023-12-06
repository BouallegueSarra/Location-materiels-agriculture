namespace PROJET_PFA
{
    partial class Interface_UTILISATEUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_UTILISATEUR));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.commande = new System.Windows.Forms.TabPage();
            this.cherchmat = new System.Windows.Forms.Button();
            this.NouvComm = new System.Windows.Forms.Button();
            this.hdebut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confcomm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbheure = new System.Windows.Forms.NumericUpDown();
            this.datecomm = new System.Windows.Forms.DateTimePicker();
            this.DateCommande = new System.Windows.Forms.Label();
            this.phmat = new System.Windows.Forms.PictureBox();
            this.Photo = new System.Windows.Forms.Label();
            this.pheure = new System.Windows.Forms.TextBox();
            this.PrixH = new System.Windows.Forms.Label();
            this.nmat = new System.Windows.Forms.TextBox();
            this.NomMatriel = new System.Windows.Forms.Label();
            this.ajoutmatriel = new System.Windows.Forms.TabPage();
            this.nouv_mat_c = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pmat = new System.Windows.Forms.PictureBox();
            this.datemat = new System.Windows.Forms.DateTimePicker();
            this.cherch_mat_c = new System.Windows.Forms.Button();
            this.supp_mat_c = new System.Windows.Forms.Button();
            this.modif_mat_c = new System.Windows.Forms.Button();
            this.ins_mat_c = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxetatmat = new System.Windows.Forms.ComboBox();
            this.idc = new System.Windows.Forms.TextBox();
            this.prixhmat = new System.Windows.Forms.TextBox();
            this.admat = new System.Windows.Forms.TextBox();
            this.descmat = new System.Windows.Forms.TextBox();
            this.catmat = new System.Windows.Forms.TextBox();
            this.nommat = new System.Windows.Forms.TextBox();
            this.idmat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Déconnection = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.commande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbheure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phmat)).BeginInit();
            this.ajoutmatriel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Déconnection)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.commande);
            this.tabControl1.Controls.Add(this.ajoutmatriel);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // commande
            // 
            this.commande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commande.BackgroundImage")));
            this.commande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commande.Controls.Add(this.cherchmat);
            this.commande.Controls.Add(this.NouvComm);
            this.commande.Controls.Add(this.hdebut);
            this.commande.Controls.Add(this.label2);
            this.commande.Controls.Add(this.confcomm);
            this.commande.Controls.Add(this.label1);
            this.commande.Controls.Add(this.nbheure);
            this.commande.Controls.Add(this.datecomm);
            this.commande.Controls.Add(this.DateCommande);
            this.commande.Controls.Add(this.phmat);
            this.commande.Controls.Add(this.Photo);
            this.commande.Controls.Add(this.pheure);
            this.commande.Controls.Add(this.PrixH);
            this.commande.Controls.Add(this.nmat);
            this.commande.Controls.Add(this.NomMatriel);
            this.commande.Location = new System.Drawing.Point(4, 22);
            this.commande.Name = "commande";
            this.commande.Padding = new System.Windows.Forms.Padding(3);
            this.commande.Size = new System.Drawing.Size(794, 580);
            this.commande.TabIndex = 0;
            this.commande.Text = "Passer une commande";
            this.commande.UseVisualStyleBackColor = true;
            // 
            // cherchmat
            // 
            this.cherchmat.BackColor = System.Drawing.Color.Yellow;
            this.cherchmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherchmat.Location = new System.Drawing.Point(619, 157);
            this.cherchmat.Name = "cherchmat";
            this.cherchmat.Size = new System.Drawing.Size(127, 51);
            this.cherchmat.TabIndex = 17;
            this.cherchmat.Text = "chercher";
            this.cherchmat.UseVisualStyleBackColor = false;
            this.cherchmat.Click += new System.EventHandler(this.cherchmat_Click);
            // 
            // NouvComm
            // 
            this.NouvComm.BackColor = System.Drawing.Color.LavenderBlush;
            this.NouvComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NouvComm.Location = new System.Drawing.Point(619, 460);
            this.NouvComm.Name = "NouvComm";
            this.NouvComm.Size = new System.Drawing.Size(127, 51);
            this.NouvComm.TabIndex = 16;
            this.NouvComm.Text = "Nouveau";
            this.NouvComm.UseVisualStyleBackColor = false;
            this.NouvComm.Click += new System.EventHandler(this.NouvComm_Click);
            // 
            // hdebut
            // 
            this.hdebut.Location = new System.Drawing.Point(76, 490);
            this.hdebut.Name = "hdebut";
            this.hdebut.Size = new System.Drawing.Size(176, 20);
            this.hdebut.TabIndex = 15;
            this.hdebut.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(116, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Heure Debut";
            // 
            // confcomm
            // 
            this.confcomm.BackColor = System.Drawing.Color.LimeGreen;
            this.confcomm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confcomm.Location = new System.Drawing.Point(619, 309);
            this.confcomm.Name = "confcomm";
            this.confcomm.Size = new System.Drawing.Size(127, 51);
            this.confcomm.TabIndex = 13;
            this.confcomm.Text = "Passer votre Commande";
            this.confcomm.UseVisualStyleBackColor = false;
            this.confcomm.Click += new System.EventHandler(this.confcomm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(383, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre d\'Heure";
            // 
            // nbheure
            // 
            this.nbheure.Location = new System.Drawing.Point(381, 491);
            this.nbheure.Name = "nbheure";
            this.nbheure.Size = new System.Drawing.Size(120, 20);
            this.nbheure.TabIndex = 10;
            // 
            // datecomm
            // 
            this.datecomm.CustomFormat = "yyyy-MM-dd";
            this.datecomm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecomm.Location = new System.Drawing.Point(76, 383);
            this.datecomm.Name = "datecomm";
            this.datecomm.Size = new System.Drawing.Size(176, 20);
            this.datecomm.TabIndex = 9;
            this.datecomm.Value = new System.DateTime(2020, 5, 14, 0, 0, 0, 0);
            // 
            // DateCommande
            // 
            this.DateCommande.AutoSize = true;
            this.DateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DateCommande.ForeColor = System.Drawing.SystemColors.Info;
            this.DateCommande.Location = new System.Drawing.Point(102, 322);
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.Size = new System.Drawing.Size(121, 18);
            this.DateCommande.TabIndex = 8;
            this.DateCommande.Text = "Date Commande";
            // 
            // phmat
            // 
            this.phmat.BackColor = System.Drawing.Color.Honeydew;
            this.phmat.Location = new System.Drawing.Point(350, 274);
            this.phmat.Name = "phmat";
            this.phmat.Size = new System.Drawing.Size(176, 127);
            this.phmat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phmat.TabIndex = 7;
            this.phmat.TabStop = false;
            this.phmat.Click += new System.EventHandler(this.phmat_Click);
            // 
            // Photo
            // 
            this.Photo.AutoSize = true;
            this.Photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Photo.ForeColor = System.Drawing.SystemColors.Info;
            this.Photo.Location = new System.Drawing.Point(414, 219);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(48, 18);
            this.Photo.TabIndex = 6;
            this.Photo.Text = "Photo";
            // 
            // pheure
            // 
            this.pheure.Location = new System.Drawing.Point(76, 274);
            this.pheure.Name = "pheure";
            this.pheure.ReadOnly = true;
            this.pheure.Size = new System.Drawing.Size(176, 20);
            this.pheure.TabIndex = 5;
            // 
            // PrixH
            // 
            this.PrixH.AutoSize = true;
            this.PrixH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PrixH.ForeColor = System.Drawing.SystemColors.Info;
            this.PrixH.Location = new System.Drawing.Point(126, 219);
            this.PrixH.Name = "PrixH";
            this.PrixH.Size = new System.Drawing.Size(77, 18);
            this.PrixH.TabIndex = 4;
            this.PrixH.Text = "Prix Heure";
            // 
            // nmat
            // 
            this.nmat.Location = new System.Drawing.Point(218, 174);
            this.nmat.Name = "nmat";
            this.nmat.Size = new System.Drawing.Size(176, 20);
            this.nmat.TabIndex = 2;
            // 
            // NomMatriel
            // 
            this.NomMatriel.AutoSize = true;
            this.NomMatriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NomMatriel.ForeColor = System.Drawing.SystemColors.Info;
            this.NomMatriel.Location = new System.Drawing.Point(252, 119);
            this.NomMatriel.Name = "NomMatriel";
            this.NomMatriel.Size = new System.Drawing.Size(109, 18);
            this.NomMatriel.TabIndex = 0;
            this.NomMatriel.Text = "Nom du matriel";
            // 
            // ajoutmatriel
            // 
            this.ajoutmatriel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutmatriel.BackgroundImage")));
            this.ajoutmatriel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajoutmatriel.Controls.Add(this.nouv_mat_c);
            this.ajoutmatriel.Controls.Add(this.label3);
            this.ajoutmatriel.Controls.Add(this.pmat);
            this.ajoutmatriel.Controls.Add(this.datemat);
            this.ajoutmatriel.Controls.Add(this.cherch_mat_c);
            this.ajoutmatriel.Controls.Add(this.supp_mat_c);
            this.ajoutmatriel.Controls.Add(this.modif_mat_c);
            this.ajoutmatriel.Controls.Add(this.ins_mat_c);
            this.ajoutmatriel.Controls.Add(this.dataGridView1);
            this.ajoutmatriel.Controls.Add(this.comboBoxetatmat);
            this.ajoutmatriel.Controls.Add(this.idc);
            this.ajoutmatriel.Controls.Add(this.prixhmat);
            this.ajoutmatriel.Controls.Add(this.admat);
            this.ajoutmatriel.Controls.Add(this.descmat);
            this.ajoutmatriel.Controls.Add(this.catmat);
            this.ajoutmatriel.Controls.Add(this.nommat);
            this.ajoutmatriel.Controls.Add(this.idmat);
            this.ajoutmatriel.Controls.Add(this.label4);
            this.ajoutmatriel.Controls.Add(this.label5);
            this.ajoutmatriel.Controls.Add(this.label6);
            this.ajoutmatriel.Controls.Add(this.label7);
            this.ajoutmatriel.Controls.Add(this.label8);
            this.ajoutmatriel.Controls.Add(this.label9);
            this.ajoutmatriel.Controls.Add(this.label10);
            this.ajoutmatriel.Controls.Add(this.label11);
            this.ajoutmatriel.Controls.Add(this.label12);
            this.ajoutmatriel.Location = new System.Drawing.Point(4, 22);
            this.ajoutmatriel.Name = "ajoutmatriel";
            this.ajoutmatriel.Padding = new System.Windows.Forms.Padding(3);
            this.ajoutmatriel.Size = new System.Drawing.Size(794, 580);
            this.ajoutmatriel.TabIndex = 1;
            this.ajoutmatriel.Text = "Ajouter materiel";
            this.ajoutmatriel.UseVisualStyleBackColor = true;
            // 
            // nouv_mat_c
            // 
            this.nouv_mat_c.BackColor = System.Drawing.Color.LavenderBlush;
            this.nouv_mat_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouv_mat_c.Location = new System.Drawing.Point(33, 519);
            this.nouv_mat_c.Name = "nouv_mat_c";
            this.nouv_mat_c.Size = new System.Drawing.Size(143, 36);
            this.nouv_mat_c.TabIndex = 53;
            this.nouv_mat_c.Text = "Nouveau";
            this.nouv_mat_c.UseVisualStyleBackColor = false;
            this.nouv_mat_c.Click += new System.EventHandler(this.nouv_mat_c_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(47, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "photo";
            // 
            // pmat
            // 
            this.pmat.BackColor = System.Drawing.Color.AliceBlue;
            this.pmat.Location = new System.Drawing.Point(154, 334);
            this.pmat.Name = "pmat";
            this.pmat.Size = new System.Drawing.Size(224, 169);
            this.pmat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pmat.TabIndex = 51;
            this.pmat.TabStop = false;
            this.pmat.Click += new System.EventHandler(this.pmat_Click);
            // 
            // datemat
            // 
            this.datemat.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.datemat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datemat.Location = new System.Drawing.Point(510, 194);
            this.datemat.Name = "datemat";
            this.datemat.Size = new System.Drawing.Size(200, 20);
            this.datemat.TabIndex = 50;
            // 
            // cherch_mat_c
            // 
            this.cherch_mat_c.BackColor = System.Drawing.Color.Yellow;
            this.cherch_mat_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherch_mat_c.Location = new System.Drawing.Point(621, 519);
            this.cherch_mat_c.Name = "cherch_mat_c";
            this.cherch_mat_c.Size = new System.Drawing.Size(143, 36);
            this.cherch_mat_c.TabIndex = 49;
            this.cherch_mat_c.Text = "Chercher_id";
            this.cherch_mat_c.UseVisualStyleBackColor = false;
            this.cherch_mat_c.Click += new System.EventHandler(this.cherch_mat_c_Click);
            // 
            // supp_mat_c
            // 
            this.supp_mat_c.BackColor = System.Drawing.Color.Red;
            this.supp_mat_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_mat_c.ForeColor = System.Drawing.SystemColors.Control;
            this.supp_mat_c.Location = new System.Drawing.Point(474, 519);
            this.supp_mat_c.Name = "supp_mat_c";
            this.supp_mat_c.Size = new System.Drawing.Size(143, 36);
            this.supp_mat_c.TabIndex = 48;
            this.supp_mat_c.Text = "Supprimer";
            this.supp_mat_c.UseVisualStyleBackColor = false;
            this.supp_mat_c.Click += new System.EventHandler(this.supp_mat_c_Click);
            // 
            // modif_mat_c
            // 
            this.modif_mat_c.BackColor = System.Drawing.Color.LimeGreen;
            this.modif_mat_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif_mat_c.Location = new System.Drawing.Point(327, 519);
            this.modif_mat_c.Name = "modif_mat_c";
            this.modif_mat_c.Size = new System.Drawing.Size(143, 36);
            this.modif_mat_c.TabIndex = 47;
            this.modif_mat_c.Text = "Modifier";
            this.modif_mat_c.UseVisualStyleBackColor = false;
            this.modif_mat_c.Click += new System.EventHandler(this.modif_mat_c_Click);
            // 
            // ins_mat_c
            // 
            this.ins_mat_c.BackColor = System.Drawing.Color.DodgerBlue;
            this.ins_mat_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ins_mat_c.Location = new System.Drawing.Point(180, 519);
            this.ins_mat_c.Name = "ins_mat_c";
            this.ins_mat_c.Size = new System.Drawing.Size(143, 36);
            this.ins_mat_c.TabIndex = 46;
            this.ins_mat_c.Text = "Insérer";
            this.ins_mat_c.UseVisualStyleBackColor = false;
            this.ins_mat_c.Click += new System.EventHandler(this.ins_mat_c_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 169);
            this.dataGridView1.TabIndex = 44;
            // 
            // comboBoxetatmat
            // 
            this.comboBoxetatmat.FormattingEnabled = true;
            this.comboBoxetatmat.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxetatmat.Location = new System.Drawing.Point(154, 284);
            this.comboBoxetatmat.Name = "comboBoxetatmat";
            this.comboBoxetatmat.Size = new System.Drawing.Size(131, 21);
            this.comboBoxetatmat.TabIndex = 43;
            this.comboBoxetatmat.Text = "-Selecte-";
            // 
            // idc
            // 
            this.idc.Location = new System.Drawing.Point(510, 289);
            this.idc.Name = "idc";
            this.idc.Size = new System.Drawing.Size(224, 20);
            this.idc.TabIndex = 42;
            // 
            // prixhmat
            // 
            this.prixhmat.Location = new System.Drawing.Point(510, 237);
            this.prixhmat.Name = "prixhmat";
            this.prixhmat.Size = new System.Drawing.Size(224, 20);
            this.prixhmat.TabIndex = 41;
            // 
            // admat
            // 
            this.admat.Location = new System.Drawing.Point(510, 150);
            this.admat.Name = "admat";
            this.admat.Size = new System.Drawing.Size(224, 20);
            this.admat.TabIndex = 40;
            // 
            // descmat
            // 
            this.descmat.Location = new System.Drawing.Point(154, 194);
            this.descmat.Multiline = true;
            this.descmat.Name = "descmat";
            this.descmat.Size = new System.Drawing.Size(224, 63);
            this.descmat.TabIndex = 39;
            // 
            // catmat
            // 
            this.catmat.Location = new System.Drawing.Point(154, 150);
            this.catmat.Name = "catmat";
            this.catmat.Size = new System.Drawing.Size(224, 20);
            this.catmat.TabIndex = 38;
            // 
            // nommat
            // 
            this.nommat.Location = new System.Drawing.Point(510, 105);
            this.nommat.Name = "nommat";
            this.nommat.Size = new System.Drawing.Size(224, 20);
            this.nommat.TabIndex = 37;
            // 
            // idmat
            // 
            this.idmat.Location = new System.Drawing.Point(154, 105);
            this.idmat.Name = "idmat";
            this.idmat.Size = new System.Drawing.Size(224, 20);
            this.idmat.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(400, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "idClient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(44, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "etat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(400, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "prixHeure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(400, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "dateAjout";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(400, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(44, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(44, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "categorie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(400, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "nomMateriel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(44, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "idMateriel";
            // 
            // Déconnection
            // 
            this.Déconnection.BackColor = System.Drawing.Color.Black;
            this.Déconnection.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Déconnection.ErrorImage")));
            this.Déconnection.Image = ((System.Drawing.Image)(resources.GetObject("Déconnection.Image")));
            this.Déconnection.Location = new System.Drawing.Point(751, 43);
            this.Déconnection.Name = "Déconnection";
            this.Déconnection.Size = new System.Drawing.Size(44, 43);
            this.Déconnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Déconnection.TabIndex = 4;
            this.Déconnection.TabStop = false;
            this.Déconnection.Click += new System.EventHandler(this.Déconnection_Click);
            // 
            // Interface_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.Déconnection);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Interface_UTILISATEUR";
            this.Text = "Interface_UTILISATEUR";
            this.Load += new System.EventHandler(this.Interface_UTILISATEUR_Load);
            this.tabControl1.ResumeLayout(false);
            this.commande.ResumeLayout(false);
            this.commande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbheure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phmat)).EndInit();
            this.ajoutmatriel.ResumeLayout(false);
            this.ajoutmatriel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Déconnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage commande;
        private System.Windows.Forms.TabPage ajoutmatriel;
        private System.Windows.Forms.PictureBox phmat;
        private System.Windows.Forms.Label Photo;
        private System.Windows.Forms.TextBox pheure;
        private System.Windows.Forms.Label PrixH;
        private System.Windows.Forms.TextBox nmat;
        private System.Windows.Forms.Label NomMatriel;
        private System.Windows.Forms.DateTimePicker datecomm;
        private System.Windows.Forms.Label DateCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbheure;
        private System.Windows.Forms.Button confcomm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pmat;
        private System.Windows.Forms.DateTimePicker datemat;
        private System.Windows.Forms.Button cherch_mat_c;
        private System.Windows.Forms.Button supp_mat_c;
        private System.Windows.Forms.Button modif_mat_c;
        private System.Windows.Forms.Button ins_mat_c;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxetatmat;
        private System.Windows.Forms.TextBox idc;
        private System.Windows.Forms.TextBox prixhmat;
        private System.Windows.Forms.TextBox admat;
        private System.Windows.Forms.TextBox descmat;
        private System.Windows.Forms.TextBox catmat;
        private System.Windows.Forms.TextBox nommat;
        private System.Windows.Forms.TextBox idmat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hdebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NouvComm;
        private System.Windows.Forms.Button cherchmat;
        private System.Windows.Forms.Button nouv_mat_c;
        private System.Windows.Forms.PictureBox Déconnection;
    }
}