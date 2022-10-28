using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Forms
{
    public partial class ActionAuthorizationAForm : Form
    {
        public ActionAuthorizationAForm()
        {
            InitializeComponent();
            passwordText.MaxLength = 10;
        }

        private void goB_Click(object sender, EventArgs e)
        {
            if (passwordText.Text == "0000000000")
            {
                this.Hide();
                var delete = new AddDealerForm();
                delete.Closed += (s, args) => this.Show();
                delete.Show();
            }
            else
            {
                MessageBox.Show("Неверно введёный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
