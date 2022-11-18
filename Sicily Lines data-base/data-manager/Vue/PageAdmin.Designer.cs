namespace data_manager
{
    partial class PageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdmin));
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
            this.suppBtnLi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.majBtn = new System.Windows.Forms.Button();
            this.majBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pasDeSecteur = new System.Windows.Forms.Label();
            this.pasDeLiaisons = new System.Windows.Forms.Label();
            this.listBoxTraversee = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pasdetraversee = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.suppBtnTra = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMois = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxJour = new System.Windows.Forms.TextBox();
            this.insertTra = new System.Windows.Forms.Button();
            this.heureBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 44);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue dans l\'espace administrateur";
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(31, 88);
            this.listBoxSecteur.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(110, 147);
            this.listBoxSecteur.TabIndex = 3;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.Location = new System.Drawing.Point(159, 88);
            this.listBoxLiaison.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(312, 147);
            this.listBoxLiaison.TabIndex = 4;
            this.listBoxLiaison.SelectedIndexChanged += new System.EventHandler(this.listBoxLiaison_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SECTEURS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "LIAISONS";
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
            this.groupBox1.Location = new System.Drawing.Point(91, 408);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(203, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion Liaison";
            // 
            // InsererBtn
            // 
            this.InsererBtn.Location = new System.Drawing.Point(61, 97);
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
            this.groupBox2.Controls.Add(this.suppBtnLi);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(151, 61);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supression Liaison";
            // 
            // suppBtnLi
            // 
            this.suppBtnLi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suppBtnLi.Location = new System.Drawing.Point(36, 24);
            this.suppBtnLi.Margin = new System.Windows.Forms.Padding(2);
            this.suppBtnLi.Name = "suppBtnLi";
            this.suppBtnLi.Size = new System.Drawing.Size(78, 26);
            this.suppBtnLi.TabIndex = 0;
            this.suppBtnLi.Text = "Supprimer";
            this.suppBtnLi.UseVisualStyleBackColor = false;
            this.suppBtnLi.Click += new System.EventHandler(this.suppBtnLi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.majBtn);
            this.groupBox3.Controls.Add(this.majBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(115, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(156, 101);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mise à jour Liaison";
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
            this.pasDeSecteur.Location = new System.Drawing.Point(36, 152);
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
            this.pasDeLiaisons.Location = new System.Drawing.Point(268, 152);
            this.pasDeLiaisons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasDeLiaisons.Name = "pasDeLiaisons";
            this.pasDeLiaisons.Size = new System.Drawing.Size(99, 14);
            this.pasDeLiaisons.TabIndex = 10;
            this.pasDeLiaisons.Text = "Pas de Liaisons";
            this.pasDeLiaisons.Visible = false;
            // 
            // listBoxTraversee
            // 
            this.listBoxTraversee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxTraversee.FormattingEnabled = true;
            this.listBoxTraversee.Location = new System.Drawing.Point(488, 88);
            this.listBoxTraversee.Name = "listBoxTraversee";
            this.listBoxTraversee.Size = new System.Drawing.Size(226, 147);
            this.listBoxTraversee.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Traversés";
            // 
            // pasdetraversee
            // 
            this.pasdetraversee.AutoSize = true;
            this.pasdetraversee.BackColor = System.Drawing.Color.White;
            this.pasdetraversee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasdetraversee.Location = new System.Drawing.Point(553, 152);
            this.pasdetraversee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pasdetraversee.Name = "pasdetraversee";
            this.pasdetraversee.Size = new System.Drawing.Size(109, 14);
            this.pasdetraversee.TabIndex = 13;
            this.pasdetraversee.Text = "Pas de Traversée";
            this.pasdetraversee.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox4.Controls.Add(this.suppBtnTra);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(452, 330);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(151, 61);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supression Traversée";
            // 
            // suppBtnTra
            // 
            this.suppBtnTra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suppBtnTra.Location = new System.Drawing.Point(36, 24);
            this.suppBtnTra.Margin = new System.Windows.Forms.Padding(2);
            this.suppBtnTra.Name = "suppBtnTra";
            this.suppBtnTra.Size = new System.Drawing.Size(78, 26);
            this.suppBtnTra.TabIndex = 0;
            this.suppBtnTra.Text = "Supprimer";
            this.suppBtnTra.UseVisualStyleBackColor = false;
            this.suppBtnTra.Click += new System.EventHandler(this.suppBtnTra_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.textBoxAnnee);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBoxMois);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBoxJour);
            this.groupBox5.Controls.Add(this.insertTra);
            this.groupBox5.Controls.Add(this.heureBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(391, 408);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(272, 125);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Insertion Traversée";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Année:";
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(212, 33);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(47, 21);
            this.textBoxAnnee.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mois:";
            // 
            // textBoxMois
            // 
            this.textBoxMois.Location = new System.Drawing.Point(124, 33);
            this.textBoxMois.Name = "textBoxMois";
            this.textBoxMois.Size = new System.Drawing.Size(32, 21);
            this.textBoxMois.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Jour:";
            // 
            // textBoxJour
            // 
            this.textBoxJour.Location = new System.Drawing.Point(44, 33);
            this.textBoxJour.Name = "textBoxJour";
            this.textBoxJour.Size = new System.Drawing.Size(32, 21);
            this.textBoxJour.TabIndex = 7;
            // 
            // insertTra
            // 
            this.insertTra.Location = new System.Drawing.Point(101, 93);
            this.insertTra.Name = "insertTra";
            this.insertTra.Size = new System.Drawing.Size(78, 23);
            this.insertTra.TabIndex = 6;
            this.insertTra.Text = "Inserer";
            this.insertTra.UseVisualStyleBackColor = true;
            this.insertTra.Click += new System.EventHandler(this.insertTra_Click);
            // 
            // heureBox
            // 
            this.heureBox.Location = new System.Drawing.Point(111, 63);
            this.heureBox.Name = "heureBox";
            this.heureBox.Size = new System.Drawing.Size(103, 21);
            this.heureBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Heure:";
            // 
            // logo
            // 
            this.logo.ErrorImage = null;
            this.logo.Image = global::data_manager.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(44, 42);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // PageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(741, 559);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pasdetraversee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxTraversee);
            this.Controls.Add(this.pasDeLiaisons);
            this.Controls.Add(this.pasDeSecteur);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(722, 416);
            this.Name = "PageAdmin";
            this.Text = "Sicily Lines";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PageAdmin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button suppBtnLi;
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
        private System.Windows.Forms.ListBox listBoxTraversee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label pasdetraversee;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button suppBtnTra;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxJour;
        private System.Windows.Forms.Button insertTra;
        private System.Windows.Forms.TextBox heureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMois;
    }
}

