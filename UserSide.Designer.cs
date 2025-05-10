namespace boatreservation
{
    partial class UserSide
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.contactnobox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.lnamelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.ComboBox();
            this.sched = new System.Windows.Forms.Label();
            this.summarytitle = new System.Windows.Forms.Label();
            this.summarybox = new System.Windows.Forms.ListBox();
            this.bookconfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bookconfirm);
            this.panel1.Controls.Add(this.summarybox);
            this.panel1.Controls.Add(this.summarytitle);
            this.panel1.Location = new System.Drawing.Point(21, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.sched);
            this.panel2.Controls.Add(this.Schedule);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.contactlabel);
            this.panel2.Controls.Add(this.emaillabel);
            this.panel2.Controls.Add(this.lnamelabel);
            this.panel2.Controls.Add(this.lnamebox);
            this.panel2.Controls.Add(this.emailbox);
            this.panel2.Controls.Add(this.contactnobox);
            this.panel2.Controls.Add(this.fnamelabel);
            this.panel2.Controls.Add(this.fnamebox);
            this.panel2.Location = new System.Drawing.Point(287, 43);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(485, 374);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fnamebox
            // 
            this.fnamebox.Location = new System.Drawing.Point(130, 64);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(239, 20);
            this.fnamebox.TabIndex = 0;
            this.fnamebox.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fnamelabel.Location = new System.Drawing.Point(49, 71);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(57, 13);
            this.fnamelabel.TabIndex = 1;
            this.fnamelabel.Text = "First Name";
            // 
            // contactnobox
            // 
            this.contactnobox.Location = new System.Drawing.Point(130, 187);
            this.contactnobox.Name = "contactnobox";
            this.contactnobox.Size = new System.Drawing.Size(239, 20);
            this.contactnobox.TabIndex = 2;
            this.contactnobox.TextChanged += new System.EventHandler(this.contactnobox_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(130, 148);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(239, 20);
            this.emailbox.TabIndex = 3;
            this.emailbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lnamebox
            // 
            this.lnamebox.Location = new System.Drawing.Point(130, 107);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(239, 20);
            this.lnamebox.TabIndex = 4;
            this.lnamebox.TextChanged += new System.EventHandler(this.lnamebox_TextChanged);
            // 
            // lnamelabel
            // 
            this.lnamelabel.AutoSize = true;
            this.lnamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnamelabel.Location = new System.Drawing.Point(49, 114);
            this.lnamelabel.Name = "lnamelabel";
            this.lnamelabel.Size = new System.Drawing.Size(58, 13);
            this.lnamelabel.TabIndex = 5;
            this.lnamelabel.Text = "Last Name";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emaillabel.Location = new System.Drawing.Point(49, 155);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(35, 13);
            this.emaillabel.TabIndex = 6;
            this.emaillabel.Text = "E-mail";
            this.emaillabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactlabel.Location = new System.Drawing.Point(49, 194);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(84, 13);
            this.contactlabel.TabIndex = 7;
            this.contactlabel.Text = "Contact Number";
            this.contactlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book a Reservation";
            // 
            // Schedule
            // 
            this.Schedule.FormattingEnabled = true;
            this.Schedule.Location = new System.Drawing.Point(207, 250);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(162, 21);
            this.Schedule.TabIndex = 9;
            this.Schedule.SelectedIndexChanged += new System.EventHandler(this.Schedule_SelectedIndexChanged);
            // 
            // sched
            // 
            this.sched.AutoSize = true;
            this.sched.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sched.Location = new System.Drawing.Point(49, 258);
            this.sched.Name = "sched";
            this.sched.Size = new System.Drawing.Size(98, 13);
            this.sched.TabIndex = 10;
            this.sched.Text = "Choose a schedule";
            this.sched.Click += new System.EventHandler(this.sched_Click);
            // 
            // summarytitle
            // 
            this.summarytitle.AutoSize = true;
            this.summarytitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarytitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.summarytitle.Location = new System.Drawing.Point(53, 16);
            this.summarytitle.Name = "summarytitle";
            this.summarytitle.Size = new System.Drawing.Size(138, 18);
            this.summarytitle.TabIndex = 11;
            this.summarytitle.Text = "Your Reservation";
            this.summarytitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // summarybox
            // 
            this.summarybox.FormattingEnabled = true;
            this.summarybox.Location = new System.Drawing.Point(22, 52);
            this.summarybox.Name = "summarybox";
            this.summarybox.Size = new System.Drawing.Size(202, 251);
            this.summarybox.TabIndex = 12;
            this.summarybox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bookconfirm
            // 
            this.bookconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookconfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookconfirm.Location = new System.Drawing.Point(61, 323);
            this.bookconfirm.Name = "bookconfirm";
            this.bookconfirm.Size = new System.Drawing.Size(129, 34);
            this.bookconfirm.TabIndex = 13;
            this.bookconfirm.Text = "Confirm";
            this.bookconfirm.UseVisualStyleBackColor = true;
            this.bookconfirm.Click += new System.EventHandler(this.bookconfirm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(185, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Book Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserSide";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label lnamelabel;
        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox contactnobox;
        private System.Windows.Forms.Label sched;
        private System.Windows.Forms.ComboBox Schedule;
        private System.Windows.Forms.ListBox summarybox;
        private System.Windows.Forms.Label summarytitle;
        private System.Windows.Forms.Button bookconfirm;
        private System.Windows.Forms.Button button1;
    }
}

