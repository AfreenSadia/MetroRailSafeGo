namespace MetrorRailSafeGo
{
    partial class NoticeSend
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
            this.bntback = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.bntcancel = new System.Windows.Forms.Label();
            this.lbltilte = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntback
            // 
            this.bntback.AutoSize = true;
            this.bntback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntback.Location = new System.Drawing.Point(10, 18);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(71, 19);
            this.bntback.TabIndex = 209;
            this.bntback.Text = "<<Back";
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpname.Location = new System.Drawing.Point(257, 38);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(258, 34);
            this.lblpname.TabIndex = 208;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // bntcancel
            // 
            this.bntcancel.AutoSize = true;
            this.bntcancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bntcancel.Location = new System.Drawing.Point(780, 12);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(28, 27);
            this.bntcancel.TabIndex = 210;
            this.bntcancel.Text = "X";
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // lbltilte
            // 
            this.lbltilte.AutoSize = true;
            this.lbltilte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltilte.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbltilte.Location = new System.Drawing.Point(277, 128);
            this.lbltilte.Name = "lbltilte";
            this.lbltilte.Size = new System.Drawing.Size(193, 34);
            this.lbltilte.TabIndex = 211;
            this.lbltilte.Text = "Post a Notice";
            this.lbltilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.SystemColors.Control;
            this.txtSender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSender.Location = new System.Drawing.Point(106, 185);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(532, 228);
            this.txtSender.TabIndex = 212;
            this.txtSender.Text = "Post a notice here";
            this.txtSender.Enter += new System.EventHandler(this.txtSender_Enter);
            this.txtSender.Leave += new System.EventHandler(this.txtSender_Leave);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(336, 440);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 213;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // NoticeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.lbltilte);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.bntback);
            this.Controls.Add(this.lblpname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoticeSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write here...";
            this.Enter += new System.EventHandler(this.txtSender_Leave);
            this.Leave += new System.EventHandler(this.txtSender_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bntback;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label bntcancel;
        private System.Windows.Forms.Label lbltilte;
        private System.Windows.Forms.RichTextBox txtSender;
        private System.Windows.Forms.Button btnSend;
    }
}