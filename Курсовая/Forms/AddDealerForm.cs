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
    public partial class AddDealerForm : Form
    {
        public AddDealerForm()
        {
            InitializeComponent();
        }

        private void addUserB_Click(object sender, EventArgs e)
        {
            //Обрабатываем пустые поля
            if (addressUserTB.Text == "" || nameUserTB.Text == "" || telephoneUserTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                //Находим номер последнего добавленного работника
                var idUser = db.Dealer.Max(p => p.id_dealer);

                //Созаём нового пользователя
                Dealer dealer = new Dealer();
                dealer.id_dealer = idUser + 1;
                dealer.name_dealer = nameUserTB.Text;
                dealer.address = addressUserTB.Text;
                dealer.telephone = telephoneUserTB.Text;

                //Добавляем его в базу данных
                db.Dealer.Add(dealer);

                //Сохраняем изминения 
                db.SaveChanges();

                //Очищаем такстовые поля
                nameUserTB.Clear();
                addressUserTB.Clear();
                telephoneUserTB.Clear();

                //Оповещаем о успешной операции
                MessageBox.Show("Сотрудник добавлен.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
