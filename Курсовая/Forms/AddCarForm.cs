using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Database;

namespace Курсовая.Forms
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            using (UsedCars db = new UsedCars())
            {
                var model = db.Model.ToList();
                foreach (var p in model)
                {
                    chooseModelCB.Items.Add(p.model_name);
                }
            }
        }

        private void addModelB_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var addModel = new AddModelForm();
            addModel.Closed += (s, args) => this.Show();
            addModel.Show();
        }

        private void downloadPictureB_Click(object sender, EventArgs e)
        {
            try
            {
                //фильтр выбора файла
                openFileDialog1.Filter = "Image Files (*.png; *.jpg; *.bmp; *.gif)|*.png; *.jpg; *.bmp; *.gif";
                openFileDialog1.ShowDialog();

                //Загружаем изображение
                carPicturePB.Image = Image.FromFile(openFileDialog1.FileName);

                //Подгоняем размер изображения
                carPicturePB.SizeMode = PictureBoxSizeMode.Zoom;//подгоняем изображение под PictureBox
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Изображение не загружено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Изображение не загружено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addCarB_Click(object sender, EventArgs e)
        {
            try
            {
                //Обработка не заполненых полей
                if (carPicturePB.Image == null)
                {
                    MessageBox.Show("Изображение не загружено. Обезательное поля для зааполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (stateRTB.Text == "")
                {
                    MessageBox.Show("Не добавленно описание машины. Обезательное поля для зааполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (chooseModelCB.Text == "")
                {
                    MessageBox.Show("Выберите модель машины. Обезательное поля для зааполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (UsedCars db = new UsedCars())
                {
                    var idPCar = db.Car.Max(p => p.id_lot);

                    //Создание новой мащины
                    Car car = new Car();
                    car.id_lot = idPCar + 1;
                    var model = db.Model.Where(p => p.model_name == chooseModelCB.Text);
                    foreach (var r in model)
                    {
                        car.model_name = r.model_name;
                    }                  
                    if (numberCarcaseTB.Text != "")
                    {
                        car.id_carcase = Convert.ToInt32(numberCarcaseTB.Text);
                    }
                    if (dateEditionTB.Text != "")
                    {
                        car.year_issue = DateTime.ParseExact(dateEditionTB.Text, "dd.MM.yyyy", null);
                    }
                    if (mileageTB.Text != "")
                    {
                        car.mileage = Convert.ToInt32(mileageTB.Text);
                    }
                    if (priceTB.Text != "")
                    {
                        var priceDec = Convert.ToDecimal(priceTB.Text);
                        car.price = priceDec;
                    }
                    if (colorTB.Text != "")
                    {
                        car.color = colorTB.Text;
                    }
                    if (chooseTypeEngineCB.Text != "")
                    {
                        car.type_engine = chooseTypeEngineCB.Text;
                    }
                    if (chooseFoelTypeCB.Text != "")
                    {
                        car.fuel_type = chooseFoelTypeCB.Text;
                    }
                    if (dateIssueTB.Text != "")
                    {
                        if (DateTime.ParseExact(dateIssueTB.Text, "dd.MM.yyyy", null) > DateTime.Today)
                        {
                            MessageBox.Show("Дата сделки не может быть болше чем текущая дата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        car.date_issue = DateTime.ParseExact(dateIssueTB.Text, "dd.MM.yyyy", null);
                    }
                    if (engineCapacityTB.Text != "")
                    {
                        var engCapDec = Convert.ToDecimal(engineCapacityTB.Text);
                        car.engine_capacity = engCapDec;
                    }
                    car.availability = "в наличии";
                    //Ддобавление машины в базу данных
                    db.Car.Add(car);

                    //Сохраняем изминения в базе данных
                    //db.SaveChanges();

                    //Создание фотографи машины
                    Photo_car photo = new Photo_car();
                    photo.id_lot = idPCar + 1;
                    photo.photo = converterDemo(carPicturePB.Image);
                    //Ддобавление фотографи в базу данных
                    db.Photo_car.Add(photo);

                    //Создание описания машины
                    State state = new State();
                    state.id_lot = idPCar + 1;
                    state.state_description = stateRTB.Text;
                    //Ддобавление описания в базу данных
                    db.State.Add(state);

                    //Сохраняем изминения в базе данных
                    db.SaveChanges();

                    //Збрасываем поля
                    colorTB.Clear();
                    dateEditionTB.Clear();
                    dateIssueTB.Clear();
                    engineCapacityTB.Clear();
                    mileageTB.Clear();
                    numberCarcaseTB.Clear();
                    priceTB.Clear();
                    stateRTB.Clear();
                    carPicturePB.Image = null;

                    //Оповищение о успешной операции
                    MessageBox.Show("Машина добавлена.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Не верно введёная дата." +
                    " Дату нужно задавать: день.месяц.год. Пример 21.12.2021", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Объём двигателя нужно задавать через запятую.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
