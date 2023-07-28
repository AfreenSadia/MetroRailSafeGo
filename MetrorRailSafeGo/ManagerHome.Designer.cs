namespace MetrorRailSafeGo
{
    partial class ManagerHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHome));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.panel_customers = new System.Windows.Forms.Panel();
            this.lblemp = new System.Windows.Forms.Label();
            this.pictureBox_clientList = new System.Windows.Forms.PictureBox();
            this.panel_stations = new System.Windows.Forms.Panel();
            this.pictureBox_stations = new System.Windows.Forms.PictureBox();
            this.lblstations = new System.Windows.Forms.Label();
            this.panel_feedback = new System.Windows.Forms.Panel();
            this.pictureBox_feedbacks = new System.Windows.Forms.PictureBox();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.panel_trainScheme = new System.Windows.Forms.Panel();
            this.lblschedule = new System.Windows.Forms.Label();
            this.pictureBox_schedule = new System.Windows.Forms.PictureBox();
            this.panel_bookings = new System.Windows.Forms.Panel();
            this.pictureBox_bookings = new System.Windows.Forms.PictureBox();
            this.lblbookings = new System.Windows.Forms.Label();
            this.panel_outlay = new System.Windows.Forms.Panel();
            this.pictureBox_earnings = new System.Windows.Forms.PictureBox();
            this.lblearnings = new System.Windows.Forms.Label();
            this.panel_profile = new System.Windows.Forms.Panel();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.pictureBox_logout = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_notice = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.panel_availableStations = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblAvailableSt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clientList)).BeginInit();
            this.panel_stations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stations)).BeginInit();
            this.panel_feedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_feedbacks)).BeginInit();
            this.panel_trainScheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schedule)).BeginInit();
            this.panel_bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookings)).BeginInit();
            this.panel_outlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earnings)).BeginInit();
            this.panel_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logout)).BeginInit();
            this.panel_notice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_availableStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.lblwelcome.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Location = new System.Drawing.Point(473, 96);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(202, 44);
            this.lblwelcome.TabIndex = 35;
            this.lblwelcome.Text = "Welcome!";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.MintCream;
            this.lblpname.Location = new System.Drawing.Point(448, 50);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(258, 34);
            this.lblpname.TabIndex = 34;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // panel_customers
            // 
            this.panel_customers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_customers.Controls.Add(this.lblemp);
            this.panel_customers.Controls.Add(this.pictureBox_clientList);
            this.panel_customers.ForeColor = System.Drawing.Color.Coral;
            this.panel_customers.Location = new System.Drawing.Point(438, 211);
            this.panel_customers.Name = "panel_customers";
            this.panel_customers.Size = new System.Drawing.Size(268, 112);
            this.panel_customers.TabIndex = 46;
            this.panel_customers.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemp.Location = new System.Drawing.Point(61, 76);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(144, 27);
            this.lblemp.TabIndex = 8;
            this.lblemp.Text = "CUSTOMERS";
            this.lblemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblemp.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // pictureBox_clientList
            // 
            this.pictureBox_clientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_clientList.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_clientList.Image")));
            this.pictureBox_clientList.Location = new System.Drawing.Point(93, 0);
            this.pictureBox_clientList.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_clientList.Name = "pictureBox_clientList";
            this.pictureBox_clientList.Size = new System.Drawing.Size(85, 66);
            this.pictureBox_clientList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clientList.TabIndex = 7;
            this.pictureBox_clientList.TabStop = false;
            this.pictureBox_clientList.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // panel_stations
            // 
            this.panel_stations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_stations.Controls.Add(this.pictureBox_stations);
            this.panel_stations.Controls.Add(this.lblstations);
            this.panel_stations.ForeColor = System.Drawing.Color.Coral;
            this.panel_stations.Location = new System.Drawing.Point(438, 341);
            this.panel_stations.Name = "panel_stations";
            this.panel_stations.Size = new System.Drawing.Size(268, 116);
            this.panel_stations.TabIndex = 47;
            this.panel_stations.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // pictureBox_stations
            // 
            this.pictureBox_stations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_stations.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_stations.Image")));
            this.pictureBox_stations.Location = new System.Drawing.Point(74, 0);
            this.pictureBox_stations.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_stations.Name = "pictureBox_stations";
            this.pictureBox_stations.Size = new System.Drawing.Size(117, 68);
            this.pictureBox_stations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_stations.TabIndex = 9;
            this.pictureBox_stations.TabStop = false;
            this.pictureBox_stations.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // lblstations
            // 
            this.lblstations.AutoSize = true;
            this.lblstations.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstations.Location = new System.Drawing.Point(76, 77);
            this.lblstations.Name = "lblstations";
            this.lblstations.Size = new System.Drawing.Size(115, 27);
            this.lblstations.TabIndex = 8;
            this.lblstations.Text = "STATIONS";
            this.lblstations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblstations.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // panel_feedback
            // 
            this.panel_feedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_feedback.Controls.Add(this.pictureBox_feedbacks);
            this.panel_feedback.Controls.Add(this.lblfeedback);
            this.panel_feedback.ForeColor = System.Drawing.Color.Coral;
            this.panel_feedback.Location = new System.Drawing.Point(792, 486);
            this.panel_feedback.Name = "panel_feedback";
            this.panel_feedback.Size = new System.Drawing.Size(273, 111);
            this.panel_feedback.TabIndex = 51;
            this.panel_feedback.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // pictureBox_feedbacks
            // 
            this.pictureBox_feedbacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_feedbacks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_feedbacks.Image")));
            this.pictureBox_feedbacks.Location = new System.Drawing.Point(96, 0);
            this.pictureBox_feedbacks.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_feedbacks.Name = "pictureBox_feedbacks";
            this.pictureBox_feedbacks.Size = new System.Drawing.Size(88, 58);
            this.pictureBox_feedbacks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_feedbacks.TabIndex = 9;
            this.pictureBox_feedbacks.TabStop = false;
            this.pictureBox_feedbacks.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfeedback.Location = new System.Drawing.Point(76, 75);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(137, 27);
            this.lblfeedback.TabIndex = 8;
            this.lblfeedback.Text = "FEEDBACKS";
            this.lblfeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblfeedback.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // panel_trainScheme
            // 
            this.panel_trainScheme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_trainScheme.Controls.Add(this.lblschedule);
            this.panel_trainScheme.Controls.Add(this.pictureBox_schedule);
            this.panel_trainScheme.ForeColor = System.Drawing.Color.Coral;
            this.panel_trainScheme.Location = new System.Drawing.Point(438, 481);
            this.panel_trainScheme.Name = "panel_trainScheme";
            this.panel_trainScheme.Size = new System.Drawing.Size(268, 116);
            this.panel_trainScheme.TabIndex = 50;
            this.panel_trainScheme.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // lblschedule
            // 
            this.lblschedule.AutoSize = true;
            this.lblschedule.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblschedule.Location = new System.Drawing.Point(50, 80);
            this.lblschedule.Name = "lblschedule";
            this.lblschedule.Size = new System.Drawing.Size(176, 27);
            this.lblschedule.TabIndex = 8;
            this.lblschedule.Text = "TRAIN-SCHEME";
            this.lblschedule.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // pictureBox_schedule
            // 
            this.pictureBox_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_schedule.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_schedule.Image")));
            this.pictureBox_schedule.Location = new System.Drawing.Point(91, 0);
            this.pictureBox_schedule.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_schedule.Name = "pictureBox_schedule";
            this.pictureBox_schedule.Size = new System.Drawing.Size(92, 63);
            this.pictureBox_schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_schedule.TabIndex = 7;
            this.pictureBox_schedule.TabStop = false;
            this.pictureBox_schedule.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // panel_bookings
            // 
            this.panel_bookings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_bookings.Controls.Add(this.pictureBox_bookings);
            this.panel_bookings.Controls.Add(this.lblbookings);
            this.panel_bookings.ForeColor = System.Drawing.Color.Coral;
            this.panel_bookings.Location = new System.Drawing.Point(792, 341);
            this.panel_bookings.Name = "panel_bookings";
            this.panel_bookings.Size = new System.Drawing.Size(273, 116);
            this.panel_bookings.TabIndex = 49;
            this.panel_bookings.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // pictureBox_bookings
            // 
            this.pictureBox_bookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_bookings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bookings.Image")));
            this.pictureBox_bookings.Location = new System.Drawing.Point(87, 0);
            this.pictureBox_bookings.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_bookings.Name = "pictureBox_bookings";
            this.pictureBox_bookings.Size = new System.Drawing.Size(126, 73);
            this.pictureBox_bookings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bookings.TabIndex = 9;
            this.pictureBox_bookings.TabStop = false;
            this.pictureBox_bookings.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // lblbookings
            // 
            this.lblbookings.AutoSize = true;
            this.lblbookings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbookings.Location = new System.Drawing.Point(82, 77);
            this.lblbookings.Name = "lblbookings";
            this.lblbookings.Size = new System.Drawing.Size(131, 27);
            this.lblbookings.TabIndex = 8;
            this.lblbookings.Text = "BOOKINGS";
            this.lblbookings.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // panel_outlay
            // 
            this.panel_outlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_outlay.Controls.Add(this.pictureBox_earnings);
            this.panel_outlay.Controls.Add(this.lblearnings);
            this.panel_outlay.ForeColor = System.Drawing.Color.Coral;
            this.panel_outlay.Location = new System.Drawing.Point(792, 211);
            this.panel_outlay.Name = "panel_outlay";
            this.panel_outlay.Size = new System.Drawing.Size(273, 112);
            this.panel_outlay.TabIndex = 48;
            this.panel_outlay.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // pictureBox_earnings
            // 
            this.pictureBox_earnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_earnings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_earnings.Image")));
            this.pictureBox_earnings.Location = new System.Drawing.Point(81, 4);
            this.pictureBox_earnings.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_earnings.Name = "pictureBox_earnings";
            this.pictureBox_earnings.Size = new System.Drawing.Size(109, 62);
            this.pictureBox_earnings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_earnings.TabIndex = 9;
            this.pictureBox_earnings.TabStop = false;
            this.pictureBox_earnings.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // lblearnings
            // 
            this.lblearnings.AutoSize = true;
            this.lblearnings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblearnings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblearnings.Location = new System.Drawing.Point(87, 70);
            this.lblearnings.Name = "lblearnings";
            this.lblearnings.Size = new System.Drawing.Size(97, 27);
            this.lblearnings.TabIndex = 8;
            this.lblearnings.Text = "OUTLAY";
            this.lblearnings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblearnings.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // panel_profile
            // 
            this.panel_profile.BackColor = System.Drawing.Color.Black;
            this.panel_profile.Controls.Add(this.pictureBox3);
            this.panel_profile.Controls.Add(this.lblMyProfile);
            this.panel_profile.Location = new System.Drawing.Point(90, 211);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Size = new System.Drawing.Size(265, 112);
            this.panel_profile.TabIndex = 52;
            this.panel_profile.Click += new System.EventHandler(this.lblMyProfile_Click);
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyProfile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMyProfile.Location = new System.Drawing.Point(69, 76);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(137, 27);
            this.lblMyProfile.TabIndex = 1;
            this.lblMyProfile.Text = "MY PROFILE";
            this.lblMyProfile.Click += new System.EventHandler(this.lblMyProfile_Click);
            // 
            // pictureBox_logout
            // 
            this.pictureBox_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.pictureBox_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_logout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logout.Image")));
            this.pictureBox_logout.Location = new System.Drawing.Point(1038, 36);
            this.pictureBox_logout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logout.Name = "pictureBox_logout";
            this.pictureBox_logout.Size = new System.Drawing.Size(62, 40);
            this.pictureBox_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logout.TabIndex = 45;
            this.pictureBox_logout.TabStop = false;
            this.pictureBox_logout.Click += new System.EventHandler(this.pictureBox_logout_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.lblTime.Font = new System.Drawing.Font("Qualy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(91, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 26);
            this.lblTime.TabIndex = 53;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.lblDate.Font = new System.Drawing.Font("Qualy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(91, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 26);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_notice
            // 
            this.panel_notice.BackColor = System.Drawing.Color.Black;
            this.panel_notice.Controls.Add(this.lblNotice);
            this.panel_notice.Controls.Add(this.pictureBox2);
            this.panel_notice.Location = new System.Drawing.Point(90, 351);
            this.panel_notice.Name = "panel_notice";
            this.panel_notice.Size = new System.Drawing.Size(265, 106);
            this.panel_notice.TabIndex = 74;
            this.panel_notice.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(67, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.lblMyProfile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNotice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotice.Location = new System.Drawing.Point(95, 67);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(94, 27);
            this.lblNotice.TabIndex = 75;
            this.lblNotice.Text = "NOTICE";
            this.lblNotice.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // panel_availableStations
            // 
            this.panel_availableStations.BackColor = System.Drawing.Color.Black;
            this.panel_availableStations.Controls.Add(this.lblAvailableSt);
            this.panel_availableStations.Controls.Add(this.pictureBox4);
            this.panel_availableStations.Location = new System.Drawing.Point(93, 489);
            this.panel_availableStations.Name = "panel_availableStations";
            this.panel_availableStations.Size = new System.Drawing.Size(262, 108);
            this.panel_availableStations.TabIndex = 75;
            this.panel_availableStations.Click += new System.EventHandler(this.lblAvailableSt_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(54, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.lblAvailableSt_Click);
            // 
            // lblAvailableSt
            // 
            this.lblAvailableSt.AutoSize = true;
            this.lblAvailableSt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAvailableSt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvailableSt.Location = new System.Drawing.Point(18, 72);
            this.lblAvailableSt.Name = "lblAvailableSt";
            this.lblAvailableSt.Size = new System.Drawing.Size(239, 27);
            this.lblAvailableSt.TabIndex = 76;
            this.lblAvailableSt.Text = "AVAILABLE STATIONS";
            this.lblAvailableSt.Click += new System.EventHandler(this.lblAvailableSt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(20, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 90);
            this.panel1.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(112)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1130, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_availableStations);
            this.Controls.Add(this.panel_notice);
            this.Controls.Add(this.panel_profile);
            this.Controls.Add(this.panel_feedback);
            this.Controls.Add(this.panel_trainScheme);
            this.Controls.Add(this.panel_bookings);
            this.Controls.Add(this.panel_outlay);
            this.Controls.Add(this.panel_stations);
            this.Controls.Add(this.panel_customers);
            this.Controls.Add(this.pictureBox_logout);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lblpname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerhome";
            this.Load += new System.EventHandler(this.ManagerHome_Load_1);
            this.panel_customers.ResumeLayout(false);
            this.panel_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clientList)).EndInit();
            this.panel_stations.ResumeLayout(false);
            this.panel_stations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stations)).EndInit();
            this.panel_feedback.ResumeLayout(false);
            this.panel_feedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_feedbacks)).EndInit();
            this.panel_trainScheme.ResumeLayout(false);
            this.panel_trainScheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schedule)).EndInit();
            this.panel_bookings.ResumeLayout(false);
            this.panel_bookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookings)).EndInit();
            this.panel_outlay.ResumeLayout(false);
            this.panel_outlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earnings)).EndInit();
            this.panel_profile.ResumeLayout(false);
            this.panel_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logout)).EndInit();
            this.panel_notice.ResumeLayout(false);
            this.panel_notice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_availableStations.ResumeLayout(false);
            this.panel_availableStations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.PictureBox pictureBox_logout;
        private System.Windows.Forms.Panel panel_customers;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.PictureBox pictureBox_clientList;
        private System.Windows.Forms.Panel panel_stations;
        private System.Windows.Forms.Label lblstations;
        private System.Windows.Forms.Panel panel_feedback;
        private System.Windows.Forms.PictureBox pictureBox_feedbacks;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.PictureBox pictureBox_bookings;
        private System.Windows.Forms.PictureBox pictureBox_schedule;
        private System.Windows.Forms.Panel panel_trainScheme;
        private System.Windows.Forms.Label lblschedule;
        private System.Windows.Forms.Panel panel_bookings;
        private System.Windows.Forms.Label lblbookings;
        private System.Windows.Forms.Panel panel_outlay;
        private System.Windows.Forms.PictureBox pictureBox_earnings;
        private System.Windows.Forms.Label lblearnings;
        private System.Windows.Forms.PictureBox pictureBox_stations;
        private System.Windows.Forms.Panel panel_profile;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_notice;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_availableStations;
        private System.Windows.Forms.Label lblAvailableSt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}