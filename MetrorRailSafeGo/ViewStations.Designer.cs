namespace MetrorRailSafeGo
{
    partial class ViewStations
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
            this.lbltilte = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.bntcancel = new System.Windows.Forms.Label();
            this.bntback = new System.Windows.Forms.Label();
            this.dgvViewStations = new System.Windows.Forms.DataGridView();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStations)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltilte
            // 
            this.lbltilte.AutoSize = true;
            this.lbltilte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltilte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltilte.Location = new System.Drawing.Point(273, 93);
            this.lbltilte.Name = "lbltilte";
            this.lbltilte.Size = new System.Drawing.Size(249, 34);
            this.lbltilte.TabIndex = 54;
            this.lbltilte.Text = "Avaiable Stations";
            this.lbltilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(288, 54);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(211, 27);
            this.lblpname.TabIndex = 55;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // bntcancel
            // 
            this.bntcancel.AutoSize = true;
            this.bntcancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntcancel.Location = new System.Drawing.Point(714, 29);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(28, 27);
            this.bntcancel.TabIndex = 71;
            this.bntcancel.Text = "X";
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // bntback
            // 
            this.bntback.AutoSize = true;
            this.bntback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntback.Location = new System.Drawing.Point(27, 29);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(71, 19);
            this.bntback.TabIndex = 70;
            this.bntback.Text = "<<Back";
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // dgvViewStations
            // 
            this.dgvViewStations.AllowUserToAddRows = false;
            this.dgvViewStations.AllowUserToDeleteRows = false;
            this.dgvViewStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStations.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvViewStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStations.Location = new System.Drawing.Point(2, 212);
            this.dgvViewStations.Name = "dgvViewStations";
            this.dgvViewStations.ReadOnly = true;
            this.dgvViewStations.RowHeadersWidth = 51;
            this.dgvViewStations.RowTemplate.Height = 24;
            this.dgvViewStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewStations.Size = new System.Drawing.Size(762, 465);
            this.dgvViewStations.TabIndex = 72;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnShowDetails.Location = new System.Drawing.Point(13, 171);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(140, 34);
            this.btnShowDetails.TabIndex = 76;
            this.btnShowDetails.Text = "Show All";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(356, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 217;
            this.label9.Text = "Search by destination";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(583, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 35);
            this.btnSearch.TabIndex = 216;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(340, 171);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 35);
            this.txtSearch.TabIndex = 215;
            // 
            // ViewStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 677);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.dgvViewStations);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.bntback);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lbltilte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltilte;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label bntcancel;
        private System.Windows.Forms.Label bntback;
        private System.Windows.Forms.DataGridView dgvViewStations;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}