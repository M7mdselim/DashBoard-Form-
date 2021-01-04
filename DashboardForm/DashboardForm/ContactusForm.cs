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
    public partial class ContactusForm : Form
    {
        public ContactusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            this.Hide();
            w.Show();
        }
    }
}
