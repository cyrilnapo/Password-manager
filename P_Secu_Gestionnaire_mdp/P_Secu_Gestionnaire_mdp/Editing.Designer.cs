﻿namespace P_Secu_Gestionnaire_mdp
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxExt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxMdpConf = new System.Windows.Forms.TextBox();
            this.txtboxMdp = new System.Windows.Forms.TextBox();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(217, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(217, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 53);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Modifier";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(217, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "ex : ch, com, etc..";
            // 
            // txtboxExt
            // 
            this.txtboxExt.Location = new System.Drawing.Point(269, 51);
            this.txtboxExt.Name = "txtboxExt";
            this.txtboxExt.Size = new System.Drawing.Size(47, 23);
            this.txtboxExt.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(205, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Extension :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Entrez vos modifications";
            // 
            // txtboxMdpConf
            // 
            this.txtboxMdpConf.Location = new System.Drawing.Point(99, 152);
            this.txtboxMdpConf.Name = "txtboxMdpConf";
            this.txtboxMdpConf.Size = new System.Drawing.Size(100, 23);
            this.txtboxMdpConf.TabIndex = 23;
            // 
            // txtboxMdp
            // 
            this.txtboxMdp.Location = new System.Drawing.Point(99, 123);
            this.txtboxMdp.Name = "txtboxMdp";
            this.txtboxMdp.Size = new System.Drawing.Size(100, 23);
            this.txtboxMdp.TabIndex = 22;
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(83, 80);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(116, 23);
            this.txtboxId.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Confirmation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Identifiant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Site :";
            // 
            // txtboxSite
            // 
            this.txtboxSite.Location = new System.Drawing.Point(47, 51);
            this.txtboxSite.Name = "txtboxSite";
            this.txtboxSite.Size = new System.Drawing.Size(152, 23);
            this.txtboxSite.TabIndex = 16;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxExt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxMdpConf);
            this.Controls.Add(this.txtboxMdp);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editing";
            this.Text = "Modifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label8;
        private TextBox txtboxExt;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtboxMdpConf;
        private TextBox txtboxMdp;
        private TextBox txtboxId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtboxSite;
    }
}