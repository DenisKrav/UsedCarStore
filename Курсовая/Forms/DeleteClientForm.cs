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
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
        {
            InitializeComponent();
        }

        private void DeleteClientForm_Load(object sender, EventArgs e)
        {
            // Заполняем chooseBrandCB данными
            using (UsedCars db = new UsedCars())
            {
                var client = db.Client.ToList();
                foreach (var b in client)
                {
                    chooseClientCB.Items.Add(b.id_client);
                }
            }

            //Скрываем поля
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            addressClientTB.Visible = false;
            nameClientTB.Visible = false;
            phoneClientTB.Visible = false;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseClientCB.Text == "")
            {
                MessageBox.Show("Выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (UsedCars db = new UsedCars())
            {
                int id = Convert.ToInt32(chooseClientCB.Text);
                //Находим заданого клиента в базе данных
                var client = db.Client.Where(p => p.id_client == id);
                foreach (var b in client)
                {
                    //Удаляем клиента из базы данных
                    db.Client.Remove(b);
                }

                //Сохраняем изминения
                db.SaveChanges();
            }

            //Очищаем текстовые поля
            addressClientTB.Clear();
            phoneClientTB.Clear();
            nameClientTB.Clear();

            //Выводим сообщение об успешной операции
            MessageBox.Show("Клиент удалёна.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void chooseClientCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показываем скрытые поля
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            addressClientTB.Visible = true;
            nameClientTB.Visible = true;
            phoneClientTB.Visible = true;

            //Заполняем поля данными
            using (UsedCars db = new UsedCars())
            {
                int id = Convert.ToInt32(chooseClientCB.Text);
                var client = db.Client.Where(p => p.id_client == id);
                foreach (var b in client)
                {
                    addressClientTB.Text = b.address;
                    nameClientTB.Text = b.name_client;
                    phoneClientTB.Text = b.telephone;
                }
            }
        }
    }
}
