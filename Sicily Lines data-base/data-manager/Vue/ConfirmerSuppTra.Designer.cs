﻿namespace data_manager.Vue
{
    partial class ConfirmerSuppTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmerSuppTra));
            this.NonBtn = new System.Windows.Forms.Button();
            this.OuiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NonBtn
            // 
            this.NonBtn.Location = new System.Drawing.Point(267, 84);
            this.NonBtn.Name = "NonBtn";
            this.NonBtn.Size = new System.Drawing.Size(110, 23);
            this.NonBtn.TabIndex = 6;
            this.NonBtn.Text = "NON";
            this.NonBtn.UseVisualStyleBackColor = true;
            this.NonBtn.Click += new System.EventHandler(this.NonBtn_Click);
            // 
            // OuiBtn
            // 
            this.OuiBtn.Location = new System.Drawing.Point(71, 84);
            this.OuiBtn.Name = "OuiBtn";
            this.OuiBtn.Size = new System.Drawing.Size(110, 23);
            this.OuiBtn.TabIndex = 5;
            this.OuiBtn.Text = "OUI";
            this.OuiBtn.UseVisualStyleBackColor = true;
            this.OuiBtn.Click += new System.EventHandler(this.OuiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ATTENTION ! Etes vous sur de vouloir supprimer cette Traversée ?";
            // 
            // ConfirmerSuppTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 132);
            this.Controls.Add(this.NonBtn);
            this.Controls.Add(this.OuiBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmerSuppTra";
            this.Text = "Sicily Lines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NonBtn;
        private System.Windows.Forms.Button OuiBtn;
        private System.Windows.Forms.Label label1;
    }
}