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
    public partial class DeleteCarcaseForm : Form
    {
        public DeleteCarcaseForm()
        {
            InitializeComponent();
        }

        private void DeleteCarcaseForm_Load(object sender, EventArgs e)
        {
            //Заполняем chooseCarcaseCB данными
            using (UsedCars db = new UsedCars())
            {
                var carcase = db.Carcase.ToList();
                foreach (var b in carcase)
                {
                    chooseCarcaseCB.Items.Add(b.type_carcase);
                }
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (chooseCarcaseCB.Text == "")
            {
                MessageBox.Show("Выберите тип кузова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (UsedCars db = new UsedCars())
            {
                //Находим заданый тип кузова в базе данных
                var carcase = db.Carcase.Where(p => p.type_carcase == chooseCarcaseCB.Text);
                foreach (var b in carcase)
                {
                    //Удаляем кузов из базы данных
                    db.Carcase.Remove(b);
                }

                //Сохраняем изминения
                db.SaveChanges();
            }

            //Выводим сообщение об успешной операции
            MessageBox.Show("Марка удалёна.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
