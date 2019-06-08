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
    public partial class SetValuesForZ : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        public SetValuesForZ(Microsoft.Office.Interop.Excel.Application app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var wb = app.Workbooks.Add();

            double tmin = Convert.ToDouble(TbTMin.Text);
            double tmax = Convert.ToDouble(TbTMax.Text);
            double tinterval = Convert.ToDouble(TbTInterval.Text);

            double z = Convert.ToDouble(TbZ.Text);

            double nu = Convert.ToDouble(TbNu.Text);
            double kappa = Convert.ToDouble(TbKappa.Text);
            double bigOmega = Convert.ToDouble(TbBigOmega.Text);
            
            var wsU = wb.Worksheets.Add();
            wsU.Name = "Функция u";

            wsU.Cells[1, 1].Value = "z";
            wsU.Cells[1, 2].Value = "u";
       
            var calcU = Calc.U(tmin, tmax, tinterval, z, nu, kappa, bigOmega);
            for (int i = 0; i < calcU.Item1.Count; ++i)
            {
                wsU.Cells[i + 2, 1].Value = calcU.Item1[i];
                wsU.Cells[i + 2, 2].Value = calcU.Item2[i];
            }
            
            var wsF = wb.Worksheets.Add();
            wsF.Name = "Функция f";

            wsF.Cells[1, 1].Value = "z";
            wsF.Cells[1, 2].Value = "f";

            var calcF = Calc.F(tmin, tmax, tinterval, z, nu, kappa, bigOmega);
            for (int i = 0; i < calcF.Item1.Count; ++i)
            {
                wsF.Cells[i + 2, 1].Value = calcF.Item1[i];
                wsF.Cells[i + 2, 2].Value = calcF.Item2[i];
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FileName = $"z = {z}"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(sfd.FileName);
                wb.Close();

                Close();
            }

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

        private void TbTInterval_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
