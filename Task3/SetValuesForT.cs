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
    public partial class SetValuesForT : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        public SetValuesForT(Microsoft.Office.Interop.Excel.Application app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var wb = app.Workbooks.Add();

            double zmin = Convert.ToDouble(TbZMin.Text);
            double zmax = Convert.ToDouble(TbZMax.Text);
            double zinterval = Convert.ToDouble(TbZInterval.Text);

            double t = Convert.ToDouble(TbT.Text);
            double tAcc = Convert.ToDouble(TbTAcc.Text);

            double nu = Convert.ToDouble(TbNu.Text);
            double kappa = Convert.ToDouble(TbKappa.Text);
            double bigOmega = Convert.ToDouble(TbBigOmega.Text);
            
            var wsU = wb.Worksheets.Add();
            wsU.Name = "Функция u";

            wsU.Cells[1, 1].Value = "z";
            wsU.Cells[1, 2].Value = "u";

            int i = 2;
            for (double z = zmin; z < zmax; z += zinterval)
            {                
                var calcU = Calc.U(t, t, tAcc, z, nu, kappa, bigOmega);
                wsU.Cells[i, 1].Value = z;
                wsU.Cells[i, 2].Value = calcU.Item2.First();

                ++i;
            }
            
            var wsF = wb.Worksheets.Add();
            wsF.Name = "Функция f";

            wsF.Cells[1, 1].Value = "z";
            wsF.Cells[1, 2].Value = "f";

            i = 2;
            for (double z = zmin; z < zmax; z += zinterval)
            {
                var calcF = Calc.F(t, t, tAcc, z, nu, kappa, bigOmega);
                wsF.Cells[i, 1].Value = z;
                wsF.Cells[i, 2].Value = calcF.Item2.First();

                ++i;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FileName = $"t = {t}"
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
    }
}
