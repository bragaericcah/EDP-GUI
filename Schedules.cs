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
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            AdminSide dashForm = new AdminSide();

            // Show the User form
            dashForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void res_button_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Reservations resForm = new Reservations();

            // Show the User form
            resForm.Show();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Payments payForm = new Payments();

            // Show the User form
            payForm.Show();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Schedules schedForm = new Schedules();

            // Show the User form
            schedForm.Show();
        }

        private void boats_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Boat boatForm = new Boat();

            // Show the User form
            boatForm.Show();
        }

        private void ports_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            Port portForm = new Port();

            // Show the User form
            portForm.Show();
        }

        private void user_Click(object sender, EventArgs e)
        {
            // Instantiate the User form
            User userForm = new User();

            // Show the User form
            userForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void save_update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
