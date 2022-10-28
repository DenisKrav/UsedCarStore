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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void goTableB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tableF = new TablesForm();
            tableF.Closed += (s, args) => this.Show();
            tableF.Show();
        }

        private void makeDealButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var makeDeal = new makeDealForm();
            makeDeal.Closed += (s, args) => this.Show();
            makeDeal.Show();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addCar = new AddCarForm();
            addCar.Closed += (s, args) => this.Show();
            addCar.Show();
        }

        private void addBrandB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addBrand = new AddBrandForm();
            addBrand.Closed += (s, args) => this.Show();
            addBrand.Show();
        }

        private void addCarcaseB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addCarcase = new AddTypeCarcaseForm();
            addCarcase.Closed += (s, args) => this.Show();
            addCarcase.Show();
        }

        private void addWorkerB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addDealer = new ActionAuthorizationAForm();
            addDealer.Closed += (s, args) => this.Show();
            addDealer.Show();
        }

        private void deleteUserB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteDealer = new ActionAuthorizationDForm();
            deleteDealer.Closed += (s, args) => this.Show();
            deleteDealer.Show();
        }

        private void deleteCarB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteCar = new DeleteCarForm();
            deleteCar.Closed += (s, args) => this.Show();
            deleteCar.Show();
        }

        private void deleteBrandB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteBrand = new DeleteBrandForm();
            deleteBrand.Closed += (s, args) => this.Show();
            deleteBrand.Show();
        }

        private void deleteTypeCarcaseB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteCarcase = new DeleteCarcaseForm();
            deleteCarcase.Closed += (s, args) => this.Show();
            deleteCarcase.Show();
        }

        private void deleteClientB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteClient = new DeleteClientForm();
            deleteClient.Closed += (s, args) => this.Show();
            deleteClient.Show();
        }

        private void deleteContractB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteContract = new DeleteContractForm();
            deleteContract.Closed += (s, args) => this.Show();
            deleteContract.Show();
        }

        private void statisticYearB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stat = new StatisticsYearForm();
            stat.Closed += (s, args) => this.Show();
            stat.Show();
        }
    }
}
