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
    public partial class DeleteBrandForm : Form
    {
        public DeleteBrandForm()
        {
            InitializeComponent();
        }

        private void DeleteBrandForm_Load(object sender, EventArgs e)
        {
            //Заполняем chooseBrandCB данными
            using (UsedCars db = new UsedCars())
            {
                var brand = db.Brand.ToList();
                foreach (var b in brand)
                {
                    chooseBrandCB.Items.Add(b.name_brand);
                }
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseBrandCB.Text == "")
            {
                MessageBox.Show("Выберите марку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                //Находим заданую марку в базе данных
                var brand = db.Brand.Where(p => p.name_brand == chooseBrandCB.Text);
                foreach (var b in brand)
                {
                    //Удаляем марку из базы данных
                    db.Brand.Remove(b);
                }

                //Сохраняем изминения
                db.SaveChanges();
            }

            //Выводим сообщение об успешной операции
            MessageBox.Show("Марка удалёна.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
