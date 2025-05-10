namespace boatreservation
{
    partial class AdminSide
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
            this.reminderpanel = new System.Windows.Forms.Panel();
            this.activeboatsbox = new System.Windows.Forms.TextBox();
            this.activeboats = new System.Windows.Forms.Label();
            this.pendingpaymentsbox = new System.Windows.Forms.TextBox();
            this.pendingpayments = new System.Windows.Forms.Label();
            this.pendingresbox = new System.Windows.Forms.TextBox();
            this.pendingres = new System.Windows.Forms.Label();
            this.reminder3 = new System.Windows.Forms.TextBox();
            this.reminder2 = new System.Windows.Forms.TextBox();
            this.reminder1 = new System.Windows.Forms.TextBox();
            this.remindertitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Button();
            this.ports = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.boats = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.resbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminderpanel
            // 
            this.reminderpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reminderpanel.Controls.Add(this.activeboatsbox);
            this.reminderpanel.Controls.Add(this.activeboats);
            this.reminderpanel.Controls.Add(this.pendingpaymentsbox);
            this.reminderpanel.Controls.Add(this.pendingpayments);
            this.reminderpanel.Controls.Add(this.pendingresbox);
            this.reminderpanel.Controls.Add(this.pendingres);
            this.reminderpanel.Controls.Add(this.reminder3);
            this.reminderpanel.Controls.Add(this.reminder2);
            this.reminderpanel.Controls.Add(this.reminder1);
            this.reminderpanel.Controls.Add(this.remindertitle);
            this.reminderpanel.Location = new System.Drawing.Point(231, 12);
            this.reminderpanel.Name = "reminderpanel";
            this.reminderpanel.Size = new System.Drawing.Size(557, 426);
            this.reminderpanel.TabIndex = 2;
            this.reminderpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reminderpanel_Paint);
            // 
            // activeboatsbox
            // 
            this.activeboatsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeboatsbox.Location = new System.Drawing.Point(26, 296);
            this.activeboatsbox.Name = "activeboatsbox";
            this.activeboatsbox.Size = new System.Drawing.Size(150, 22);
            this.activeboatsbox.TabIndex = 18;
            this.activeboatsbox.TextChanged += new System.EventHandler(this.activeboatsbox_TextChanged);
            // 
            // activeboats
            // 
            this.activeboats.AutoSize = true;
            this.activeboats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeboats.Location = new System.Drawing.Point(24, 261);
            this.activeboats.Name = "activeboats";
            this.activeboats.Size = new System.Drawing.Size(102, 18);
            this.activeboats.TabIndex = 17;
            this.activeboats.Text = "Active Boats";
            this.activeboats.Click += new System.EventHandler(this.activeboats_Click);
            // 
            // pendingpaymentsbox
            // 
            this.pendingpaymentsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingpaymentsbox.Location = new System.Drawing.Point(278, 200);
            this.pendingpaymentsbox.Name = "pendingpaymentsbox";
            this.pendingpaymentsbox.Size = new System.Drawing.Size(150, 22);
            this.pendingpaymentsbox.TabIndex = 16;
            this.pendingpaymentsbox.TextChanged += new System.EventHandler(this.pendingpaymentsbox_TextChanged);
            // 
            // pendingpayments
            // 
            this.pendingpayments.AutoSize = true;
            this.pendingpayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingpayments.Location = new System.Drawing.Point(275, 161);
            this.pendingpayments.Name = "pendingpayments";
            this.pendingpayments.Size = new System.Drawing.Size(147, 18);
            this.pendingpayments.TabIndex = 15;
            this.pendingpayments.Text = "Pending Payments";
            this.pendingpayments.Click += new System.EventHandler(this.pendingpayments_Click);
            // 
            // pendingresbox
            // 
            this.pendingresbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingresbox.Location = new System.Drawing.Point(27, 200);
            this.pendingresbox.Name = "pendingresbox";
            this.pendingresbox.Size = new System.Drawing.Size(150, 22);
            this.pendingresbox.TabIndex = 14;
            this.pendingresbox.TextChanged += new System.EventHandler(this.pendingresbox_TextChanged);
            // 
            // pendingres
            // 
            this.pendingres.AutoSize = true;
            this.pendingres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingres.Location = new System.Drawing.Point(24, 161);
            this.pendingres.Name = "pendingres";
            this.pendingres.Size = new System.Drawing.Size(172, 18);
            this.pendingres.TabIndex = 13;
            this.pendingres.Text = "Pending Reservations";
            this.pendingres.Click += new System.EventHandler(this.pendingres_Click);
            // 
            // reminder3
            // 
            this.reminder3.Location = new System.Drawing.Point(26, 104);
            this.reminder3.Name = "reminder3";
            this.reminder3.Size = new System.Drawing.Size(430, 20);
            this.reminder3.TabIndex = 12;
            this.reminder3.TextChanged += new System.EventHandler(this.reminder3_TextChanged);
            // 
            // reminder2
            // 
            this.reminder2.Location = new System.Drawing.Point(26, 73);
            this.reminder2.Name = "reminder2";
            this.reminder2.Size = new System.Drawing.Size(430, 20);
            this.reminder2.TabIndex = 11;
            this.reminder2.TextChanged += new System.EventHandler(this.reminder2_TextChanged);
            // 
            // reminder1
            // 
            this.reminder1.Location = new System.Drawing.Point(27, 47);
            this.reminder1.Name = "reminder1";
            this.reminder1.Size = new System.Drawing.Size(430, 20);
            this.reminder1.TabIndex = 10;
            this.reminder1.TextChanged += new System.EventHandler(this.reminder1_TextChanged);
            // 
            // remindertitle
            // 
            this.remindertitle.AutoSize = true;
            this.remindertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remindertitle.Location = new System.Drawing.Point(23, 15);
            this.remindertitle.Name = "remindertitle";
            this.remindertitle.Size = new System.Drawing.Size(89, 18);
            this.remindertitle.TabIndex = 9;
            this.remindertitle.Text = "Reminders";
            this.remindertitle.Click += new System.EventHandler(this.remindertitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.ports);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.boats);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.resbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 426);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.RosyBrown;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard.Location = new System.Drawing.Point(38, 27);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(129, 34);
            this.dashboard.TabIndex = 19;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // ports
            // 
            this.ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ports.Location = new System.Drawing.Point(38, 311);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(129, 34);
            this.ports.TabIndex = 18;
            this.ports.Text = "Ports";
            this.ports.UseVisualStyleBackColor = true;
            this.ports.Click += new System.EventHandler(this.ports_Click_1);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user.Location = new System.Drawing.Point(38, 367);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(129, 34);
            this.user.TabIndex = 17;
            this.user.Text = "Users";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click_1);
            // 
            // boats
            // 
            this.boats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boats.Location = new System.Drawing.Point(38, 255);
            this.boats.Name = "boats";
            this.boats.Size = new System.Drawing.Size(129, 34);
            this.boats.TabIndex = 16;
            this.boats.Text = "Boats";
            this.boats.UseVisualStyleBackColor = true;
            this.boats.Click += new System.EventHandler(this.boats_Click_1);
            // 
            // schedule
            // 
            this.schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.schedule.Location = new System.Drawing.Point(38, 199);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(129, 34);
            this.schedule.TabIndex = 15;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click_1);
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payment.Location = new System.Drawing.Point(38, 141);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(129, 34);
            this.payment.TabIndex = 14;
            this.payment.Text = "Payments";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.payment_Click_1);
            // 
            // resbutton
            // 
            this.resbutton.BackColor = System.Drawing.Color.White;
            this.resbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resbutton.Location = new System.Drawing.Point(38, 83);
            this.resbutton.Name = "resbutton";
            this.resbutton.Size = new System.Drawing.Size(129, 34);
            this.resbutton.TabIndex = 13;
            this.resbutton.Text = "Reservations";
            this.resbutton.UseVisualStyleBackColor = false;
            this.resbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(53, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 11;
            // 
            // AdminSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reminderpanel);
            this.Name = "AdminSide";
            this.Text = "Dashboard";
            this.reminderpanel.ResumeLayout(false);
            this.reminderpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel reminderpanel;
        private System.Windows.Forms.TextBox pendingresbox;
        private System.Windows.Forms.Label pendingres;
        private System.Windows.Forms.TextBox reminder3;
        private System.Windows.Forms.TextBox reminder2;
        private System.Windows.Forms.TextBox reminder1;
        private System.Windows.Forms.Label remindertitle;
        private System.Windows.Forms.TextBox pendingpaymentsbox;
        private System.Windows.Forms.Label pendingpayments;
        private System.Windows.Forms.TextBox activeboatsbox;
        private System.Windows.Forms.Label activeboats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button ports;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button boats;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button resbutton;
        private System.Windows.Forms.Label label5;
    }
}