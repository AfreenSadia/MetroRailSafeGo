namespace MetrorRailSafeGo
{
    partial class Feedback
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
            this.bntback = new System.Windows.Forms.Label();
            this.lbltilte = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSender = new System.Windows.Forms.RichTextBox();
            this.txtReceiver = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // bntcancel
            // 
            this.bntcancel.AutoSize = true;
            this.bntcancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntcancel.Location = new System.Drawing.Point(758, 21);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(28, 27);
            this.bntcancel.TabIndex = 208;
            this.bntcancel.Text = "X";
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // bntback
            // 
            this.bntback.AutoSize = true;
            this.bntback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntback.Location = new System.Drawing.Point(9, 29);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(71, 19);
            this.bntback.TabIndex = 207;
            this.bntback.Text = "<<Back";
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // lbltilte
            // 
            this.lbltilte.AutoSize = true;
            this.lbltilte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltilte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltilte.Location = new System.Drawing.Point(240, 128);
            this.lbltilte.Name = "lbltilte";
            this.lbltilte.Size = new System.Drawing.Size(296, 34);
            this.lbltilte.TabIndex = 206;
            this.lbltilte.Text = "Employee Feedback";
            this.lbltilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(256, 49);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(258, 34);
            this.lblpname.TabIndex = 205;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(107, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 384);
            this.panel1.TabIndex = 209;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSender);
            this.panel2.Controls.Add(this.txtReceiver);
            this.panel2.Location = new System.Drawing.Point(138, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 175);
            this.panel2.TabIndex = 2;
            // 
            // txtSender
            // 
            this.txtSender.ForeColor = System.Drawing.Color.Silver;
            this.txtSender.Location = new System.Drawing.Point(0, 86);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(318, 86);
            this.txtSender.TabIndex = 0;
            this.txtSender.Text = "Write your feedback Here";
            this.txtSender.Enter += new System.EventHandler(this.txtSender_Enter);
            this.txtSender.Leave += new System.EventHandler(this.txtSender_Leave);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(0, 0);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.ReadOnly = true;
            this.txtReceiver.Size = new System.Drawing.Size(318, 88);
            this.txtReceiver.TabIndex = 0;
            this.txtReceiver.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(252, 293);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(64, 113);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.Size = new System.Drawing.Size(10, 17);
            this.dgvFeedback.TabIndex = 210;
            this.dgvFeedback.Visible = false;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(802, 652);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.bntback);
            this.Controls.Add(this.lbltilte);
            this.Controls.Add(this.lblpname);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bntcancel;
        private System.Windows.Forms.Label bntback;
        private System.Windows.Forms.Label lbltilte;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtReceiver;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtSender;
        private System.Windows.Forms.DataGridView dgvFeedback;
    }
}