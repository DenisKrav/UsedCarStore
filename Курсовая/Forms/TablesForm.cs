using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Forms
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.brandBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.used_carDataSet);
            }
            catch(SqlException)
            {
                MessageBox.Show("Удалить машину нельзя удалить, чтобы её удалить," +
                    " нужно удалить её модель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.State". При необходимости она может быть перемещена или удалена.
            this.stateTableAdapter.Fill(this.used_carDataSet.State);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Photo_car". При необходимости она может быть перемещена или удалена.
            this.photo_carTableAdapter.Fill(this.used_carDataSet.Photo_car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.used_carDataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Dealer". При необходимости она может быть перемещена или удалена.
            this.dealerTableAdapter.Fill(this.used_carDataSet.Dealer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.used_carDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.used_carDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Carcase". При необходимости она может быть перемещена или удалена.
            this.carcaseTableAdapter.Fill(this.used_carDataSet.Carcase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.used_carDataSet.Car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "used_carDataSet.Brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.used_carDataSet.Brand);

            carDataGridView.Visible = false;
            brandDataGridView.Visible = false;
            carcaseDataGridView.Visible = false;
            clientDataGridView.Visible = false;
            contractDataGridView.Visible = false;
            dealerDataGridView.Visible = false;
            modelDataGridView.Visible = false;
            photo_carDataGridView.Visible = false;
            stateDataGridView.Visible = false;

            BindingNavigator.Visible = false;

            //Устанавливае ширину и высоту столбца с фото для таблицы photo_carDataGridView
            photo_carDataGridView.Columns[0].Width = 700;
            photo_carDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            photo_carDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void chooseTableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingNavigator.Visible = true;

            if (chooseTableCB.Text == "Car")
            {
                carDataGridView.Visible = true;

                brandDataGridView.Visible = false;
                carcaseDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = carBindingSource;
            }
            if (chooseTableCB.Text == "Brand")
            {
                brandDataGridView.Visible = true;

                carDataGridView.Visible = false;               
                carcaseDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = brandBindingSource;
            }
            if (chooseTableCB.Text == "Carcase")
            {
                carcaseDataGridView.Visible = true;

                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = carcaseBindingSource;
            }
            if (chooseTableCB.Text == "Client")
            {
                clientDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = clientBindingSource;
            }
            if (chooseTableCB.Text == "Contract")
            {
                contractDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = contractBindingSource;
            }
            if (chooseTableCB.Text == "Dealer")
            {
                dealerDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = dealerBindingSource;
            }
            if (chooseTableCB.Text == "Model")
            {
                modelDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = modelBindingSource;
            }
            if (chooseTableCB.Text == "Photo_car")
            {
                photo_carDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                stateDataGridView.Visible = false;

                BindingNavigator.BindingSource = photo_carBindingSource;
            }
            if (chooseTableCB.Text == "State")
            {
                stateDataGridView.Visible = true;

                carcaseDataGridView.Visible = false;
                brandDataGridView.Visible = false;
                carDataGridView.Visible = false;
                clientDataGridView.Visible = false;
                contractDataGridView.Visible = false;
                dealerDataGridView.Visible = false;
                modelDataGridView.Visible = false;
                photo_carDataGridView.Visible = false;

                BindingNavigator.BindingSource = stateBindingSource;
            }
        }


        private void stateDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Чтобы добавить столбе, нужно клацнуть на заполненое поле," +
                        " а затем на знак +. Аналогичные действия нужно произволить при удалении.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
