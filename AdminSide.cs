using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boatreservation
{
    public partial class AdminSide : Form
    {
        public AdminSide()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservations_Click(object sender, EventArgs e)
        {

        }

        private void payment_Click(object sender, EventArgs e)
        {

        }

        private void schedule_Click(object sender, EventArgs e)
        {

        }

        private void boats_Click(object sender, EventArgs e)
        {

        }

        private void ports_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void reminderpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reminder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reminder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reminder3_TextChanged(object sender, EventArgs e)
        {

        }

        private void remindertitle_Click(object sender, EventArgs e)
        {

        }

        private void pendingres_Click(object sender, EventArgs e)
        {

        }

        private void pendingresbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pendingpayments_Click(object sender, EventArgs e)
        {

        }

        private void pendingpaymentsbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void activeboats_Click(object sender, EventArgs e)
        {

        }

        private void activeboatsbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            AdminSide dashForm = new AdminSide();

            // Show the User form
            dashForm.Show();
        }

        private void payment_Click_1(object sender, EventArgs e)
        {
            // Instantiate the User form
            Payments payForm = new Payments();

            // Show the User form
            payForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Reservations resForm = new Reservations();

            // Show the User form
            resForm.Show();
        }

        private void user_Click_1(object sender, EventArgs e)
        {
            // Instantiate the User form
            User userForm = new User();

            // Show the User form
            userForm.Show();
        }

        private void ports_Click_1(object sender, EventArgs e)
        {
            // Instantiate the User form
            Port portForm = new Port();

            // Show the User form
            portForm.Show();
        }

        private void boats_Click_1(object sender, EventArgs e)
        {
            // Instantiate the User form
            Boat boatForm = new Boat();

            // Show the User form
            boatForm.Show();
        }

        private void schedule_Click_1(object sender, EventArgs e)
        {
            // Instantiate the User form
            Schedules schedForm = new Schedules();

            // Show the User form
            schedForm.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
