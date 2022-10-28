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
    public partial class DeleteCarForm : Form
    {
        public DeleteCarForm()
        {
            InitializeComponent();
        }

        private void DeleteCarForm_Load(object sender, EventArgs e)
        {
            //Заполняем chooseCarCB элементами
            using (UsedCars db = new UsedCars())
            {
                var car = db.Car.ToList();
                foreach (var b in car)
                {
                    chooseCarCB.Items.Add(b.id_lot);
                }
            }

            //Задаём невидимые поля
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            availabilityTB.Visible = false;
            colorTB.Visible = false;
            dataEditionTB.Visible = false;
            dataIssueTB.Visible = false;
            engineCapacityTB.Visible = false;
            fuelTypeTB.Visible = false;
            mileageTB.Visible = false;
            modelNameTB.Visible = false;
            priceTB.Visible = false;
            stateRTB.Visible = false;
            typeEngineTB.Visible = false;
            pictureCarPB.Visible = false;
            numberCarcasetTB.Visible = false;
        }

        private void chooseCarCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показываем невидимые поля
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            availabilityTB.Visible = true;
            colorTB.Visible = true;
            dataEditionTB.Visible = true;
            dataIssueTB.Visible = true;
            engineCapacityTB.Visible = true;
            fuelTypeTB.Visible = true;
            mileageTB.Visible = true;
            modelNameTB.Visible = true;
            priceTB.Visible = true;
            stateRTB.Visible = true;
            typeEngineTB.Visible = true;
            pictureCarPB.Visible = true;
            numberCarcasetTB.Visible = true;

            //Находим даные о машине, id которой быд введён
            using (UsedCars db = new UsedCars())
            {
                var result = from car in db.Car
                             join model in db.Model on car.model_name equals model.model_name
                             join state in db.State on car.id_lot equals state.id_lot
                             join photo in db.Photo_car on car.id_lot equals photo.id_lot
                             select new
                             {
                                 IdLot = car.id_lot,
                                 IdCarcase = car.id_carcase,
                                 IssueYear = car.year_issue,
                                 Mileage = car.mileage,
                                 Price = car.price,
                                 Colorr = car.color,
                                 TypeEngine = car.type_engine,
                                 FuelType = car.fuel_type,
                                 DateIssue = car.date_issue,
                                 Availability = car.availability,
                                 EngineCapacity = car.engine_capacity,
                                 ModelName = model.model_name,
                                 Statee = state.state_description,
                                 Photo = photo.photo
                             };
                int id = Convert.ToInt32(chooseCarCB.Text);
                var machine = result.Where(p => p.IdLot == id);

                //Заполняем поля данными
                foreach (var b in machine)
                {
                    availabilityTB.Text = b.Availability;
                    colorTB.Text = b.Colorr;
                    dataEditionTB.Text = Convert.ToString(b.IssueYear);
                    dataIssueTB.Text= Convert.ToString(b.DateIssue);
                    engineCapacityTB.Text = Convert.ToString(b.EngineCapacity);
                    fuelTypeTB.Text = b.FuelType;
                    mileageTB.Text = Convert.ToString(b.Mileage);
                    modelNameTB.Text = b.ModelName;
                    priceTB.Text = Convert.ToString(b.Price);
                    stateRTB.Text = b.Statee;
                    typeEngineTB.Text = b.TypeEngine;
                    pictureCarPB.Image = HelpFunction.byteArrayToBitmap(b.Photo);
                    pictureCarPB.SizeMode = PictureBoxSizeMode.Zoom;
                    numberCarcasetTB.Text = Convert.ToString(b.IdCarcase);
                }

            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseCarCB.Text == "")
            {
                MessageBox.Show("Выберите номер машины.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                var carBrand = db.Car.Where(p => p.model_name == modelNameTB.Text);

                if (carBrand.Count() > 1)
                {
                    int id = Convert.ToInt32(chooseCarCB.Text);
                    var user = db.Car.Where(p => p.id_lot == id);
                    foreach (var b in user)
                    {
                        //Удаляем пользователя из базы данных
                        db.Car.Remove(b);
                    }
                }
                if (carBrand.Count() == 1)
                {
                    //Выводим прдуприждение
                    DialogResult result = MessageBox.Show("При удалении этой машины её модель будет удалена. Вы действительно хотите это сделать?",
                        "Оповищение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Обрабатываем событие, пр котором мы не хотим выходить из формы
                    if (result == DialogResult.No)
                    {
                        //e.Cancel = true;
                        return;
                    }
                    var model = db.Model.Where(p => p.model_name == modelNameTB.Text);

                    foreach (var b in model)
                    {
                        //Удаляем пользователя из базы данных
                        db.Model.Remove(b);
                    }
                }

                //Сохраняем изминения
                db.SaveChanges();

                //Очищаем все поля
                availabilityTB.Clear();
                colorTB.Clear();
                dataEditionTB.Clear();
                dataIssueTB.Clear();
                engineCapacityTB.Clear();
                fuelTypeTB.Clear();
                mileageTB.Clear();
                modelNameTB.Clear();
                priceTB.Clear();
                stateRTB.Clear();
                typeEngineTB.Clear(); ;
                pictureCarPB.Image = null;
                numberCarcasetTB.Clear();

                // Выводим сообщение об успешной операции
                MessageBox.Show("Машина и марка удалены.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
