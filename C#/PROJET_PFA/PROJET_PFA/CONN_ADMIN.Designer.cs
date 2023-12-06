namespace PROJET_PFA
{
    partial class CONN_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONN_ADMIN));
            this.retour = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MOT_DE_PASS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CONNECTION = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.retour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retour
            // 
            this.retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retour.Image = ((System.Drawing.Image)(resources.GetObject("retour.Image")));
            this.retour.Location = new System.Drawing.Point(576, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(40, 38);
            this.retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.retour.TabIndex = 10;
            this.retour.TabStop = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADRESSE";
            // 
            // MOT_DE_PASS
            // 
            this.MOT_DE_PASS.AutoSize = true;
            this.MOT_DE_PASS.Location = new System.Drawing.Point(38, 122);
            this.MOT_DE_PASS.Name = "MOT_DE_PASS";
            this.MOT_DE_PASS.Size = new System.Drawing.Size(87, 13);
            this.MOT_DE_PASS.TabIndex = 1;
            this.MOT_DE_PASS.Text = "MOT DE PASSE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 3;
            // 
            // CONNECTION
            // 
            this.CONNECTION.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CONNECTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECTION.Location = new System.Drawing.Point(103, 181);
            this.CONNECTION.Name = "CONNECTION";
            this.CONNECTION.Size = new System.Drawing.Size(132, 45);
            this.CONNECTION.TabIndex = 4;
            this.CONNECTION.Text = "CONNEXION";
            this.CONNECTION.UseVisualStyleBackColor = false;
            this.CONNECTION.Click += new System.EventHandler(this.CONNECTION_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CONNECTION);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.MOT_DE_PASS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(246, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 266);
            this.panel1.TabIndex = 0;
            // 
            // CONN_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(628, 354);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CONN_ADMIN";
            this.Text = "CONN_ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.retour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox retour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MOT_DE_PASS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CONNECTION;
        private System.Windows.Forms.Panel panel1;
    }
}