namespace data_manager.Vue
{
    partial class Connexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.erreur = new System.Windows.Forms.Label();
            this.MdpBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.erreur);
            this.panel1.Controls.Add(this.MdpBox);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.ConnexionBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(206, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 261);
            this.panel1.TabIndex = 0;
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.BackColor = System.Drawing.Color.White;
            this.erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(57, 21);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(0, 22);
            this.erreur.TabIndex = 5;
            // 
            // MdpBox
            // 
            this.MdpBox.Location = new System.Drawing.Point(178, 109);
            this.MdpBox.Name = "MdpBox";
            this.MdpBox.Size = new System.Drawing.Size(148, 26);
            this.MdpBox.TabIndex = 4;
            this.MdpBox.UseSystemPasswordChar = true;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(178, 61);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(148, 26);
            this.LoginBox.TabIndex = 3;
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionBtn.Location = new System.Drawing.Point(158, 181);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(107, 38);
            this.ConnexionBtn.TabIndex = 2;
            this.ConnexionBtn.Text = "Connexion";
            this.ConnexionBtn.UseVisualStyleBackColor = true;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::data_manager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(318, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(850, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MdpBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erreur;
    }
}