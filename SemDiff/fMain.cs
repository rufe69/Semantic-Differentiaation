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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            Respondents = new List<Respondent>();
        }

        public List<Respondent> Respondents;

        private void btAdd_Click(object sender, EventArgs e)
        {
            var resp = new Respondent();
            listBox.Items.Add(resp.Name);
            Respondents.Add(resp);
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (Respondents.Count < 1 || listBox.SelectedIndex < 0) return;
            var WorkingArea = new fWorkingArea(Respondents[listBox.SelectedIndex]);
            WorkingArea.Text = Respondents[listBox.SelectedIndex].Name;
            WorkingArea.Show();
            Hide();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (Respondents.Count < 1 || listBox.SelectedIndex < 0) return;
            var index = listBox.SelectedIndex;
            listBox.Items.RemoveAt(index);
            Respondents.RemoveAt(index);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fMain_VisibleChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (var respondent in Respondents)
                listBox.Items.Add($"{respondent.Name} {respondent.Age}");
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            try
            {
                using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var ser = new XmlSerializer(typeof(List<Respondent>));
                    Respondents =(List<Respondent>)ser.Deserialize(fs);
                    listBox.Items.Clear();
                    foreach (var respondent in Respondents)
                        listBox.Items.Add($"{respondent.Name} {respondent.Age}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла!");
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            try
            {
                using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    var ser = new XmlSerializer(typeof(List<Respondent>));
                    ser.Serialize(fs,Respondents);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
    }
}
