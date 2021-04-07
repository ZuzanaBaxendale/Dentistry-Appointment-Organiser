using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist_orangiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogIn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminLogInForm adminLogInForm = new AdminLogInForm();
            adminLogInForm.Show();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminLogInForm adminLogInForm = new AdminLogInForm();
            adminLogInForm.Show();
        }

        private void btnTreatments_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TreatmentsForm treatmentsForm = new TreatmentsForm();
            treatmentsForm.Show();
        }
    }
}
