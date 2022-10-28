using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Database;

namespace Курсовая.Forms
{
    public partial class DeleteContractForm : Form
    {
        public DeleteContractForm()
        {
            InitializeComponent();
        }

        private void DeleteContractForm_Load(object sender, EventArgs e)
        {
            //Заполняем chooseUserCB данными
            using (UsedCars db = new UsedCars())
            {
                var contract = db.Contract.ToList();
                foreach (var b in contract)
                {
                    chooseContractCB.Items.Add(b.id_contract);
                }
            }

            //Хадаём невидимые поля
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            actualPriceTB.Visible = false;
            dataTB.Visible = false;
            idClientTB.Visible = false;
            idDealerTB.Visible = false;
            idLotTB.Visible = false;
        }

        private void chooseContractCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показываем невидимые поля
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            actualPriceTB.Visible = true;
            dataTB.Visible = true;
            idClientTB.Visible = true;
            idDealerTB.Visible = true;
            idLotTB.Visible = true;

            //Заполняем поля данными
            using (UsedCars db = new UsedCars())
            {
                int id = Convert.ToInt32(chooseContractCB.Text);
                var user = db.Contract.Where(p => p.id_contract == id);
                foreach (var b in user)
                {
                    idLotTB.Text = Convert.ToString(b.id_lot);
                    idDealerTB.Text = Convert.ToString(b.id_dealer);
                    idClientTB.Text = Convert.ToString(b.id_client);
                    dataTB.Text = Convert.ToString(b.date_transaction);
                    actualPriceTB.Text = Convert.ToString(b.actual_price);
                }
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseContractCB.Text == "")
            {
                MessageBox.Show("Выберите номер сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                //Находим заданую сделку в базе данных
                int id = Convert.ToInt32(chooseContractCB.Text);
                var contract = db.Contract.Where(p => p.id_contract == id);
                foreach (var b in contract)
                {
                    //Удаляем сделку из базы данных
                    db.Contract.Remove(b);
                }

                //Сохраняем изминения
                db.SaveChanges();
            }

            //Очищаем текстовые поля
            actualPriceTB.Clear();
            dataTB.Clear();
            idClientTB.Clear();
            idDealerTB.Clear();
            idLotTB.Clear();

            //Выводим сообщение об успешной операции
            MessageBox.Show("Сделка удалина.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
