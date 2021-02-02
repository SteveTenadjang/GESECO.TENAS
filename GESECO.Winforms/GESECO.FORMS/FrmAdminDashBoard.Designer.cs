
namespace GESECO.Winforms.GESECO.FORMS
{
    partial class FrmAdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashBoard));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnTheme = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.bntClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBack = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbCarteEtudiant = new MetroFramework.Controls.MetroLabel();
            this.lbCertificate = new MetroFramework.Controls.MetroLabel();
            this.btnCertificate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCarte = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayement = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjoutEtudiant = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjoutMembre = new Guna.UI2.WinForms.Guna2Button();
            this.btnListeEtudiant = new Guna.UI2.WinForms.Guna2Button();
            this.btnHeader = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gnSeperator = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHead.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.btnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Brown;
            this.pnlHead.CausesValidation = false;
            this.pnlHead.Controls.Add(this.btnTheme);
            this.pnlHead.Controls.Add(this.btnMinimized);
            this.pnlHead.Controls.Add(this.btnMaximize);
            this.pnlHead.Controls.Add(this.bntClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(847, 42);
            this.pnlHead.TabIndex = 5;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // btnTheme
            // 
            this.btnTheme.BorderColor = System.Drawing.Color.Transparent;
            this.btnTheme.CheckedState.Parent = this.btnTheme;
            this.btnTheme.CustomImages.Image = global::GESECO.Winforms.Properties.Resources.icons8_sun_48;
            this.btnTheme.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTheme.CustomImages.Parent = this.btnTheme;
            this.btnTheme.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTheme.FillColor = System.Drawing.Color.Transparent;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.HoverState.Parent = this.btnTheme;
            this.btnTheme.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTheme.Location = new System.Drawing.Point(567, 0);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.ShadowDecoration.Parent = this.btnTheme;
            this.btnTheme.Size = new System.Drawing.Size(143, 42);
            this.btnTheme.TabIndex = 9;
            this.btnTheme.Text = "Light Mode";
            this.btnTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.CheckedState.Parent = this.btnMinimized;
            this.btnMinimized.CustomImages.Parent = this.btnMinimized;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.HoverState.Parent = this.btnMinimized;
            this.btnMinimized.Location = new System.Drawing.Point(710, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.ShadowDecoration.Parent = this.btnMinimized;
            this.btnMinimized.Size = new System.Drawing.Size(45, 42);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.Text = "-";
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.CheckedState.Parent = this.btnMaximize;
            this.btnMaximize.CustomImages.Parent = this.btnMaximize;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverState.Parent = this.btnMaximize;
            this.btnMaximize.Location = new System.Drawing.Point(755, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.Parent = this.btnMaximize;
            this.btnMaximize.Size = new System.Drawing.Size(49, 42);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "O";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // bntClose
            // 
            this.bntClose.CheckedState.Parent = this.bntClose;
            this.bntClose.CustomImages.Parent = this.bntClose;
            this.bntClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntClose.FillColor = System.Drawing.Color.Transparent;
            this.bntClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.bntClose.ForeColor = System.Drawing.Color.Red;
            this.bntClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.bntClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.bntClose.HoverState.Parent = this.bntClose;
            this.bntClose.Location = new System.Drawing.Point(804, 0);
            this.bntClose.Name = "bntClose";
            this.bntClose.ShadowDecoration.Parent = this.bntClose;
            this.bntClose.Size = new System.Drawing.Size(43, 42);
            this.bntClose.TabIndex = 3;
            this.bntClose.Text = "X";
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.groupBox);
            this.pnlBack.Controls.Add(this.btnPayement);
            this.pnlBack.Controls.Add(this.btnAjoutEtudiant);
            this.pnlBack.Controls.Add(this.btnAjoutMembre);
            this.pnlBack.Controls.Add(this.btnListeEtudiant);
            this.pnlBack.Controls.Add(this.btnHeader);
            this.pnlBack.Controls.Add(this.gnSeperator);
            this.pnlBack.Controls.Add(this.pictureBox2);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 42);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.ShadowDecoration.Parent = this.pnlBack;
            this.pnlBack.Size = new System.Drawing.Size(847, 497);
            this.pnlBack.TabIndex = 6;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox.Controls.Add(this.lbCarteEtudiant);
            this.groupBox.Controls.Add(this.lbCertificate);
            this.groupBox.Controls.Add(this.btnCertificate);
            this.groupBox.Controls.Add(this.btnCarte);
            this.groupBox.CustomBorderColor = System.Drawing.Color.Brown;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(524, 202);
            this.groupBox.Name = "groupBox";
            this.groupBox.ShadowDecoration.Parent = this.groupBox;
            this.groupBox.Size = new System.Drawing.Size(303, 269);
            this.groupBox.TabIndex = 100;
            this.groupBox.Text = "Demande D\'impression de documents";
            // 
            // lbCarteEtudiant
            // 
            this.lbCarteEtudiant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCarteEtudiant.BackColor = System.Drawing.Color.Transparent;
            this.lbCarteEtudiant.Location = new System.Drawing.Point(271, 179);
            this.lbCarteEtudiant.Name = "lbCarteEtudiant";
            this.lbCarteEtudiant.Size = new System.Drawing.Size(16, 19);
            this.lbCarteEtudiant.TabIndex = 8;
            this.lbCarteEtudiant.Text = "5";
            // 
            // lbCertificate
            // 
            this.lbCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCertificate.BackColor = System.Drawing.Color.Transparent;
            this.lbCertificate.Location = new System.Drawing.Point(271, 60);
            this.lbCertificate.Name = "lbCertificate";
            this.lbCertificate.Size = new System.Drawing.Size(16, 19);
            this.lbCertificate.TabIndex = 5;
            this.lbCertificate.Text = "5";
            // 
            // btnCertificate
            // 
            this.btnCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCertificate.BackColor = System.Drawing.Color.Transparent;
            this.btnCertificate.BorderRadius = 10;
            this.btnCertificate.CheckedState.Parent = this.btnCertificate;
            this.btnCertificate.CustomImages.Parent = this.btnCertificate;
            this.btnCertificate.FillColor = System.Drawing.Color.Brown;
            this.btnCertificate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCertificate.ForeColor = System.Drawing.Color.White;
            this.btnCertificate.HoverState.Parent = this.btnCertificate;
            this.btnCertificate.Location = new System.Drawing.Point(16, 60);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.ShadowDecoration.Parent = this.btnCertificate;
            this.btnCertificate.Size = new System.Drawing.Size(271, 74);
            this.btnCertificate.TabIndex = 5;
            this.btnCertificate.Text = "Certificate de scolarite";
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click_1);
            // 
            // btnCarte
            // 
            this.btnCarte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarte.BackColor = System.Drawing.Color.Transparent;
            this.btnCarte.BorderRadius = 10;
            this.btnCarte.CheckedState.Parent = this.btnCarte;
            this.btnCarte.CustomImages.Parent = this.btnCarte;
            this.btnCarte.FillColor = System.Drawing.Color.Brown;
            this.btnCarte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCarte.ForeColor = System.Drawing.Color.White;
            this.btnCarte.HoverState.Parent = this.btnCarte;
            this.btnCarte.Location = new System.Drawing.Point(16, 179);
            this.btnCarte.Name = "btnCarte";
            this.btnCarte.ShadowDecoration.Parent = this.btnCarte;
            this.btnCarte.Size = new System.Drawing.Size(271, 74);
            this.btnCarte.TabIndex = 6;
            this.btnCarte.Text = "Carte Etudiant";
            this.btnCarte.Click += new System.EventHandler(this.btnCarte_Click_1);
            // 
            // btnPayement
            // 
            this.btnPayement.BackColor = System.Drawing.Color.Transparent;
            this.btnPayement.BorderColor = System.Drawing.Color.Transparent;
            this.btnPayement.BorderRadius = 15;
            this.btnPayement.CheckedState.Parent = this.btnPayement;
            this.btnPayement.CustomImages.Parent = this.btnPayement;
            this.btnPayement.FillColor = System.Drawing.Color.Brown;
            this.btnPayement.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayement.ForeColor = System.Drawing.Color.White;
            this.btnPayement.HoverState.Parent = this.btnPayement;
            this.btnPayement.Location = new System.Drawing.Point(20, 202);
            this.btnPayement.Name = "btnPayement";
            this.btnPayement.ShadowDecoration.Parent = this.btnPayement;
            this.btnPayement.Size = new System.Drawing.Size(231, 115);
            this.btnPayement.TabIndex = 99;
            this.btnPayement.Text = "Payement";
            this.btnPayement.Click += new System.EventHandler(this.btnPayement_Click_1);
            // 
            // btnAjoutEtudiant
            // 
            this.btnAjoutEtudiant.BackColor = System.Drawing.Color.Transparent;
            this.btnAjoutEtudiant.BorderColor = System.Drawing.Color.Transparent;
            this.btnAjoutEtudiant.BorderRadius = 15;
            this.btnAjoutEtudiant.CheckedState.Parent = this.btnAjoutEtudiant;
            this.btnAjoutEtudiant.CustomImages.Parent = this.btnAjoutEtudiant;
            this.btnAjoutEtudiant.FillColor = System.Drawing.Color.Brown;
            this.btnAjoutEtudiant.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutEtudiant.ForeColor = System.Drawing.Color.White;
            this.btnAjoutEtudiant.HoverState.Parent = this.btnAjoutEtudiant;
            this.btnAjoutEtudiant.Location = new System.Drawing.Point(278, 202);
            this.btnAjoutEtudiant.Name = "btnAjoutEtudiant";
            this.btnAjoutEtudiant.ShadowDecoration.Parent = this.btnAjoutEtudiant;
            this.btnAjoutEtudiant.Size = new System.Drawing.Size(231, 115);
            this.btnAjoutEtudiant.TabIndex = 98;
            this.btnAjoutEtudiant.Text = "Ajouter un Etudiant";
            this.btnAjoutEtudiant.Click += new System.EventHandler(this.btnAjoutEtudiant_Click);
            // 
            // btnAjoutMembre
            // 
            this.btnAjoutMembre.BackColor = System.Drawing.Color.Transparent;
            this.btnAjoutMembre.BorderColor = System.Drawing.Color.Transparent;
            this.btnAjoutMembre.BorderRadius = 15;
            this.btnAjoutMembre.CheckedState.Parent = this.btnAjoutMembre;
            this.btnAjoutMembre.CustomImages.Parent = this.btnAjoutMembre;
            this.btnAjoutMembre.FillColor = System.Drawing.Color.Brown;
            this.btnAjoutMembre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutMembre.ForeColor = System.Drawing.Color.White;
            this.btnAjoutMembre.HoverState.Parent = this.btnAjoutMembre;
            this.btnAjoutMembre.Location = new System.Drawing.Point(20, 356);
            this.btnAjoutMembre.Name = "btnAjoutMembre";
            this.btnAjoutMembre.ShadowDecoration.Parent = this.btnAjoutMembre;
            this.btnAjoutMembre.Size = new System.Drawing.Size(231, 115);
            this.btnAjoutMembre.TabIndex = 97;
            this.btnAjoutMembre.Text = "Ajouter un Membre";
            this.btnAjoutMembre.Click += new System.EventHandler(this.btnAjoutMembre_Click_1);
            // 
            // btnListeEtudiant
            // 
            this.btnListeEtudiant.BackColor = System.Drawing.Color.Transparent;
            this.btnListeEtudiant.BorderColor = System.Drawing.Color.Transparent;
            this.btnListeEtudiant.BorderRadius = 15;
            this.btnListeEtudiant.CheckedState.Parent = this.btnListeEtudiant;
            this.btnListeEtudiant.CustomImages.Parent = this.btnListeEtudiant;
            this.btnListeEtudiant.FillColor = System.Drawing.Color.Brown;
            this.btnListeEtudiant.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEtudiant.ForeColor = System.Drawing.Color.White;
            this.btnListeEtudiant.HoverState.Parent = this.btnListeEtudiant;
            this.btnListeEtudiant.Location = new System.Drawing.Point(278, 356);
            this.btnListeEtudiant.Name = "btnListeEtudiant";
            this.btnListeEtudiant.ShadowDecoration.Parent = this.btnListeEtudiant;
            this.btnListeEtudiant.Size = new System.Drawing.Size(231, 115);
            this.btnListeEtudiant.TabIndex = 104;
            this.btnListeEtudiant.Text = "Liste des Etudiants";
            this.btnListeEtudiant.Click += new System.EventHandler(this.btnListeEtudiant_Click_1);
            // 
            // btnHeader
            // 
            this.btnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeader.BackColor = System.Drawing.Color.Transparent;
            this.btnHeader.BorderColor = System.Drawing.Color.Maroon;
            this.btnHeader.BorderRadius = 20;
            this.btnHeader.Controls.Add(this.guna2Button4);
            this.btnHeader.Controls.Add(this.guna2HtmlLabel1);
            this.btnHeader.FillColor = System.Drawing.Color.Brown;
            this.btnHeader.FillColor2 = System.Drawing.Color.Brown;
            this.btnHeader.FillColor3 = System.Drawing.Color.Brown;
            this.btnHeader.FillColor4 = System.Drawing.Color.Brown;
            this.btnHeader.Location = new System.Drawing.Point(20, 26);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.ShadowDecoration.Parent = this.btnHeader;
            this.btnHeader.Size = new System.Drawing.Size(639, 97);
            this.btnHeader.TabIndex = 101;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 24;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.CheckedState.Image")));
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2Button4.Location = new System.Drawing.Point(0, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(95, 97);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(212, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(277, 48);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Administration";
            // 
            // gnSeperator
            // 
            this.gnSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnSeperator.BackColor = System.Drawing.Color.Transparent;
            this.gnSeperator.FillColor = System.Drawing.Color.Brown;
            this.gnSeperator.FillThickness = 2;
            this.gnSeperator.Location = new System.Drawing.Point(120, 147);
            this.gnSeperator.Name = "gnSeperator";
            this.gnSeperator.Size = new System.Drawing.Size(591, 21);
            this.gnSeperator.TabIndex = 103;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(677, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 539);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminDashBoard";
            this.Text = "FrmAdminDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHead.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.btnHeader.ResumeLayout(false);
            this.btnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private Guna.UI2.WinForms.Guna2Button btnTheme;
        private Guna.UI2.WinForms.Guna2Button btnMinimized;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button bntClose;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBack;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private MetroFramework.Controls.MetroLabel lbCarteEtudiant;
        private MetroFramework.Controls.MetroLabel lbCertificate;
        private Guna.UI2.WinForms.Guna2Button btnCertificate;
        private Guna.UI2.WinForms.Guna2Button btnCarte;
        private Guna.UI2.WinForms.Guna2Button btnPayement;
        private Guna.UI2.WinForms.Guna2Button btnAjoutEtudiant;
        private Guna.UI2.WinForms.Guna2Button btnAjoutMembre;
        private Guna.UI2.WinForms.Guna2Button btnListeEtudiant;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel btnHeader;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator gnSeperator;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}