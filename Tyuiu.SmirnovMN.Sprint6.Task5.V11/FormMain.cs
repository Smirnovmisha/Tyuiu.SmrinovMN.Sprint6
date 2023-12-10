using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovMN.Sprint6.Task5.V11.Lib;

namespace Tyuiu.SmirnovMN.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_KEA.ColumnCount = 2;
            dataGridViewRes_KEA.Columns[0].Width = 20;
            dataGridViewRes_KEA.Columns[1].Width = 50;

            this.chartRes_KEA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_KEA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartRes_KEA.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewRes_KEA.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartRes_KEA.Series[0].Points.AddXY(i, numArray[i]);
            }


        }

        private void buttonFile_KEA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студент группы ИИПБ-23-2 Смирнов Михаил Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
