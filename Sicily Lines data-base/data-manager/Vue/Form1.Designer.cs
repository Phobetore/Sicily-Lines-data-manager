namespace data_manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsererBtn = new System.Windows.Forms.Button();
            this.dureeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ArriveeBox = new System.Windows.Forms.ComboBox();
            this.DepartBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suppBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.majBtn = new System.Windows.Forms.Button();
            this.majBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pasDeSecteur = new System.Windows.Forms.Label();
            this.pasDeLiaisons = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::data_manager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue dans l\'espace administrateur";
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(158, 64);
            this.listBoxSecteur.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(107, 108);
            this.listBoxSecteur.TabIndex = 3;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.Location = new System.Drawing.Point(390, 64);
            this.listBoxLiaison.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(307, 121);
            this.listBoxLiaison.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selectionner un secteur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Les liaisons  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.InsererBtn);
            this.groupBox1.Controls.Add(this.dureeBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ArriveeBox);
            this.groupBox1.Controls.Add(this.DepartBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // InsererBtn
            // 
            this.InsererBtn.Location = new System.Drawing.Point(61, 101);
            this.InsererBtn.Name = "InsererBtn";
            this.InsererBtn.Size = new System.Drawing.Size(78, 23);
            this.InsererBtn.TabIndex = 6;
            this.InsererBtn.Text = "Inserer";
            this.InsererBtn.UseVisualStyleBackColor = true;
            this.InsererBtn.Click += new System.EventHandler(this.InsererBtn_Click);
            // 
            // dureeBox
            // 
            this.dureeBox.Location = new System.Drawing.Point(86, 74);
            this.dureeBox.Name = "dureeBox";
            this.dureeBox.Size = new System.Drawing.Size(103, 21);
            this.dureeBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Durée:";
            // 
            // ArriveeBox
            // 
            this.ArriveeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArriveeBox.FormattingEnabled = true;
            this.ArriveeBox.Location = new System.Drawing.Point(86, 45);
            this.ArriveeBox.Name = "ArriveeBox";
            this.ArriveeBox.Size = new System.Drawing.Size(103, 23);
            this.ArriveeBox.TabIndex = 3;
            // 
            // DepartBox
            // 
            this.DepartBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartBox.FormattingEnabled = true;
            this.DepartBox.ItemHeight = 15;
            this.DepartBox.Location = new System.Drawing.Point(86, 16);
            this.DepartBox.Name = "DepartBox";
            this.DepartBox.Size = new System.Drawing.Size(103, 23);
            this.DepartBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port Arrivé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port Depart:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.suppBtn);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(151, 101);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supression";
            // 
            // suppBtn
            // 
            this.suppBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suppBtn.Location = new System.Drawing.Point(35, 41);
            this.suppBtn.Margin = new System.Windows.Forms.Padding(2);
            this.suppBtn.Name = "suppBtn";
            this.suppBtn.Size = new System.Drawing.Size(77, 27);
            this.suppBtn.TabIndex = 0;
            this.suppBtn.Text = "Supprimer";
            this.suppBtn.UseVisualStyleBackColor = false;
            this.suppBtn.Click += new System.EventHandler(this.suppBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.majBtn);
            this.groupBox3.Controls.Add(this.majBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(156, 101);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mise à jour";
            // 
            // majBtn
            // 
            this.majBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.majBtn.Location = new System.Drawing.Point(44, 63);
            this.majBtn.Margin = new System.Windows.Forms.Padding(2);
            this.majBtn.Name = "majBtn";
            this.majBtn.Size = new System.Drawing.Size(67, 21);
            this.majBtn.TabIndex = 2;
            this.majBtn.Text = "MAJ";
            this.majBtn.UseVisualStyleBackColor = false;
            this.majBtn.Click += new System.EventHandler(this.majBtn_Click);
            // 
            // majBox
            // 
            this.majBox.Location = new System.Drawing.Point(61, 29);
            this.majBox.Margin = new System.Windows.Forms.Padding(2);
            this.majBox.Name = "majBox";
            this.majBox.Size = new System.Drawing.Size(87, 21);
            this.majBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durée :";
            // 
            // pasDeSecteur
            // 
            this.pasDeSecteur.AutoSize = true;
            this.pasDeSecteur.BackColor = System.Drawing.Color.White;
            this.pasDeSecteur.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasDeSecteur.Location = new System.Drawing.Point(160, 109);
            this.pasDeSecteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasDeSecteur.Name = "pasDeSecteur";
            this.pasDeSecteur.Size = new System.Drawing.Size(104, 14);
            this.pasDeSecteur.TabIndex = 4;
            this.pasDeSecteur.Text = "Pas de Secteurs";
            this.pasDeSecteur.Visible = false;
            // 
            // pasDeLiaisons
            // 
            this.pasDeLiaisons.AutoSize = true;
            this.pasDeLiaisons.BackColor = System.Drawing.Color.White;
            this.pasDeLiaisons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasDeLiaisons.Location = new System.Drawing.Point(495, 114);
            this.pasDeLiaisons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasDeLiaisons.Name = "pasDeLiaisons";
            this.pasDeLiaisons.Size = new System.Drawing.Size(99, 14);
            this.pasDeLiaisons.TabIndex = 10;
            this.pasDeLiaisons.Text = "Pas de Liaisons";
            this.pasDeLiaisons.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(708, 383);
            this.Controls.Add(this.pasDeLiaisons);
            this.Controls.Add(this.pasDeSecteur);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sicily Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button suppBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox majBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button majBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DepartBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ArriveeBox;
        private System.Windows.Forms.Button InsererBtn;
        private System.Windows.Forms.TextBox dureeBox;
        private System.Windows.Forms.Label pasDeSecteur;
        private System.Windows.Forms.Label pasDeLiaisons;
    }
}

