namespace MetrorRailSafeGo
{
    partial class FeedbackAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSender = new System.Windows.Forms.RichTextBox();
            this.txtReciever = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.bntcancel = new System.Windows.Forms.Label();
            this.bntback = new System.Windows.Forms.Label();
            this.lbltilte = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSender);
            this.panel1.Controls.Add(this.txtReciever);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(133, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 384);
            this.panel1.TabIndex = 214;
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.Color.Honeydew;
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.ForeColor = System.Drawing.Color.Silver;
            this.txtSender.Location = new System.Drawing.Point(122, 188);
            this.txtSender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(340, 87);
            this.txtSender.TabIndex = 218;
            this.txtSender.Text = "Write your feedback Here";
            this.txtSender.Enter += new System.EventHandler(this.txtSender_Enter);
            this.txtSender.Leave += new System.EventHandler(this.txtSender_Leave);
            // 
            // txtReciever
            // 
            this.txtReciever.BackColor = System.Drawing.Color.Honeydew;
            this.txtReciever.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReciever.Location = new System.Drawing.Point(131, 57);
            this.txtReciever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.ReadOnly = true;
            this.txtReciever.Size = new System.Drawing.Size(340, 87);
            this.txtReciever.TabIndex = 218;
            this.txtReciever.Text = "";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(113, 289);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 217;
            this.btnView.Text = "View ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(396, 289);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bntcancel
            // 
            this.bntcancel.AutoSize = true;
            this.bntcancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntcancel.Location = new System.Drawing.Point(785, 28);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(28, 27);
            this.bntcancel.TabIndex = 213;
            this.bntcancel.Text = "X";
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // bntback
            // 
            this.bntback.AutoSize = true;
            this.bntback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntback.Location = new System.Drawing.Point(36, 36);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(71, 19);
            this.bntback.TabIndex = 212;
            this.bntback.Text = "<<Back";
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // lbltilte
            // 
            this.lbltilte.AutoSize = true;
            this.lbltilte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltilte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltilte.Location = new System.Drawing.Point(229, 137);
            this.lbltilte.Name = "lbltilte";
            this.lbltilte.Size = new System.Drawing.Size(389, 34);
            this.lbltilte.TabIndex = 211;
            this.lbltilte.Text = "View Employee\'s Feedback";
            this.lbltilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(283, 57);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(258, 34);
            this.lblpname.TabIndex = 210;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(91, 107);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.RowTemplate.Height = 24;
            this.dgvFeedback.Size = new System.Drawing.Size(15, 30);
            this.dgvFeedback.TabIndex = 215;
            this.dgvFeedback.Visible = false;
            // 
            // FeedbackAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(849, 612);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.bntback);
            this.Controls.Add(this.lbltilte);
            this.Controls.Add(this.lblpname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FeedbackAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedbackAdmin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label bntcancel;
        private System.Windows.Forms.Label bntback;
        private System.Windows.Forms.Label lbltilte;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RichTextBox txtReciever;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.RichTextBox txtSender;
    }
}