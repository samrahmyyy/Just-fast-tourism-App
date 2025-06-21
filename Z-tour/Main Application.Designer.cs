namespace Z_tour
{
    partial class Main_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Application));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.Menuswitcher = new System.Windows.Forms.Panel();
            this.Orders = new System.Windows.Forms.Button();
            this.Dark_mode = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Notifcation = new System.Windows.Forms.Button();
            this.Booking = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profilesection = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelMainapplicationcenter = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.profilesection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 116);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.Controls.Add(this.Menuswitcher);
            this.menu.Controls.Add(this.Orders);
            this.menu.Controls.Add(this.Dark_mode);
            this.menu.Controls.Add(this.Logout);
            this.menu.Controls.Add(this.Notifcation);
            this.menu.Controls.Add(this.Booking);
            this.menu.Controls.Add(this.Dashboard);
            this.menu.Controls.Add(this.panel2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(210, 689);
            this.menu.TabIndex = 2;
            // 
            // Menuswitcher
            // 
            this.Menuswitcher.BackColor = System.Drawing.SystemColors.Highlight;
            this.Menuswitcher.Location = new System.Drawing.Point(3, 122);
            this.Menuswitcher.Name = "Menuswitcher";
            this.Menuswitcher.Size = new System.Drawing.Size(10, 37);
            this.Menuswitcher.TabIndex = 7;
            // 
            // Orders
            // 
            this.Orders.FlatAppearance.BorderSize = 0;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.Image = ((System.Drawing.Image)(resources.GetObject("Orders.Image")));
            this.Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders.Location = new System.Drawing.Point(12, 244);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(191, 32);
            this.Orders.TabIndex = 16;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Transcation_Click);
            // 
            // Dark_mode
            // 
            this.Dark_mode.FlatAppearance.BorderSize = 0;
            this.Dark_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dark_mode.Image = ((System.Drawing.Image)(resources.GetObject("Dark_mode.Image")));
            this.Dark_mode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dark_mode.Location = new System.Drawing.Point(12, 282);
            this.Dark_mode.Name = "Dark_mode";
            this.Dark_mode.Size = new System.Drawing.Size(191, 32);
            this.Dark_mode.TabIndex = 14;
            this.Dark_mode.Text = "Dark Mode";
            this.Dark_mode.UseVisualStyleBackColor = true;
            this.Dark_mode.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(12, 647);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(191, 32);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Notifcation
            // 
            this.Notifcation.FlatAppearance.BorderSize = 0;
            this.Notifcation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notifcation.Image = ((System.Drawing.Image)(resources.GetObject("Notifcation.Image")));
            this.Notifcation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notifcation.Location = new System.Drawing.Point(12, 206);
            this.Notifcation.Name = "Notifcation";
            this.Notifcation.Size = new System.Drawing.Size(191, 32);
            this.Notifcation.TabIndex = 8;
            this.Notifcation.Text = "Notifcation";
            this.Notifcation.UseVisualStyleBackColor = true;
            this.Notifcation.Click += new System.EventHandler(this.Message_Click);
            // 
            // Booking
            // 
            this.Booking.FlatAppearance.BorderSize = 0;
            this.Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking.Image = ((System.Drawing.Image)(resources.GetObject("Booking.Image")));
            this.Booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booking.Location = new System.Drawing.Point(12, 165);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(191, 32);
            this.Booking.TabIndex = 6;
            this.Booking.Text = "Booking";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Myticket_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(12, 127);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(191, 32);
            this.Dashboard.TabIndex = 4;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basic user";
            // 
            // profilesection
            // 
            this.profilesection.BackColor = System.Drawing.Color.Teal;
            this.profilesection.Controls.Add(this.label3);
            this.profilesection.Controls.Add(this.label10);
            this.profilesection.Controls.Add(this.Guna2DateTimePicker1);
            this.profilesection.Controls.Add(this.pictureBox3);
            this.profilesection.Controls.Add(this.label2);
            this.profilesection.Controls.Add(this.label1);
            this.profilesection.Dock = System.Windows.Forms.DockStyle.Right;
            this.profilesection.Location = new System.Drawing.Point(1128, 0);
            this.profilesection.Name = "profilesection";
            this.profilesection.Size = new System.Drawing.Size(244, 689);
            this.profilesection.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 112);
            this.label3.TabIndex = 59;
            this.label3.Text = "copyright just fast, washington, dc\r\n \r\n202-540-2243 \r\n\r\n justfast-eg.com\r\n\r\n© 20" +
    "24 Copyright Just Fast\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 23);
            this.label10.TabIndex = 58;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Guna2DateTimePicker1
            // 
            this.Guna2DateTimePicker1.Animated = true;
            this.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2DateTimePicker1.BorderRadius = 7;
            this.Guna2DateTimePicker1.BorderThickness = 1;
            this.Guna2DateTimePicker1.Checked = true;
            this.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.Guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Guna2DateTimePicker1.Location = new System.Drawing.Point(10, 136);
            this.Guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1";
            this.Guna2DateTimePicker1.Size = new System.Drawing.Size(231, 23);
            this.Guna2DateTimePicker1.TabIndex = 20;
            this.Guna2DateTimePicker1.Value = new System.DateTime(2020, 8, 16, 0, 40, 1, 963);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // PanelMainapplicationcenter
            // 
            this.PanelMainapplicationcenter.BackColor = System.Drawing.Color.White;
            this.PanelMainapplicationcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainapplicationcenter.Location = new System.Drawing.Point(210, 0);
            this.PanelMainapplicationcenter.Name = "PanelMainapplicationcenter";
            this.PanelMainapplicationcenter.Size = new System.Drawing.Size(918, 689);
            this.PanelMainapplicationcenter.TabIndex = 7;
            this.PanelMainapplicationcenter.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMainapplicationcenter_Paint);
            // 
            // Main_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1372, 689);
            this.Controls.Add(this.PanelMainapplicationcenter);
            this.Controls.Add(this.profilesection);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Application";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.profilesection.ResumeLayout(false);
            this.profilesection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel profilesection;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Menuswitcher;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Dark_mode;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Notifcation;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel PanelMainapplicationcenter;
        internal Guna.UI2.WinForms.Guna2DateTimePicker Guna2DateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}