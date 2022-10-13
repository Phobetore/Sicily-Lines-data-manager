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
            this.logo = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue dans l\'espace administrateur";
            // 
            // logo
            // 
            this.logo.ErrorImage = null;
            this.logo.Image = global::data_manager.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(66, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 20;
            this.listBoxSecteur.Location = new System.Drawing.Point(101, 108);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(356, 224);
            this.listBoxSecteur.TabIndex = 3;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.ItemHeight = 20;
            this.listBoxLiaison.Location = new System.Drawing.Point(613, 98);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(393, 264);
            this.listBoxLiaison.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "SECTEURS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(741, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(89, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // InsererBtn
            // 
            this.InsererBtn.Location = new System.Drawing.Point(92, 155);
            this.InsererBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsererBtn.Name = "InsererBtn";
            this.InsererBtn.Size = new System.Drawing.Size(117, 35);
            this.InsererBtn.TabIndex = 6;
            this.InsererBtn.Text = "Inserer";
            this.InsererBtn.UseVisualStyleBackColor = true;
            this.InsererBtn.Click += new System.EventHandler(this.InsererBtn_Click);
            // 
            // dureeBox
            // 
            this.dureeBox.Location = new System.Drawing.Point(129, 114);
            this.dureeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dureeBox.Name = "dureeBox";
            this.dureeBox.Size = new System.Drawing.Size(152, 28);
            this.dureeBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Durée:";
            // 
            // ArriveeBox
            // 
            this.ArriveeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArriveeBox.FormattingEnabled = true;
            this.ArriveeBox.Location = new System.Drawing.Point(129, 69);
            this.ArriveeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArriveeBox.Name = "ArriveeBox";
            this.ArriveeBox.Size = new System.Drawing.Size(152, 29);
            this.ArriveeBox.TabIndex = 3;
            // 
            // DepartBox
            // 
            this.DepartBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartBox.FormattingEnabled = true;
            this.DepartBox.ItemHeight = 21;
            this.DepartBox.Location = new System.Drawing.Point(129, 25);
            this.DepartBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepartBox.Name = "DepartBox";
            this.DepartBox.Size = new System.Drawing.Size(152, 29);
            this.DepartBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port Arrivé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port Depart:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.suppBtn);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supression";
            // 
            // suppBtn
            // 
            this.suppBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suppBtn.Location = new System.Drawing.Point(52, 65);
            this.suppBtn.Name = "suppBtn";
            this.suppBtn.Size = new System.Drawing.Size(117, 40);
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
            this.groupBox3.Location = new System.Drawing.Point(746, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mise à jour";
            // 
            // majBtn
            // 
            this.majBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.majBtn.Location = new System.Drawing.Point(66, 97);
            this.majBtn.Name = "majBtn";
            this.majBtn.Size = new System.Drawing.Size(100, 32);
            this.majBtn.TabIndex = 2;
            this.majBtn.Text = "MAJ";
            this.majBtn.UseVisualStyleBackColor = false;
            this.majBtn.Click += new System.EventHandler(this.majBtn_Click);
            // 
            // majBox
            // 
            this.majBox.Location = new System.Drawing.Point(92, 45);
            this.majBox.Name = "majBox";
            this.majBox.Size = new System.Drawing.Size(128, 28);
            this.majBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durée :";
            // 
            // pasDeSecteur
            // 
            this.pasDeSecteur.AutoSize = true;
            this.pasDeSecteur.BackColor = System.Drawing.Color.White;
            this.pasDeSecteur.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasDeSecteur.Location = new System.Drawing.Point(160, 175);
            this.pasDeSecteur.Name = "pasDeSecteur";
            this.pasDeSecteur.Size = new System.Drawing.Size(153, 22);
            this.pasDeSecteur.TabIndex = 4;
            this.pasDeSecteur.Text = "Pas de Secteurs";
            this.pasDeSecteur.Visible = false;
            // 
            // pasDeLiaisons
            // 
            this.pasDeLiaisons.AutoSize = true;
            this.pasDeLiaisons.BackColor = System.Drawing.Color.White;
            this.pasDeLiaisons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasDeLiaisons.Location = new System.Drawing.Point(742, 175);
            this.pasDeLiaisons.Name = "pasDeLiaisons";
            this.pasDeLiaisons.Size = new System.Drawing.Size(146, 22);
            this.pasDeLiaisons.TabIndex = 10;
            this.pasDeLiaisons.Text = "Pas de Liaisons";
            this.pasDeLiaisons.Visible = false;
            // 
            // PageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1053, 563);
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
            this.MaximumSize = new System.Drawing.Size(1075, 619);
            this.MinimumSize = new System.Drawing.Size(1075, 619);
            this.Name = "PageAdmin";
            this.Text = "Sicily Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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

