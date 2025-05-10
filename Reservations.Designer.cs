namespace boatreservation
{
    partial class Reservations
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
            this.ports = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.boats = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.res_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save_update = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 426);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.ports.Click += new System.EventHandler(this.ports_Click);
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
            this.user.Click += new System.EventHandler(this.user_Click);
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
            this.boats.Click += new System.EventHandler(this.boats_Click);
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
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
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
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(38, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reservations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.save_update);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(233, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 426);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.res_id,
            this.user_name,
            this.boat_name,
            this.sched,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // res_id
            // 
            this.res_id.HeaderText = "ID";
            this.res_id.Name = "res_id";
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Name";
            this.user_name.Name = "user_name";
            // 
            // boat_name
            // 
            this.boat_name.HeaderText = "Boat";
            this.boat_name.Name = "boat_name";
            // 
            // sched
            // 
            this.sched.HeaderText = "Schedule";
            this.sched.Name = "sched";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LimeGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.AliceBlue;
            this.add.Location = new System.Drawing.Point(3, 367);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 34);
            this.add.TabIndex = 19;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Firebrick;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.AliceBlue;
            this.delete.Location = new System.Drawing.Point(424, 367);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 34);
            this.delete.TabIndex = 20;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save_update
            // 
            this.save_update.BackColor = System.Drawing.Color.DarkOrange;
            this.save_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_update.ForeColor = System.Drawing.Color.AliceBlue;
            this.save_update.Location = new System.Drawing.Point(214, 367);
            this.save_update.Name = "save_update";
            this.save_update.Size = new System.Drawing.Size(129, 34);
            this.save_update.TabIndex = 21;
            this.save_update.Text = "Update";
            this.save_update.UseVisualStyleBackColor = false;
            this.save_update.Click += new System.EventHandler(this.save_update_Click);
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard.Location = new System.Drawing.Point(38, 27);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(129, 34);
            this.dashboard.TabIndex = 19;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ports;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button boats;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn boat_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sched;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save_update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button dashboard;
    }
}