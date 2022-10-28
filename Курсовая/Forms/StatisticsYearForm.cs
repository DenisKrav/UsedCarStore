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
    public partial class StatisticsYearForm : Form
    {
        public StatisticsYearForm()
        {
            InitializeComponent();
        }

        private void statisticYearB_Click(object sender, EventArgs e)
        {
            if (yearTB.Text == "")
            {
                MessageBox.Show("Введите год.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (UsedCars db = new UsedCars())
            {
                //Выбираем данные про контракт за заданный год
                int y = Convert.ToInt32(yearTB.Text);
                var numCont = db.Contract.Where(p => p.date_transaction.Year == y);

                //Вычисляем общее количевство сделок
                int tot = numCont.Count();
                numberContractTB.Text = Convert.ToString(tot);

                //Общая заработаная сумма
                decimal s = numCont.Sum(p => p.actual_price);
                totalAmountTB.Text = Convert.ToString(s);

                //Самая дорогая сделка
                var ExSum = db.Contract.Max(p => p.actual_price);
                expensiveTransactionTB.Text = Convert.ToString(ExSum);

                //Выбираем данные про машины за заданный год
                var numCar = db.Contract.Where(p => p.date_transaction.Year == y);

                //Подсчитываем, сколько машин было выставленно на продажу 
                int c = numCar.Count();
                numberCarTB.Text = Convert.ToString(c);
            }
        }
    }
}
