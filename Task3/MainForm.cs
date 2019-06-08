using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        public MainForm()
        {
            InitializeComponent();

            mainChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            mainChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            mainChart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            mainChart.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            mainChart.ChartAreas[0].AxisX.Title = "z";
        }

        //список пар <z, мн-во аргументов t и значений u>
        List<Tuple<double, Tuple<List<double>, List<double>>>> calcUNonNewtonian;
        List<Tuple<double, Tuple<List<double>, List<double>>>> calcFNonNewtonian;
        List<Tuple<double, Tuple<List<double>, List<double>>>> calcUNewtonian;
        List<Tuple<double, Tuple<List<double>, List<double>>>> calcFNewtonian;

        int zCount = 0;
        int tCount = 0;

        private void BtStart_Click(object sender, EventArgs e)
        {
            calcUNonNewtonian = new List<Tuple<double, Tuple<List<double>, List<double>>>>();
            calcFNonNewtonian = new List<Tuple<double, Tuple<List<double>, List<double>>>>();
            calcUNewtonian = new List<Tuple<double, Tuple<List<double>, List<double>>>>();
            calcFNewtonian = new List<Tuple<double, Tuple<List<double>, List<double>>>>();

            double zmin = Convert.ToDouble(TbZMin.Text);
            double zmax = Convert.ToDouble(TbZMax.Text);
            double zinterval = Convert.ToDouble(TbZInterval.Text);

            double tmin = Convert.ToDouble(TbTMin.Text);
            double tmax = Convert.ToDouble(TbTMax.Text);
            double tinterval = Convert.ToDouble(TbTInterval.Text);

            double nu = Convert.ToDouble(TbNu.Text);
            double kappa = Convert.ToDouble(TbKappa.Text);
            double bigOmega = Convert.ToDouble(TbBigOmega.Text);

            for(double z = zmin; z < zmax; z += zinterval)
            {
                calcUNonNewtonian.Add(new Tuple<double, Tuple<List<double>, List<double>>>
                    (z, Calc.U(tmin, tmax, tinterval, z, nu, kappa, bigOmega)));
                calcFNonNewtonian.Add(new Tuple<double, Tuple<List<double>, List<double>>>
                    (z, Calc.F(tmin, tmax, tinterval, z, nu, kappa, bigOmega)));
                calcUNewtonian.Add(new Tuple<double, Tuple<List<double>, List<double>>>
                    (z, Calc.U(tmin, tmax, tinterval, z, nu, 0, bigOmega)));
                calcFNewtonian.Add(new Tuple<double, Tuple<List<double>, List<double>>>
                    (z, Calc.F(tmin, tmax, tinterval, z, nu, 0, bigOmega)));
            }

            zCount = calcUNonNewtonian.Count;
            tCount = calcUNonNewtonian.First().Item2.Item1.Count;

            this.mainChart.ChartAreas[0].AxisX.Minimum = zmin;
            this.mainChart.ChartAreas[0].AxisX.Maximum = zmax;

            this.mainChart.ChartAreas[0].AxisY.Minimum = -zmax;
            this.mainChart.ChartAreas[0].AxisY.Maximum =  zmax;

            timerTicker = 0;

            Timer.Enabled = true;
            btSpecificT.Enabled = btSpecificZ.Enabled = BtStop.Enabled = true;
        }


        public void Double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        public void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int timerTicker = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            mainChart.Series[0].Points.Clear();
            mainChart.Series[1].Points.Clear();
            mainChart.Series[2].Points.Clear();
            mainChart.Series[3].Points.Clear();

            if (timerTicker >= tCount)
            {
                Timer.Enabled = false;
                BtStart.Enabled = true;
                return;
            }

            for(int j = 0; j < zCount; ++j)
            {
                double z = calcUNonNewtonian[j].Item1;
                double UNonNewtonian = calcUNonNewtonian[j].Item2.Item2[timerTicker];
                double FNonNewtonian = calcFNonNewtonian[j].Item2.Item2[timerTicker];

                double UNewtonian = calcUNewtonian[j].Item2.Item2[timerTicker];
                double FNewtonian = calcFNewtonian[j].Item2.Item2[timerTicker];

                if (ChbU.Checked)
                {
                    mainChart.Series[0].Points.AddXY(z, UNonNewtonian);
                    mainChart.Series[2].Points.AddXY(z, UNewtonian);
                }
                if(ChbF.Checked)
                {
                    mainChart.Series[1].Points.AddXY(z, FNonNewtonian);
                    mainChart.Series[3].Points.AddXY(z, FNewtonian);
                }
            }

            ++timerTicker;
        }

        private void BtSpecificZ_Click(object sender, EventArgs e)
        {
            if (app == null) app = new Microsoft.Office.Interop.Excel.Application();

            SetValuesForZ svfz = new SetValuesForZ(app);
            svfz.ShowDialog();
        }

        private void BtSpecificT_Click(object sender, EventArgs e)
        {
            if (app == null) app = new Microsoft.Office.Interop.Excel.Application();

            SetValuesForT svft = new SetValuesForT(app);
            svft.ShowDialog();
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TbBigOmega.Text = TbKappa.Text = TbNu.Text = TbTInterval.Text = TbTMax.Text = TbTMin.Text = TbZInterval.Text = TbZMax.Text = TbZMin.Text = "";
        }
    }
}
