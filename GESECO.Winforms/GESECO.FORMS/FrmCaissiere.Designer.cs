
namespace GESECO.Winforms.GESECO.FORMS
{
    partial class FrmCaissiere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvEtudiantInscrit = new System.Windows.Forms.DataGridView();
            this.btnImprimer = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiantInscrit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(810, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(732, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(109, 38);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = "Search";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSearch.Location = new System.Drawing.Point(38, 72);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 26);
            this.lblSearch.TabIndex = 90;
            this.lblSearch.Text = "Search :";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.BorderRadius = 15;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(132, 72);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(11);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(596, 26);
            this.tbSearch.TabIndex = 89;
            // 
            // dgvEtudiantInscrit
            // 
            this.dgvEtudiantInscrit.AllowUserToAddRows = false;
            this.dgvEtudiantInscrit.AllowUserToDeleteRows = false;
            this.dgvEtudiantInscrit.AllowUserToOrderColumns = true;
            this.dgvEtudiantInscrit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvEtudiantInscrit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtudiantInscrit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEtudiantInscrit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtudiantInscrit.BackgroundColor = System.Drawing.Color.White;
            this.dgvEtudiantInscrit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEtudiantInscrit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEtudiantInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiantInscrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2});
            this.dgvEtudiantInscrit.Location = new System.Drawing.Point(43, 109);
            this.dgvEtudiantInscrit.Margin = new System.Windows.Forms.Padding(11);
            this.dgvEtudiantInscrit.Name = "dgvEtudiantInscrit";
            this.dgvEtudiantInscrit.ReadOnly = true;
            this.dgvEtudiantInscrit.RowHeadersWidth = 35;
            this.dgvEtudiantInscrit.RowTemplate.Height = 35;
            this.dgvEtudiantInscrit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEtudiantInscrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtudiantInscrit.Size = new System.Drawing.Size(798, 317);
            this.dgvEtudiantInscrit.TabIndex = 92;
            this.dgvEtudiantInscrit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtudiantInscrit_CellDoubleClick);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.BorderRadius = 20;
            this.btnImprimer.CheckedState.Parent = this.btnImprimer;
            this.btnImprimer.CustomImages.Parent = this.btnImprimer;
            this.btnImprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImprimer.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.HoverState.Parent = this.btnImprimer;
            this.btnImprimer.Location = new System.Drawing.Point(291, 432);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(6);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.ShadowDecoration.Parent = this.btnImprimer;
            this.btnImprimer.Size = new System.Drawing.Size(349, 45);
            this.btnImprimer.TabIndex = 93;
            this.btnImprimer.Text = "Imprimer";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Matricule";
            this.Column1.FillWeight = 88.44109F;
            this.Column1.HeaderText = "MATRICULE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Filiere";
            this.Column4.FillWeight = 101.0807F;
            this.Column4.HeaderText = "FILIERE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "AmountPaid";
            this.Column2.HeaderText = "MONTANT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmCaissiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 490);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dgvEtudiantInscrit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCaissiere";
            this.Text = "FrmCaissiere";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiantInscrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvEtudiantInscrit;
        private Guna.UI2.WinForms.Guna2Button btnImprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}