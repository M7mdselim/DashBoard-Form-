using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardForm
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            ContactusForm c = new ContactusForm();
            this.Hide();
            c.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            this.Hide();
            w.Show();
        }
    }
}
