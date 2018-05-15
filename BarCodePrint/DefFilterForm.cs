using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;

namespace BarCodePrint
{
    public partial class DefFilterForm : Form
    {
        decimal plantId;
        public DefFilterForm(OracleConnection connection,
            RewDataSet.BarcodeDataTable table, decimal plantId,
            DialogMode mode)
        {
            InitializeComponent();
            this.plantId = plantId;
            if (table != null)
                foreach (RewDataSet.BarcodeRow row in table)
                    rewDataSet.Barcode.AddBarcodeRow(row.Id,
                        row.Name, row.NameEng, row.Code);
            defTableAdapter.Connection = connection;
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Далее";
                else
                    btnOk.Text = "Next";
            }
        }
        private void DefFilterForm_Load(object sender, EventArgs e)
        {
            defTableAdapter.FillByPlantId(rewDataSet.DefType, plantId);

            foreach (RewDataSet.DefTypeRow row in rewDataSet.DefType)
                if (rewDataSet.Barcode.Rows.Count > 0 &&
                    rewDataSet.Barcode.FindById(row.DefTypeId) != null)
                    row.Visible = true;
                else
                    row.Visible = false;
        }
        public RewDataSet.BarcodeDataTable GetTable()
        {
            return rewDataSet.Barcode;
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dgv.SuspendLayout();
            foreach (RewDataSet.DefTypeRow row in rewDataSet.DefType.Rows)
                row.Visible = true;
            dgv.ResumeLayout();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgv.SuspendLayout();
            foreach (RewDataSet.DefTypeRow row in rewDataSet.DefType.Rows)
                row.Visible = false;
            dgv.ResumeLayout();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DataRow[] rows = rewDataSet.DefType.Select("VISIBLE = TRUE");
            rewDataSet.Barcode.Rows.Clear();
            foreach (RewDataSet.DefTypeRow row in rows)
                rewDataSet.Barcode.AddBarcodeRow(row.DefTypeId,
                    row.DefTypeName, row.DefTypeNameEng, row.DefTypeCode);
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();     
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            DataRow[] rows = rewDataSet.DefType.Select("VISIBLE = TRUE");
            rewDataSet.Barcode.Rows.Clear();
            foreach (RewDataSet.DefTypeRow row in rows)
                rewDataSet.Barcode.AddBarcodeRow(row.DefTypeId,
                    row.DefTypeName, row.DefTypeNameEng, row.DefTypeCode);
            Close();
        }
    }
}