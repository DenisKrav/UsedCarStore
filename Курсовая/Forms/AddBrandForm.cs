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
    public partial class AddBrandForm : Form
    {
        public AddBrandForm()
        {
            InitializeComponent();
        }

        private void addBrandB_Click(object sender, EventArgs e)
        {
            //Проверяем, что поле не пустое
            if (brandTB.Text == "")
            {
                MessageBox.Show("Введите тип кузова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (UsedCars db = new UsedCars())
            {
                //Проверяем наявность марки в базе данных
                var brand = db.Brand.Where(p => p.name_brand == brandTB.Text);
                foreach (var r in brand)
                {
                    if (r.name_brand == brandTB.Text)
                    {
                        MessageBox.Show("Такая марка уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Находим номер последнего добавленного кузова
                var idBrand = db.Brand.Max(p => p.id_brand);

                //Создаём новый элемент
                Brand br = new Brand();
                br.id_brand = idBrand + 1;
                br.name_brand = brandTB.Text;

                //ДОбавляем изминения
                db.Brand.Add(br);

                //Сохраняем изминения
                db.SaveChanges();

                //Очищаем поле ввода
                brandTB.Clear();

                //Выводим сообщение об успешной операции
                MessageBox.Show("Марка добавлена.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
