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
    public partial class AddTypeCarcaseForm : Form
    {
        public AddTypeCarcaseForm()
        {
            InitializeComponent();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            //Проверяем, что поле не пустое
            if (typeCarcaseTB.Text == "")
            {
                MessageBox.Show("Введите тип кузова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (UsedCars db = new UsedCars())
            {
                //Проверяем наявность кузова в базеданных
                var carcas = db.Carcase.Where(p => p.type_carcase == typeCarcaseTB.Text);
                foreach(var r in carcas)
                {
                    if(r.type_carcase == typeCarcaseTB.Text)
                    {
                        MessageBox.Show("Такой тип кузова уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Находим номер последнего добавленного кузова
                var idCarcase = db.Carcase.Max(p => p.id_carcase);

                //Создаём новый элемент
                Carcase carc = new Carcase();
                carc.id_carcase = idCarcase + 1;
                carc.type_carcase = typeCarcaseTB.Text;

                //ДОбавляем изминения
                db.Carcase.Add(carc);

                //Сохраняем изминения
                db.SaveChanges();

                //Очищаем поле ввода
                typeCarcaseTB.Clear();

                //Выводим сообщение об успешной операции
                MessageBox.Show("Кузов добавлен.", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
