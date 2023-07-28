namespace MetrorRailSafeGo
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.lblpname = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.panel_station = new System.Windows.Forms.Panel();
            this.lblstations = new System.Windows.Forms.Label();
            this.panel_earning = new System.Windows.Forms.Panel();
            this.lblearnings = new System.Windows.Forms.Label();
            this.panel_feedback = new System.Windows.Forms.Panel();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.panel_trainScheme = new System.Windows.Forms.Panel();
            this.lblschedule = new System.Windows.Forms.Label();
            this.panel_booking = new System.Windows.Forms.Panel();
            this.lblbookings = new System.Windows.Forms.Label();
            this.lblemp = new System.Windows.Forms.Label();
            this.panel_employee = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panel_customer = new System.Windows.Forms.Panel();
            this.panel_salary = new System.Windows.Forms.Panel();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logout = new System.Windows.Forms.PictureBox();
            this.pictureBox_feedbacks = new System.Windows.Forms.PictureBox();
            this.pictureBox_schedule = new System.Windows.Forms.PictureBox();
            this.pictureBox_bookings = new System.Windows.Forms.PictureBox();
            this.pictureBox_earnings = new System.Windows.Forms.PictureBox();
            this.pictureBox_stations = new System.Windows.Forms.PictureBox();
            this.pictureBox_clientList = new System.Windows.Forms.PictureBox();
            this.panel_notice = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.panel_station.SuspendLayout();
            this.panel_earning.SuspendLayout();
            this.panel_feedback.SuspendLayout();
            this.panel_trainScheme.SuspendLayout();
            this.panel_booking.SuspendLayout();
            this.panel_employee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_customer.SuspendLayout();
            this.panel_salary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_feedbacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clientList)).BeginInit();
            this.panel_notice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(73)))));
            this.lblpname.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.ForeColor = System.Drawing.Color.Transparent;
            this.lblpname.Location = new System.Drawing.Point(441, 58);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(258, 34);
            this.lblpname.TabIndex = 28;
            this.lblpname.Text = "Metro Rail SafeGo";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(73)))));
            this.lblwelcome.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Location = new System.Drawing.Point(404, 101);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(329, 44);
            this.lblwelcome.TabIndex = 33;
            this.lblwelcome.Text = "Welcome Admin!";
            // 
            // panel_station
            // 
            this.panel_station.BackColor = System.Drawing.Color.Black;
            this.panel_station.Controls.Add(this.lblstations);
            this.panel_station.Controls.Add(this.pictureBox_stations);
            this.panel_station.ForeColor = System.Drawing.Color.Coral;
            this.panel_station.Location = new System.Drawing.Point(153, 353);
            this.panel_station.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_station.Name = "panel_station";
            this.panel_station.Size = new System.Drawing.Size(224, 138);
            this.panel_station.TabIndex = 38;
            this.panel_station.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // lblstations
            // 
            this.lblstations.AutoSize = true;
            this.lblstations.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstations.Location = new System.Drawing.Point(49, 97);
            this.lblstations.Name = "lblstations";
            this.lblstations.Size = new System.Drawing.Size(115, 27);
            this.lblstations.TabIndex = 8;
            this.lblstations.Text = "STATIONS";
            this.lblstations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblstations.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // panel_earning
            // 
            this.panel_earning.BackColor = System.Drawing.Color.Black;
            this.panel_earning.Controls.Add(this.pictureBox_earnings);
            this.panel_earning.Controls.Add(this.lblearnings);
            this.panel_earning.ForeColor = System.Drawing.Color.Coral;
            this.panel_earning.Location = new System.Drawing.Point(716, 188);
            this.panel_earning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_earning.Name = "panel_earning";
            this.panel_earning.Size = new System.Drawing.Size(225, 138);
            this.panel_earning.TabIndex = 39;
            this.panel_earning.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // lblearnings
            // 
            this.lblearnings.AutoSize = true;
            this.lblearnings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblearnings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblearnings.Location = new System.Drawing.Point(51, 97);
            this.lblearnings.Name = "lblearnings";
            this.lblearnings.Size = new System.Drawing.Size(125, 27);
            this.lblearnings.TabIndex = 8;
            this.lblearnings.Text = "EARNINGS";
            this.lblearnings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblearnings.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // panel_feedback
            // 
            this.panel_feedback.BackColor = System.Drawing.Color.Black;
            this.panel_feedback.Controls.Add(this.pictureBox_feedbacks);
            this.panel_feedback.Controls.Add(this.lblfeedback);
            this.panel_feedback.ForeColor = System.Drawing.Color.Coral;
            this.panel_feedback.Location = new System.Drawing.Point(726, 353);
            this.panel_feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_feedback.Name = "panel_feedback";
            this.panel_feedback.Size = new System.Drawing.Size(225, 137);
            this.panel_feedback.TabIndex = 42;
            this.panel_feedback.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfeedback.Location = new System.Drawing.Point(39, 87);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(137, 27);
            this.lblfeedback.TabIndex = 8;
            this.lblfeedback.Text = "FEEDBACKS";
            this.lblfeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblfeedback.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // panel_trainScheme
            // 
            this.panel_trainScheme.BackColor = System.Drawing.Color.Black;
            this.panel_trainScheme.Controls.Add(this.lblschedule);
            this.panel_trainScheme.Controls.Add(this.pictureBox_schedule);
            this.panel_trainScheme.ForeColor = System.Drawing.Color.Coral;
            this.panel_trainScheme.Location = new System.Drawing.Point(439, 188);
            this.panel_trainScheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_trainScheme.Name = "panel_trainScheme";
            this.panel_trainScheme.Size = new System.Drawing.Size(224, 137);
            this.panel_trainScheme.TabIndex = 41;
            this.panel_trainScheme.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // lblschedule
            // 
            this.lblschedule.AutoSize = true;
            this.lblschedule.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblschedule.Location = new System.Drawing.Point(14, 96);
            this.lblschedule.Name = "lblschedule";
            this.lblschedule.Size = new System.Drawing.Size(196, 27);
            this.lblschedule.TabIndex = 8;
            this.lblschedule.Text = "TRAIN-SCHEDULE";
            this.lblschedule.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // panel_booking
            // 
            this.panel_booking.BackColor = System.Drawing.Color.Black;
            this.panel_booking.Controls.Add(this.pictureBox_bookings);
            this.panel_booking.Controls.Add(this.lblbookings);
            this.panel_booking.ForeColor = System.Drawing.Color.Coral;
            this.panel_booking.Location = new System.Drawing.Point(439, 353);
            this.panel_booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_booking.Name = "panel_booking";
            this.panel_booking.Size = new System.Drawing.Size(224, 137);
            this.panel_booking.TabIndex = 40;
            this.panel_booking.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // lblbookings
            // 
            this.lblbookings.AutoSize = true;
            this.lblbookings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbookings.Location = new System.Drawing.Point(47, 87);
            this.lblbookings.Name = "lblbookings";
            this.lblbookings.Size = new System.Drawing.Size(131, 27);
            this.lblbookings.TabIndex = 8;
            this.lblbookings.Text = "BOOKINGS";
            this.lblbookings.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemp.Location = new System.Drawing.Point(38, 97);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(137, 27);
            this.lblemp.TabIndex = 8;
            this.lblemp.Text = "EMPLOYEES";
            this.lblemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblemp.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // panel_employee
            // 
            this.panel_employee.BackColor = System.Drawing.Color.Black;
            this.panel_employee.Controls.Add(this.lblemp);
            this.panel_employee.Controls.Add(this.pictureBox_clientList);
            this.panel_employee.ForeColor = System.Drawing.Color.Coral;
            this.panel_employee.Location = new System.Drawing.Point(151, 187);
            this.panel_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Size = new System.Drawing.Size(226, 138);
            this.panel_employee.TabIndex = 35;
            this.panel_employee.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(73)))));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(102, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 26);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(73)))));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(102, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 26);
            this.lblTime.TabIndex = 55;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 112);
            this.panel1.TabIndex = 57;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomer.Location = new System.Drawing.Point(49, 87);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(144, 27);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "CUSTOMERS";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // panel_customer
            // 
            this.panel_customer.BackColor = System.Drawing.Color.Black;
            this.panel_customer.Controls.Add(this.pictureBox2);
            this.panel_customer.Controls.Add(this.lblCustomer);
            this.panel_customer.Location = new System.Drawing.Point(153, 532);
            this.panel_customer.Name = "panel_customer";
            this.panel_customer.Size = new System.Drawing.Size(223, 126);
            this.panel_customer.TabIndex = 58;
            this.panel_customer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // panel_salary
            // 
            this.panel_salary.BackColor = System.Drawing.Color.Black;
            this.panel_salary.Controls.Add(this.lblEmpSalary);
            this.panel_salary.Controls.Add(this.pictureBox4);
            this.panel_salary.Location = new System.Drawing.Point(442, 528);
            this.panel_salary.Name = "panel_salary";
            this.panel_salary.Size = new System.Drawing.Size(220, 129);
            this.panel_salary.TabIndex = 59;
            this.panel_salary.Click += new System.EventHandler(this.lblEmpSalary_Click);
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpSalary.Location = new System.Drawing.Point(3, 92);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(214, 27);
            this.lblEmpSalary.TabIndex = 60;
            this.lblEmpSalary.Text = "EMPLOYEE SALARY";
            this.lblEmpSalary.Click += new System.EventHandler(this.lblEmpSalary_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(43, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(137, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.lblEmpSalary_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_logout
            // 
            this.pictureBox_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_logout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logout.Image")));
            this.pictureBox_logout.Location = new System.Drawing.Point(1016, 39);
            this.pictureBox_logout.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logout.Name = "pictureBox_logout";
            this.pictureBox_logout.Size = new System.Drawing.Size(61, 39);
            this.pictureBox_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logout.TabIndex = 44;
            this.pictureBox_logout.TabStop = false;
            this.pictureBox_logout.Click += new System.EventHandler(this.pictureBox_logout_Click);
            // 
            // pictureBox_feedbacks
            // 
            this.pictureBox_feedbacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_feedbacks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_feedbacks.Image")));
            this.pictureBox_feedbacks.Location = new System.Drawing.Point(32, 0);
            this.pictureBox_feedbacks.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_feedbacks.Name = "pictureBox_feedbacks";
            this.pictureBox_feedbacks.Size = new System.Drawing.Size(144, 83);
            this.pictureBox_feedbacks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_feedbacks.TabIndex = 9;
            this.pictureBox_feedbacks.TabStop = false;
            this.pictureBox_feedbacks.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // pictureBox_schedule
            // 
            this.pictureBox_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_schedule.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_schedule.Image")));
            this.pictureBox_schedule.Location = new System.Drawing.Point(41, 4);
            this.pictureBox_schedule.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_schedule.Name = "pictureBox_schedule";
            this.pictureBox_schedule.Size = new System.Drawing.Size(123, 83);
            this.pictureBox_schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_schedule.TabIndex = 7;
            this.pictureBox_schedule.TabStop = false;
            this.pictureBox_schedule.Click += new System.EventHandler(this.lblschedule_Click);
            // 
            // pictureBox_bookings
            // 
            this.pictureBox_bookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_bookings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bookings.Image")));
            this.pictureBox_bookings.Location = new System.Drawing.Point(46, 4);
            this.pictureBox_bookings.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_bookings.Name = "pictureBox_bookings";
            this.pictureBox_bookings.Size = new System.Drawing.Size(132, 64);
            this.pictureBox_bookings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bookings.TabIndex = 9;
            this.pictureBox_bookings.TabStop = false;
            this.pictureBox_bookings.Click += new System.EventHandler(this.lblbookings_Click);
            // 
            // pictureBox_earnings
            // 
            this.pictureBox_earnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_earnings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_earnings.Image")));
            this.pictureBox_earnings.Location = new System.Drawing.Point(56, 0);
            this.pictureBox_earnings.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_earnings.Name = "pictureBox_earnings";
            this.pictureBox_earnings.Size = new System.Drawing.Size(112, 89);
            this.pictureBox_earnings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_earnings.TabIndex = 9;
            this.pictureBox_earnings.TabStop = false;
            this.pictureBox_earnings.Click += new System.EventHandler(this.lblearnings_Click);
            // 
            // pictureBox_stations
            // 
            this.pictureBox_stations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_stations.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_stations.Image")));
            this.pictureBox_stations.Location = new System.Drawing.Point(54, 0);
            this.pictureBox_stations.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_stations.Name = "pictureBox_stations";
            this.pictureBox_stations.Size = new System.Drawing.Size(126, 93);
            this.pictureBox_stations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_stations.TabIndex = 7;
            this.pictureBox_stations.TabStop = false;
            this.pictureBox_stations.Click += new System.EventHandler(this.lblstations_Click);
            // 
            // pictureBox_clientList
            // 
            this.pictureBox_clientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_clientList.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_clientList.Image")));
            this.pictureBox_clientList.Location = new System.Drawing.Point(43, 0);
            this.pictureBox_clientList.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_clientList.Name = "pictureBox_clientList";
            this.pictureBox_clientList.Size = new System.Drawing.Size(135, 89);
            this.pictureBox_clientList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clientList.TabIndex = 7;
            this.pictureBox_clientList.TabStop = false;
            this.pictureBox_clientList.Click += new System.EventHandler(this.lblemp_Click);
            // 
            // panel_notice
            // 
            this.panel_notice.BackColor = System.Drawing.Color.Black;
            this.panel_notice.Controls.Add(this.lblNotice);
            this.panel_notice.Controls.Add(this.pictureBox3);
            this.panel_notice.Location = new System.Drawing.Point(725, 528);
            this.panel_notice.Name = "panel_notice";
            this.panel_notice.Size = new System.Drawing.Size(226, 130);
            this.panel_notice.TabIndex = 60;
            this.panel_notice.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotice.Location = new System.Drawing.Point(62, 91);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(87, 27);
            this.lblNotice.TabIndex = 61;
            this.lblNotice.Text = "Notice";
            this.lblNotice.Click += new System.EventHandler(this.lblNotice_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1131, 702);
            this.Controls.Add(this.panel_notice);
            this.Controls.Add(this.panel_salary);
            this.Controls.Add(this.panel_customer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_logout);
            this.Controls.Add(this.panel_feedback);
            this.Controls.Add(this.panel_trainScheme);
            this.Controls.Add(this.panel_booking);
            this.Controls.Add(this.panel_earning);
            this.Controls.Add(this.panel_station);
            this.Controls.Add(this.panel_employee);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lblpname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminHome_Load_1);
            this.panel_station.ResumeLayout(false);
            this.panel_station.PerformLayout();
            this.panel_earning.ResumeLayout(false);
            this.panel_earning.PerformLayout();
            this.panel_feedback.ResumeLayout(false);
            this.panel_feedback.PerformLayout();
            this.panel_trainScheme.ResumeLayout(false);
            this.panel_trainScheme.PerformLayout();
            this.panel_booking.ResumeLayout(false);
            this.panel_booking.PerformLayout();
            this.panel_employee.ResumeLayout(false);
            this.panel_employee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_customer.ResumeLayout(false);
            this.panel_customer.PerformLayout();
            this.panel_salary.ResumeLayout(false);
            this.panel_salary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_feedbacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clientList)).EndInit();
            this.panel_notice.ResumeLayout(false);
            this.panel_notice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Panel panel_station;
        private System.Windows.Forms.Label lblstations;
        private System.Windows.Forms.PictureBox pictureBox_stations;
        private System.Windows.Forms.Panel panel_earning;
        private System.Windows.Forms.PictureBox pictureBox_earnings;
        private System.Windows.Forms.Label lblearnings;
        private System.Windows.Forms.Panel panel_feedback;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.PictureBox pictureBox_schedule;
        private System.Windows.Forms.Panel panel_trainScheme;
        private System.Windows.Forms.Label lblschedule;
        private System.Windows.Forms.Panel panel_booking;
        private System.Windows.Forms.PictureBox pictureBox_bookings;
        private System.Windows.Forms.Label lblbookings;
        private System.Windows.Forms.PictureBox pictureBox_logout;
        private System.Windows.Forms.PictureBox pictureBox_clientList;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Panel panel_employee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox pictureBox_feedbacks;
        private System.Windows.Forms.Panel panel_customer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_salary;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Panel panel_notice;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}