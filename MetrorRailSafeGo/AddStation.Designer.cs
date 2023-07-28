namespace MetrorRailSafeGo
{
    partial class AddStation
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
            this.bntcancel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDfrom = new System.Windows.Forms.Label();
            this.bntback = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbltilte = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblDto = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgv_Stations = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stations)).BeginInit();
            this.SuspendLayout();
            // 
            // bntcancel
            // 
            this.bntcancel.AutoSize = true;
            this.bntcancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntcancel.Location = new System.Drawing.Point(970, 18);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(28, 27);
            this.bntcancel.TabIndex = 69;
            this.bntcancel.Text = "X";
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(848, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 35);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(848, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 35);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDfrom
            // 
            this.lblDfrom.AutoSize = true;
            this.lblDfrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfrom.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDfrom.Location = new System.Drawing.Point(74, 150);
            this.lblDfrom.Name = "lblDfrom";
            this.lblDfrom.Size = new System.Drawing.Size(145, 23);
            this.lblDfrom.TabIndex = 63;
            this.lblDfrom.Text = "Journey_From";
            // 
            // bntback
            // 
            this.bntback.AutoSize = true;
            this.bntback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntback.Location = new System.Drawing.Point(11, 18);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(71, 19);
            this.bntback.TabIndex = 62;
            this.bntback.Text = "<<Back";
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowDetails.Location = new System.Drawing.Point(0, 382);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(163, 29);
            this.btnShowDetails.TabIndex = 61;
            this.btnShowDetails.Text = "Show Details>>";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(303, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 35);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbltilte
            // 
            this.lbltilte.AutoSize = true;
            this.lbltilte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltilte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltilte.Location = new System.Drawing.Point(370, 80);
            this.lbltilte.Name = "lbltilte";
            this.lbltilte.Size = new System.Drawing.Size(189, 34);
            this.lbltilte.TabIndex = 53;
            this.lbltilte.Text = "Train Stations";
            this.lbltilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(371, 34);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(211, 27);
            this.lblpname.TabIndex = 52;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // lblDto
            // 
            this.lblDto.AutoSize = true;
            this.lblDto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDto.Location = new System.Drawing.Point(92, 205);
            this.lblDto.Name = "lblDto";
            this.lblDto.Size = new System.Drawing.Size(118, 23);
            this.lblDto.TabIndex = 65;
            this.lblDto.Text = "Journey_To";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrice.Location = new System.Drawing.Point(105, 273);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 23);
            this.lblPrice.TabIndex = 73;
            this.lblPrice.Text = "Price";
            // 
            // dgv_Stations
            // 
            this.dgv_Stations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stations.Location = new System.Drawing.Point(0, 421);
            this.dgv_Stations.Name = "dgv_Stations";
            this.dgv_Stations.ReadOnly = true;
            this.dgv_Stations.RowHeadersWidth = 51;
            this.dgv_Stations.RowTemplate.Height = 24;
            this.dgv_Stations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Stations.Size = new System.Drawing.Size(1021, 226);
            this.dgv_Stations.TabIndex = 75;
            this.dgv_Stations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Stations_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(848, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 35);
            this.btnReset.TabIndex = 76;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbFrom
            // 
            this.cmbFrom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "Uttara North\t",
            "Uttara Center",
            "Uttara South",
            "Pallabi",
            "Mirpur 11",
            "Mirpur 10",
            "Kazipara",
            "Shewrapara\t",
            "Agargaon",
            "Bijoy Sarani",
            "Farmgate",
            "Karwan Bazar",
            "Shahbag",
            "Dhaka University",
            "Bangladesh Secretariat",
            "Motijheel"});
            this.cmbFrom.Location = new System.Drawing.Point(254, 144);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(267, 29);
            this.cmbFrom.TabIndex = 77;
            // 
            // cmbTo
            // 
            this.cmbTo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "Uttara North\t",
            "Uttara Center",
            "Uttara South",
            "Pallabi",
            "Mirpur 11",
            "Mirpur 10",
            "Kazipara",
            "Shewrapara\t",
            "Agargaon",
            "Bijoy Sarani",
            "Farmgate",
            "Karwan Bazar",
            "Shahbag",
            "Dhaka University",
            "Bangladesh Secretariat",
            "Motijheel"});
            this.cmbTo.Location = new System.Drawing.Point(254, 204);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(267, 29);
            this.cmbTo.TabIndex = 78;
            // 
            // cmbPrice
            // 
            this.cmbPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Items.AddRange(new object[] {
            "30",
            "40",
            "60",
            "80",
            "100",
            "120",
            "150",
            "170",
            "200"});
            this.cmbPrice.Location = new System.Drawing.Point(254, 267);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(267, 29);
            this.cmbPrice.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(-4, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 20);
            this.label17.TabIndex = 220;
            this.label17.Text = "To see details click here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(527, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 221;
            this.label1.Text = "*Select the starting destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(527, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 222;
            this.label2.Text = "*Select the ending destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(527, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 223;
            this.label3.Text = "*Select the tickect price";
            // 
            // AddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbPrice);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgv_Stations);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDto);
            this.Controls.Add(this.lblDfrom);
            this.Controls.Add(this.bntback);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbltilte);
            this.Controls.Add(this.lblpname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStation";
            this.Load += new System.EventHandler(this.AddStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bntcancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDfrom;
        private System.Windows.Forms.Label bntback;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbltilte;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblDto;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridView dgv_Stations;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}