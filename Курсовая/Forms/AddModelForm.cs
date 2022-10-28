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
    public partial class AddModelForm : Form
    {
        public AddModelForm()
        {
            InitializeComponent();
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            using (UsedCars db = new UsedCars())
            { 
                var carcase = db.Carcase.ToList();
                foreach (var b in carcase)
                {
                    chooseTypeCarcaseCB.Items.Add(b.type_carcase);
                }

                var brend = db.Brand.ToList();
                foreach (var b in brend)
                {
                    chooseBrandCB.Items.Add(b.name_brand);
                }
            }
        }

        private void addCarcaseB_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var addCarcase = new AddTypeCarcaseForm();
            addCarcase.Closed += (s, args) => this.Show();
            addCarcase.Show();
        }

        private void addBrandB_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var addBrand = new AddBrandForm();
            addBrand.Closed += (s, args) => this.Show();
            addBrand.Show();
        }

        private void addModelB_Click(object sender, EventArgs e)
        {
            //Проверяем, что поле не пустое
            if (modelNameTB.Text == "" || chooseBrandCB.Text == "" || chooseTypeCarcaseCB.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (UsedCars db = new UsedCars())
            {
                //Проверяем наявность модели в базе данных
                var model = db.Model.Where(p => p.model_name == modelNameTB.Text);
                foreach (var r in model)
                {
                    if (r.model_name == modelNameTB.Text)
                    {
                        MessageBox.Show("Такая модель уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Определяем марку и кузов новой модели в базе данных
                var band = db.Brand.Where(p => p.name_brand == chooseBrandCB.Text);
                var carcase = db.Carcase.Where(p => p.type_carcase == chooseTypeCarcaseCB.Text);

                //Создаём новую модель
                Model mod = new Model();
                mod.model_name = modelNameTB.Text;
                foreach (var r in band)
                {
                    mod.id_brand = r.id_brand;
                }
                foreach (var r in carcase)
                {
                    mod.id_carcase = r.id_carcase;
                }

                //Добавляем модель к базе данных
                db.Model.Add(mod);

                //Сохраняем изминения
                db.SaveChanges();

                //Очищаем текстовое поле 
                modelNameTB.Clear();

                //Выводим сообщение об успешной операции
                MessageBox.Show("Модель добавлена.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
