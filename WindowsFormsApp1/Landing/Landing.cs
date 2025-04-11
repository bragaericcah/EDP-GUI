using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Landing remForm = new Landing();
            remForm.Show();
            this.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();  // create an instance of the Admin form
            adminForm.Show();               // display it (non-blocking)

            this.Hide();       // hides the landing page
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User userForm = new User();   // create an instance of the User form
            userForm.Show();              // show the User form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boats boatForm = new Boats();
            boatForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ports portsForm = new Ports();
            portsForm.Show();
            this.Hide();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reservations resForm = new Reservations();
            resForm.Show(); 
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Schedule schedForm = new Schedule();
            schedForm.Show();  
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Payments payForm = new Payments();
            payForm.Show();
            this.Hide();
        }
    }
}
