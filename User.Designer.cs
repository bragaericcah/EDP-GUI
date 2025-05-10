namespace boatreservation
{
    partial class User
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
            this.dashboard = new System.Windows.Forms.Button();
            this.ports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boats = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.res_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.boats);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.res_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 426);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // ports
            // 
            this.ports.BackColor = System.Drawing.Color.White;
            this.ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ports.Location = new System.Drawing.Point(38, 311);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(129, 34);
            this.ports.TabIndex = 18;
            this.ports.Text = "Ports";
            this.ports.UseVisualStyleBackColor = false;
            this.ports.Click += new System.EventHandler(this.ports_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(38, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boats
            // 
            this.boats.BackColor = System.Drawing.Color.White;
            this.boats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boats.Location = new System.Drawing.Point(38, 255);
            this.boats.Name = "boats";
            this.boats.Size = new System.Drawing.Size(129, 34);
            this.boats.TabIndex = 16;
            this.boats.Text = "Boats";
            this.boats.UseVisualStyleBackColor = false;
            this.boats.Click += new System.EventHandler(this.boats_Click);
            // 
            // schedule
            // 
            this.schedule.BackColor = System.Drawing.Color.White;
            this.schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.schedule.Location = new System.Drawing.Point(38, 199);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(129, 34);
            this.schedule.TabIndex = 15;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = false;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.White;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payment.Location = new System.Drawing.Point(38, 141);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(129, 34);
            this.payment.TabIndex = 14;
            this.payment.Text = "Payments";
            this.payment.UseVisualStyleBackColor = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // res_button
            // 
            this.res_button.BackColor = System.Drawing.Color.White;
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.res_button.Location = new System.Drawing.Point(38, 83);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(129, 34);
            this.res_button.TabIndex = 13;
            this.res_button.Text = "Reservations";
            this.res_button.UseVisualStyleBackColor = false;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
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
            this.panel2.Location = new System.Drawing.Point(226, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 426);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fname,
            this.lname,
            this.email,
            this.phone,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button ports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boats;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button save_update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}