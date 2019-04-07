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
    public partial class fResult : Form
    {
        Result _result;

        public fResult(Result result)
        {
            InitializeComponent();
            _result = result;
        }

        private void fResult_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < 8; i++)
                dataGridView.Rows.Add(_result.Assessment[i], _result.Strength[i], _result.Activity[i]);

            dataGridView.Rows.Add(_result.Assessment.Sum(), _result.Strength.Sum(), _result.Activity.Sum());
            dataGridView.Rows.Add(_result.Assessment.Average(), _result.Strength.Average(), _result.Activity.Average());
        }
    }
}
