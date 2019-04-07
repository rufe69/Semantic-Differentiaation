using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemDiff
{
    public partial class fTest : Form
    {
        public fTest(Test test)
        {
            InitializeComponent();
            _test = test;
        }

        Test _test;

        private void fTest_Load(object sender, EventArgs e)
        {
            var v = _test.Values[0];
            dataGridView.Rows.Add("Четкий", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Аморфный");
            v = _test.Values[1];
            dataGridView.Rows.Add("Активный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Пассивный");
            v = _test.Values[2];
            dataGridView.Rows.Add("Организованный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Неорганизованный");
            v = _test.Values[3];
            dataGridView.Rows.Add("Глубокий", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Поверхностный");
            v = _test.Values[4];
            dataGridView.Rows.Add("Красивый", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Безобразный");
            v = _test.Values[5];
            dataGridView.Rows.Add("Громкий", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Тихий");
            v = _test.Values[6];
            dataGridView.Rows.Add("Последовательный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Случайный");
            v = _test.Values[7];
            dataGridView.Rows.Add("Сложный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Простой");
            v = _test.Values[8];
            dataGridView.Rows.Add("Упорядоченный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Хаотичный");
            v = _test.Values[9];
            dataGridView.Rows.Add("Умный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Глупый");
            v = _test.Values[10];
            dataGridView.Rows.Add("Полезный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Бесполезный");
            v = _test.Values[11];
            dataGridView.Rows.Add("Энергичный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Скованный");
            v = _test.Values[12];
            dataGridView.Rows.Add("Мыслящий", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Эмоциональный");
            v = _test.Values[13];
            dataGridView.Rows.Add("Волевой", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Безвольный");
            v = _test.Values[14];
            dataGridView.Rows.Add("Серьезный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Развлекательный");
            v = _test.Values[15];
            dataGridView.Rows.Add("Живой", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Безжизненный");
            v = _test.Values[16];
            dataGridView.Rows.Add("Сильный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Слабый");
            v = _test.Values[17];
            dataGridView.Rows.Add("Бодрый", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Вялый");
            v = _test.Values[18];
            dataGridView.Rows.Add("Оптимистичный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Пессимистичный");
            v = _test.Values[19];
            dataGridView.Rows.Add("Уверенный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Неуверенный");
            v = _test.Values[20];
            dataGridView.Rows.Add("Интересный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Неинтересный");
            v = _test.Values[21];
            dataGridView.Rows.Add("Доступный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Недоступный");
            v = _test.Values[22];
            dataGridView.Rows.Add("Современный", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Устаревший");
            v = _test.Values[23];
            dataGridView.Rows.Add("Хороший", v == 3, v == 2, v == 1, v == 0, v == -1, v == -2, v == -3, "Плохой");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAddResult_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value.GetType() == typeof(bool))
                        if ((bool)cell.Value)
                            switch (cell.ColumnIndex)
                            {
                                case 1: _test.Values[row.Index] = 3; break;
                                case 2: _test.Values[row.Index] = 2; break;
                                case 3: _test.Values[row.Index] = 1; break;
                                case 4: _test.Values[row.Index] = 0; break;
                                case 5: _test.Values[row.Index] = -1; break;
                                case 6: _test.Values[row.Index] = -2; break;
                                case 7: _test.Values[row.Index] = -3; break;
                            }
            Close();
        }
    }
}
