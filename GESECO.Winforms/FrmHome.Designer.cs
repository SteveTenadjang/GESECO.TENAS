
namespace GESECO.Winforms
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlParent = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnTheme = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnAboutUs = new Guna.UI2.WinForms.Guna2Button();
            this.btnAide = new Guna.UI2.WinForms.Guna2Button();
            this.btnParametres = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParent
            // 
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.FillColor = System.Drawing.Color.DimGray;
            this.pnlParent.FillColor2 = System.Drawing.Color.Black;
            this.pnlParent.Location = new System.Drawing.Point(200, 32);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.ShadowDecoration.Parent = this.pnlParent;
            this.pnlParent.Size = new System.Drawing.Size(990, 555);
            this.pnlParent.TabIndex = 6;
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
            this.btnTheme.Location = new System.Drawing.Point(910, 0);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.ShadowDecoration.Parent = this.btnTheme;
            this.btnTheme.Size = new System.Drawing.Size(143, 32);
            this.btnTheme.TabIndex = 9;
            this.btnTheme.Text = "Light Mode";
            this.btnTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.CheckedState.Parent = this.btnMinimized;
            this.btnMinimized.CustomImages.Parent = this.btnMinimized;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FillColor = System.Drawing.Color.Black;
            this.btnMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.HoverState.Parent = this.btnMinimized;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(1053, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.ShadowDecoration.Parent = this.btnMinimized;
            this.btnMinimized.Size = new System.Drawing.Size(45, 32);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.CheckedState.Parent = this.btnMaximize;
            this.btnMaximize.CustomImages.Parent = this.btnMaximize;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Black;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverState.Parent = this.btnMaximize;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1098, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.Parent = this.btnMaximize;
            this.btnMaximize.Size = new System.Drawing.Size(49, 32);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1147, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(43, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbLanguage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.ForeColor = System.Drawing.Color.White;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Francais",
            "Anglais"});
            this.cbLanguage.Location = new System.Drawing.Point(0, 526);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(200, 29);
            this.cbLanguage.TabIndex = 7;
            this.cbLanguage.Text = "Langage";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.guna2Separator1);
            this.pnlMenu.Controls.Add(this.cbLanguage);
            this.pnlMenu.Controls.Add(this.panelLogo);
            this.pnlMenu.Controls.Add(this.btnAboutUs);
            this.pnlMenu.Controls.Add(this.btnAide);
            this.pnlMenu.Controls.Add(this.btnParametres);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 32);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 555);
            this.pnlMenu.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 160);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 160);
            this.panelLogo.TabIndex = 5;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 160);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.CheckedState.Parent = this.btnAboutUs;
            this.btnAboutUs.CustomImages.Parent = this.btnAboutUs;
            this.btnAboutUs.FillColor = System.Drawing.Color.Black;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.HoverState.Parent = this.btnAboutUs;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAboutUs.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAboutUs.Location = new System.Drawing.Point(0, 256);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.ShadowDecoration.Parent = this.btnAboutUs;
            this.btnAboutUs.Size = new System.Drawing.Size(200, 45);
            this.btnAboutUs.TabIndex = 12;
            this.btnAboutUs.Text = "A Propos";
            // 
            // btnAide
            // 
            this.btnAide.CheckedState.Parent = this.btnAide;
            this.btnAide.CustomImages.Parent = this.btnAide;
            this.btnAide.FillColor = System.Drawing.Color.Black;
            this.btnAide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.ForeColor = System.Drawing.Color.White;
            this.btnAide.HoverState.Parent = this.btnAide;
            this.btnAide.Image = ((System.Drawing.Image)(resources.GetObject("btnAide.Image")));
            this.btnAide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAide.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAide.Location = new System.Drawing.Point(0, 211);
            this.btnAide.Name = "btnAide";
            this.btnAide.ShadowDecoration.Parent = this.btnAide;
            this.btnAide.Size = new System.Drawing.Size(200, 45);
            this.btnAide.TabIndex = 11;
            this.btnAide.Text = "Aide";
            // 
            // btnParametres
            // 
            this.btnParametres.CheckedState.Parent = this.btnParametres;
            this.btnParametres.CustomImages.Parent = this.btnParametres;
            this.btnParametres.FillColor = System.Drawing.Color.Black;
            this.btnParametres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametres.ForeColor = System.Drawing.Color.White;
            this.btnParametres.HoverState.Parent = this.btnParametres;
            this.btnParametres.Image = ((System.Drawing.Image)(resources.GetObject("btnParametres.Image")));
            this.btnParametres.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParametres.ImageSize = new System.Drawing.Size(30, 30);
            this.btnParametres.Location = new System.Drawing.Point(0, 166);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.ShadowDecoration.Parent = this.btnParametres;
            this.btnParametres.Size = new System.Drawing.Size(200, 45);
            this.btnParametres.TabIndex = 10;
            this.btnParametres.Text = "Parametres";
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Black;
            this.pnlHead.Controls.Add(this.btnTheme);
            this.pnlHead.Controls.Add(this.btnMinimized);
            this.pnlHead.Controls.Add(this.btnMaximize);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1190, 32);
            this.pnlHead.TabIndex = 4;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 587);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientPanel pnlParent;
        private Guna.UI2.WinForms.Guna2Button btnTheme;
        private Guna.UI2.WinForms.Guna2Button btnMinimized;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnAboutUs;
        private Guna.UI2.WinForms.Guna2Button btnAide;
        private Guna.UI2.WinForms.Guna2Button btnParametres;
        private System.Windows.Forms.Panel pnlHead;
    }
}