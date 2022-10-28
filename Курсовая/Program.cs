using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Не допустимое действие." +
                    " При добавлении новой строки курсор должен находится на строке, заполненой данными.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Аварийное завершение приложения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
