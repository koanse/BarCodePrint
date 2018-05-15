using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BarCodePrint
{
    public partial class LayoutForm : Form
    {
        public LayoutForm(BcLayout layout, DialogMode mode)
        {
            InitializeComponent();
            if (layout != null)
                InitializeControlsValues(layout);
            else
            {
                tbHorDist.Text = "10";
                tbVerDist.Text = "15";
            }
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Завершить";
                else
                    btnOk.Text = "Finish";
            }
        }
        public BcLayout GetLayout()
        {
            float xDist, yDist;
            xDist = float.Parse(tbHorDist.Text);
            yDist = float.Parse(tbVerDist.Text);
            return new BcLayout(tbTitle.Text, fontDialog1.Font,
                chbPrintOnce.Checked, xDist, yDist);
        }
        private void InitializeControlsValues(BcLayout layout)
        {
            tbTitle.Text = layout.title;
            fontDialog1.Font = layout.titleFont;
            chbPrintOnce.Checked = layout.printTitleOnce;
            tbHorDist.Text = layout.xDist.ToString();
            tbVerDist.Text = layout.yDist.ToString();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            float xDist, yDist;
            try
            {
                xDist = float.Parse(tbHorDist.Text);
                yDist = float.Parse(tbVerDist.Text);
                if (xDist < 0 || yDist < 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Wrong distance", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            float xDist, yDist;
            try
            {
                xDist = float.Parse(tbHorDist.Text);
                yDist = float.Parse(tbVerDist.Text);
                if (xDist < 0 || yDist < 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Wrong distance", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.Retry;
            Close();
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}