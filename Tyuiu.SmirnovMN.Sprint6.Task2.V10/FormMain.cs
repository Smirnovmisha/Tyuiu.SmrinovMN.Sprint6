using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovMN.Sprint6.Task2.V10.Lib;

namespace Tyuiu.SmirnovMN.Sprint6.Task2.V10

{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LIV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_LIV.BackColor = Color.Red;
        }

        private void buttonDone_LIV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_LIV.BackColor = Color.Green;
        }

        private void buttonDone_LIV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_LIV.BackColor = Color.Blue;
        }

        private void buttonDone_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_LIV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_LIV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_LIV.Titles.Add("График функции");
                this.chartResult_LIV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_LIV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_LIV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_LIV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_LIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-3 Лебедев Игорь Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1251, 880);
            this.Name = "FormMain";
            this.ResumeLayout(false);

        }
    }
}
