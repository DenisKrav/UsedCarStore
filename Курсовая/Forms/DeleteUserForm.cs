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
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            //Заполняем chooseUserCB данными
            using (UsedCars db = new UsedCars())
            {
                var user = db.Dealer.ToList();
                foreach (var b in user)
                {
                    chooseUserCB.Items.Add(b.id_dealer);
                }
            }

            //Хадаём невидимые поля
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            addressUserTB.Visible = false;
            nameUserTB.Visible = false;
            teleponeUserTB.Visible = false;
        }

        private void chooseUserCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показываем невидимые поля
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            addressUserTB.Visible = true;
            nameUserTB.Visible = true;
            teleponeUserTB.Visible = true;

            //Заполняем поля данными
            using (UsedCars db = new UsedCars())
            {
                int id = Convert.ToInt32(chooseUserCB.Text);
                var user = db.Dealer.Where(p => p.id_dealer == id);
                foreach (var b in user)
                {
                    addressUserTB.Text = b.address;
                    nameUserTB.Text = b.name_dealer;
                    teleponeUserTB.Text = b.telephone;
                }
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseUserCB.Text == "")
            {
                MessageBox.Show("Выберите номер сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                //Находим заданого пользователя в базе данных
                int id = Convert.ToInt32(chooseUserCB.Text);
                var user = db.Dealer.Where(p => p.id_dealer == id);
                foreach (var b in user)
                {
                    //Удаляем пользователя из базы данных
                    db.Dealer.Remove(b);
                }

                //Сохраняем изминения
                db.SaveChanges();
            }

            //Очищаем текстовые поля
            addressUserTB.Clear();
            nameUserTB.Clear();
            teleponeUserTB.Clear();

            //Выводим сообщение об успешной операции
            MessageBox.Show("Сотрудник удалён.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
