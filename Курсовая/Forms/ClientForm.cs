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
    public partial class ClientForm : Form
    {       
        private int xPicture = 20;
        private int xLable = 360;
        private int y = 20;
        private int yButton = 280;
        private int i = 0;

        public ClientForm()
        {
            InitializeComponent();

            using (UsedCars db = new UsedCars())
            {
                var result = from car in db.Car
                             join model in db.Model on car.model_name equals model.model_name
                             join brand in db.Brand on model.id_brand equals brand.id_brand
                             join carcase in db.Carcase on model.id_carcase equals carcase.id_carcase
                             join state in db.State on car.id_lot equals state.id_lot
                             join photo in db.Photo_car on car.id_lot equals photo.id_lot
                             select new
                             {
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
                                 NameBrand = brand.name_brand,
                                 TypeCarcase = carcase.type_carcase,
                                 Statee = state.state_description,
                                 Photo = photo.photo
                             };

                foreach (var c in result)
                {
                    //Обработка картинки
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(320, 240);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = HelpFunction.byteArrayToBitmap(c.Photo);
                    panel2.Controls.Add(pb);
                    pb.Location = new Point(xPicture, y + i);


                    //Работа с текстом
                    Label lb = new Label();
                    lb.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                    lb.AutoSize = true;

                    lb.Text = "Марка: " + c.NameBrand + " \n" +
                        "Кузов: " + c.TypeCarcase + " \n" +
                        "Модель: " + c.ModelName + " \n" +
                        "Цвет: " + c.Colorr + " \n" +
                        "Год выпуска: " + c.IssueYear + " \n" +
                        "Пробег: " + c.Mileage + " \n" +
                        "Тип двигателя: " + c.TypeEngine + " \n" +
                        "Тип топлива: " + c.FuelType + " \n" +
                        "Объём двигателя: " + c.EngineCapacity + " \n" +
                        "Дата выставления на продажу: " + c.DateIssue + " \n" +
                        "Цена: " + c.Price; /*+ " \n" +*/
                    //"Описание состояния: " + c.Statee;

                    panel2.Controls.Add(lb);
                    lb.Location = new Point(xLable, y + i);

                    //Кнопка, которая опвещает о состоянии машины
                    Button inf = new Button();
                    inf.BackColor = Color.White;
                    inf.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                    inf.Size = new Size(353, 35);
                    inf.Text = "Узнать об состоянии машины";

                    //Добавление события
                    inf.Click += new EventHandler(MyCustomClickHandler);

                    //Метод для обработки нажатия на кнопку
                    void MyCustomClickHandler(object sender, EventArgs e)
                    {
                        MessageBox.Show(c.Statee, "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    panel2.Controls.Add(inf);
                    inf.Location = new Point(xPicture, yButton + i);

                    //Добавление надписи для оповищения о том, продана машина или нет
                    Label label = new Label();
                    label.Font = new Font("Times New Roman", 20, FontStyle.Italic);
                    label.AutoSize = true;
                    label.Text = c.Availability;
                    if (c.Availability == "в наличии")
                    {
                        label.ForeColor = Color.DarkGreen;
                    }
                    if (c.Availability == "продано")
                    {
                        label.ForeColor = Color.Red;
                    }
                    panel2.Controls.Add(label);
                    label.Location = new Point(xLable + 70, yButton + i);

                    //Переменная, которая помогает задавать новое положение по y
                    i += 400;

                }

            }

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            using (UsedCars db = new UsedCars())
            {
                var brand = db.Brand.ToList();
                foreach(var p in brand)
                {
                    brandCB.Items.Add(p.name_brand);
                }

                var carcase = db.Carcase.ToList();
                foreach (var b in carcase)
                {
                    typeCarcaseCB.Items.Add(b.type_carcase);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brandCB.Text == "" && engCapacityTB.Text == "" && typeCarcaseCB.Text == "" &&
                    typeEngineCB.Text == "" && foilTypeCB.Text == "" && datEditionTB.Text == "" &&
                    mileageTB.Text == "" && priceTB.Text == "" && stateCarCB.Text == "")
            {
                MessageBox.Show("Заполните параметры для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Очищаем панель и переменную, которая помогает размещать элементы на панеле
                panel2.Controls.Clear();
                i = 0;

                using (UsedCars db = new UsedCars())
                {
                    var result = from car in db.Car
                                 join model in db.Model on car.model_name equals model.model_name
                                 join brand in db.Brand on model.id_brand equals brand.id_brand
                                 join carcase in db.Carcase on model.id_carcase equals carcase.id_carcase
                                 join state in db.State on car.id_lot equals state.id_lot
                                 join photo in db.Photo_car on car.id_lot equals photo.id_lot
                                 select new
                                 {
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
                                     NameBrand = brand.name_brand,
                                     TypeCarcase = carcase.type_carcase,
                                     Statee = state.state_description,
                                     Photo = photo.photo
                                 };

                    if (brandCB.Text != "")
                    {
                        result = result.Where(p => p.NameBrand == brandCB.Text);
                    }
                    if (engCapacityTB.Text != "")
                    {
                        var dec1 = Convert.ToDecimal(engCapacityTB.Text);
                        result = result.Where(p => p.EngineCapacity == dec1);
                    }
                    if (typeCarcaseCB.Text != "")
                    {
                        result = result.Where(p => p.TypeCarcase == typeCarcaseCB.Text);
                    }
                    if (typeEngineCB.Text != "")
                    {
                        result = result.Where(p => p.TypeEngine == typeEngineCB.Text);
                    }
                    if (foilTypeCB.Text != "")
                    {
                        result = result.Where(p => p.FuelType == foilTypeCB.Text);
                    }
                    if (datEditionTB.Text != "")
                    {
                        int year = Convert.ToInt32(datEditionTB.Text);
                        result = result.Where(p => p.IssueYear.Value.Year == year);
                    }
                    if (mileageTB.Text != "")
                    {
                        int mil = Convert.ToInt32(mileageTB.Text);
                        result = result.Where(p => p.Mileage == mil);
                    }
                    if (priceTB.Text != "")
                    {
                        var dec2 = Convert.ToDecimal(priceTB.Text);
                        result = result.Where(p => p.Price == dec2);
                    }
                    if (stateCarCB.Text != "")
                    {
                        result = result.Where(p => p.Availability == stateCarCB.Text);
                    }

                    foreach (var c in result)
                    {
                        //Обработка картинки
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(320, 240);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Image = HelpFunction.byteArrayToBitmap(c.Photo);
                        panel2.Controls.Add(pb);
                        pb.Location = new Point(xPicture, y + i);


                        //Работа с текстом
                        Label lb = new Label();
                        lb.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                        lb.AutoSize = true;

                        lb.Text = "Марка: " + c.NameBrand + " \n" +
                            "Кузов: " + c.TypeCarcase + " \n" +
                            "Модель: " + c.ModelName + " \n" +
                            "Цвет: " + c.Colorr + " \n" +
                            "Год выпуска: " + c.IssueYear + " \n" +
                            "Пробег: " + c.Mileage + " \n" +
                            "Тип двигателя: " + c.TypeEngine + " \n" +
                            "Тип топлива: " + c.FuelType + " \n" +
                            "Объём двигателя: " + c.EngineCapacity + " \n" +
                            "Дата выставления на продажу: " + c.DateIssue + " \n" +
                            "Цена: " + c.Price;

                        panel2.Controls.Add(lb);
                        lb.Location = new Point(xLable, + i);

                        //Кнопка, которая опвещает о состоянии машины
                        Button inf = new Button();
                        inf.BackColor = Color.White;
                        inf.Font = new Font("Times New Roman", 14, FontStyle.Italic);
                        inf.Size = new Size(353, 35);
                        inf.Text = "Узнать об состоянии машины";

                        //Добавление события
                        inf.Click += new EventHandler(MyCustomClickHandler);

                        //Метод для обработки нажатия на кнопку
                        void MyCustomClickHandler(object sender1, EventArgs e1)
                        {
                            MessageBox.Show(c.Statee, "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        panel2.Controls.Add(inf);
                        inf.Location = new Point(xPicture, yButton + i);

                        //Добавление надписи для оповищения о том, продана машина или нет
                        Label label = new Label();
                        label.Font = new Font("Times New Roman", 20, FontStyle.Italic);
                        label.AutoSize = true;
                        label.Text = c.Availability;
                        if (c.Availability == "в наличии")
                        {
                            label.ForeColor = Color.DarkGreen;
                        }
                        if (c.Availability == "продано")
                        {
                            label.ForeColor = Color.Red;
                        }
                        panel2.Controls.Add(label);
                        label.Location = new Point(xLable + 70, yButton + i);

                        //Переменная, которая помогает задавать новое положение по y
                        i += 400;

                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Объём двигателя нужно задавать через запятую.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
