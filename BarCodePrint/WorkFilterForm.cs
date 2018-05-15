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
    public partial class WorkFilterForm : Form
    {
        decimal plantId;
        public WorkFilterForm(OracleConnection connection,
            RewDataSet.BarcodeDataTable table, decimal plantId,
            DialogMode mode)
        {
            InitializeComponent();
            this.plantId = plantId;
            if (table != null)
                foreach (RewDataSet.BarcodeRow row in table)
                    rewDataSet.Barcode.AddBarcodeRow(row.Id,
                        row.Name, row.NameEng, row.Code);
            workerTableAdapter.Connection = connection;
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Далее";
                else
                    btnOk.Text = "Next";
            }
        }
        private void WorkFilterForm_Load(object sender, EventArgs e)
        {
            workerTableAdapter.FillByPlantId(rewDataSet.Worker, plantId);
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                rewDataSet.WorkType.AddWorkTypeRow(1, "Контроллер");
                rewDataSet.WorkType.AddWorkTypeRow(2, "Ремонтник");
                rewDataSet.WorkType.AddWorkTypeRow(3, "Менеджер");
                rewDataSet.WorkType.AddWorkTypeRow(4, "Оператор");
            }
            else
            {
                rewDataSet.WorkType.AddWorkTypeRow(1, "Controller");
                rewDataSet.WorkType.AddWorkTypeRow(2, "Repairer");
                rewDataSet.WorkType.AddWorkTypeRow(3, "Manager");
                rewDataSet.WorkType.AddWorkTypeRow(4, "Operator");
            }

            foreach (RewDataSet.WorkerRow row in rewDataSet.Worker)
                if (rewDataSet.Barcode.Rows.Count > 0 &&
                    rewDataSet.Barcode.FindById(row.WorkId) != null)
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
            if (cbShowRep.Checked)
                foreach (RewDataSet.WorkerRow row in rewDataSet.Worker.Rows)
                    if (row.WorkType == 2)
                        row.Visible = true;
                    else
                        row.Visible = false;
            else
                foreach (RewDataSet.WorkerRow row in rewDataSet.Worker.Rows)
                    row.Visible = true;
            dgv.ResumeLayout();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgv.SuspendLayout();
            foreach (RewDataSet.WorkerRow row in rewDataSet.Worker.Rows)
                row.Visible = false;
            dgv.ResumeLayout();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DataRow[] rows = rewDataSet.Worker.Select("VISIBLE = TRUE");
            rewDataSet.Barcode.Rows.Clear();
            foreach (RewDataSet.WorkerRow row in rows)
                rewDataSet.Barcode.AddBarcodeRow(row.WorkId,
                    row.WorkName, row.WorkNameEng, row.WorkCode);
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
            DataRow[] rows = rewDataSet.Worker.Select("VISIBLE = TRUE");
            rewDataSet.Barcode.Rows.Clear();
            foreach (RewDataSet.WorkerRow row in rows)
                rewDataSet.Barcode.AddBarcodeRow(row.WorkId,
                    row.WorkName, row.WorkNameEng, row.WorkCode);
            Close();
        }
        private void cbShowRep_CheckedChanged(object sender, EventArgs e)
        {
            dgv.SuspendLayout();
            if (cbShowRep.Checked)
            {
                workerBindingSource.Filter = "WORKTYPE = 2";
                foreach (RewDataSet.WorkerRow row in rewDataSet.Worker.Rows)
                    if (row.WorkType == 2)
                        row.Visible = true;
                    else
                        row.Visible = false;
            }
            else
                workerBindingSource.Filter = "";
            dgv.ResumeLayout();
        }
    }
}