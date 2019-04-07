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
using System.Xml.Serialization;

namespace SemDiff
{
    public partial class fWorkingArea : Form
    {
        fTest tAggressive;
        fTest tBulling;
        fTest tAbuse;
        fTest tConflict;
        fTest tSuppression;
        fTest tProvocation;

        fResult rAggressive;
        fResult rBulling;
        fResult rAbuse;
        fResult rConflict;
        fResult rSuppression;
        fResult rProvocation;

        Respondent respondent;

        public fWorkingArea(Respondent res)
        {
            InitializeComponent();
            respondent = res;
            tbName.Text = respondent.Name;
            nudAge.Value = respondent.Age;
            tbAddedInfo.Text = respondent.AddedInfo;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (respondent.Aggressive.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Агрессия");
                return;
            }
            if (respondent.Bulling.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Буллинг");
                return;
            }
            if (respondent.Abuse.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Абьюз");
                return;
            }
            if (respondent.Conflict.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Конфликт");
                return;
            }
            if (respondent.Suppression.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Подавление");
                return;
            }
            if (respondent.Provocation.Values.Contains(10))
            {
                MessageBox.Show("Ошибка в тесте: Провокация");
                return;
            }

            rAggressive = new fResult(Calculate(respondent.Aggressive)) { Text = "Результаты Агрессия" };
            rBulling = new fResult(Calculate(respondent.Bulling)) { Text = "Результаты Буллинг" };
            rAbuse = new fResult(Calculate(respondent.Abuse)) { Text = "Результаты Абьюз" };
            rConflict = new fResult(Calculate(respondent.Conflict)) { Text = "Результаты Конфликт" };
            rSuppression = new fResult(Calculate(respondent.Suppression)) { Text = "Результаты Подавление" };
            rProvocation = new fResult(Calculate(respondent.Provocation)) { Text = "Результаты Провокация" };

            gboxResults.Enabled = true;
        }

        private Result Calculate(Test test)
        {
            var res = new Result();
            for (int i = 0; i < test.Values.Length; i++)
            {
                switch (test.Points[i])
                {
                    case 1: res.Assessment.Add(test.Values[i]); break;
                    case 2: res.Strength.Add(test.Values[i]); break;
                    case 3: res.Activity.Add(test.Values[i]); break;
                }
            }

            return res;
        }

        private void btTestAggression_Click(object sender, EventArgs e)
        {
            tAggressive = new fTest(respondent.Aggressive);
            tAggressive.Text = "Агрессия";
            tAggressive.ShowDialog();
        }

        private void btTestBulling_Click(object sender, EventArgs e)
        {
            tBulling = new fTest(respondent.Bulling);
            tBulling.Text = "Буллинг";
            tBulling.ShowDialog();
        }

        private void btTestAbuse_Click(object sender, EventArgs e)
        {
            tAbuse = new fTest(respondent.Abuse);
            tAbuse.Text = "Абьюз";
            tAbuse.ShowDialog();
        }

        private void btTestConflict_Click(object sender, EventArgs e)
        {
            tConflict = new fTest(respondent.Conflict);
            tConflict.Text = "Конфликт";
            tConflict.ShowDialog();
        }

        private void btTestSuppression_Click(object sender, EventArgs e)
        {
            tSuppression = new fTest(respondent.Suppression);
            tSuppression.Text = "Подавление";
            tSuppression.ShowDialog();
        }

        private void btTestProvocation_Click(object sender, EventArgs e)
        {
            tProvocation = new fTest(respondent.Provocation);
            tProvocation.Text = "Провокация";
            tProvocation.ShowDialog();
        }

        private void btRAggression_Click(object sender, EventArgs e)
        {
            rAggressive.ShowDialog();
        }

        private void btRBulling_Click(object sender, EventArgs e)
        {
            rBulling.ShowDialog();
        }

        private void btRAbuse_Click(object sender, EventArgs e)
        {
            rAbuse.ShowDialog();
        }

        private void btRConflict_Click(object sender, EventArgs e)
        {
            rConflict.ShowDialog();
        }

        private void btRSuppression_Click(object sender, EventArgs e)
        {
            rSuppression.ShowDialog();
        }

        private void btRProvocation_Click(object sender, EventArgs e)
        {
            rProvocation.ShowDialog();
        }

        private void ToolStripMenuItemMenu_Click(object sender, EventArgs e)
        {
            Program.main.Show();
            Close();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            respondent.Age = (int)nudAge.Value;
        }

        private void tbAddedInfo_TextChanged(object sender, EventArgs e)
        {
            respondent.AddedInfo = tbAddedInfo.Text;
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if(tbName.Text=="")
            {
                MessageBox.Show("Необходимо ввести имя!");
                tbName.Focus();
                return;
            }
            Text = tbName.Text;
            respondent.Name = tbName.Text;
        }
    }
}
