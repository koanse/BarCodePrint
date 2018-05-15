using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OracleClient;

namespace BarCodePrint
{
    public partial class DataSourceForm : Form
    {
        decimal plantId;
        public DataSourceForm(BcSource source, decimal plantId,
            OracleConnection connection, DialogMode mode)
        {
            InitializeComponent();
            switch (source)
            {
                case BcSource.Workers:
                    rbWork.Checked = true;
                    break;
                case BcSource.Defects:
                    rbDef.Checked = true;
                    break;
                case BcSource.Repairs:
                    rbRep.Checked = true;
                    break;
            }
            this.plantId = plantId;
            plantTableAdapter.Connection = connection;
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Далее";
                else
                    btnOk.Text = "Next";
            }
        }
        public BcSource GetSource(out decimal plantId)
        {
            RewDataSet.PlantRow r =
                (plantBindingSource.Current as DataRowView).Row
                as RewDataSet.PlantRow;
            plantId = r.PlantId;
            if (rbWork.Checked)
                return BcSource.Workers;
            if (rbDef.Checked)
                return BcSource.Defects;
            if (rbRep.Checked)
                return BcSource.Repairs;
            throw new Exception();
        }
        private void DataSourceForm_Load(object sender, EventArgs e)
        {
            try
            {
                plantTableAdapter.Fill(rewDataSet.Plant);
                lbPlant.SelectedValue = plantId;
                if (lbPlant.SelectedItem == null)
                    lbPlant.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Database error", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }
    }
}