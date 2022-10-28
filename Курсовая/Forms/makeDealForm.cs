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
using Курсовая.Database;

namespace Курсовая.Forms
{
    public partial class makeDealForm : Form
    {
        public makeDealForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Обработка на заполненых полей, которые должны быть заполнены
                if (nameClientTB.Text == "" || dataTB.Text == "" || priceTB.Text == "" || idLotTB.Text == "" || idWorkerTB.Text == "")
                {
                    MessageBox.Show("Для оформления сделки должны быть заполнены обязательные поля в графе: " +
                        "Сведенья о клиенте, а также должны быть заполнены все поля в графе: Оформление сделки",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Обработка неверного ввода даты
                if (DateTime.ParseExact(dataTB.Text, "dd.MM.yyyy", null) > DateTime.Today)
                {
                    MessageBox.Show("Дата сделки не может быть болше чем текущая дата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Добавление всех параметров сделки в базу данных
                using (UsedCars db = new UsedCars())
                {
                    //Прверка сотрудник на наличие в базе данных
                    var worker = db.Dealer.ToList();
                    if (worker.Any(s => s.id_dealer == Convert.ToInt32(idWorkerTB.Text)) == false)
                    {
                        MessageBox.Show("Такого сотрудника нет в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Прверка машины на наличие в базе данных
                    var cars = db.Car.ToList();
                    if (cars.Any(s => s.id_lot == Convert.ToInt32(idLotTB.Text)) == false)
                    {
                        MessageBox.Show("Такой машины нет в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Провиряем наличие автомобиля в продаже
                    int idLt = Convert.ToInt32(idLotTB.Text);
                    var car = db.Car.Where(p => p.id_lot == idLt);
                    foreach (var p in car)
                    {
                        if (p.availability == "продано")
                        {
                            MessageBox.Show("Автомобиль с заданым номером лота уже продан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //Получаем номер последнего клиента и контракта
                    var idPerson = db.Client.Max(p => p.id_client);
                    var idContract = db.Contract.Max(p => p.id_contract);
                    
                    //Добавляем данные о клиенте в базу данных
                    Client cl = new Client();
                    cl.id_client = idPerson + 1;
                    cl.name_client = nameClientTB.Text;
                    if (addressClientTB.Text != "")
                    {
                        cl.address = addressClientTB.Text;
                    }
                    if (telephoneTB.Text != "")
                    {
                        cl.telephone = telephoneTB.Text;
                    }
                    db.Client.Add(cl);

                    //Добавляем сведенья о контракте в базу данных
                    Contract newContract = new Contract();
                    newContract.id_contract = idContract + 1;                   
                    newContract.date_transaction = DateTime.ParseExact(dataTB.Text, "dd.MM.yyyy", null);
                    newContract.id_client = idPerson + 1;
                    newContract.id_dealer = Convert.ToInt32(idWorkerTB.Text);
                    newContract.id_lot = Convert.ToInt32(idLotTB.Text);
                    newContract.actual_price = Convert.ToInt32(priceTB.Text);
                    db.Contract.Add(newContract);

                    //Обновляем информакцию о машине в базе данных
                    var sql = "UPDATE [Car] SET availability='продано' WHERE id_lot = {0}";
                    int idCar = Convert.ToInt32(idLotTB.Text);
                    var id = idCar;
                    db.Database.ExecuteSqlCommand(sql, id);
 
                    //Сохраняем все изминения в базе данных
                    db.SaveChanges();

                    //Очищаем все текстовые поля
                    nameClientTB.Clear();
                    addressClientTB.Clear();
                    telephoneTB.Clear();
                    dataTB.Clear();
                    priceTB.Clear();
                    idLotTB.Clear();
                    idWorkerTB.Clear();

                    //Оповищение о успешной операции
                    MessageBox.Show("Сделка оформлена.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Не верно введёная дата." +
                    " Дату нужно задавать: день.месяц.год. Пример 21.12.2021", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
