using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clf = new ClientForm();
            clf.Closed += (s, args) => this.Show();
            clf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var autf = new AuthorizationForm();
            autf.Closed += (s, args) => this.Show();
            autf.Show();
        }
    }
}
