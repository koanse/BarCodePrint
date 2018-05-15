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
    public partial class BarcodeDataForm : Form
    {
        public BarcodeDataForm(BarcodeData data, DialogMode mode)
        {
            InitializeComponent();
            InitializeComboBoxes();
            if (data != null)
                InitializeControlsValues(data);
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Далее";
                else
                    btnOk.Text = "Next";
            }
        }
        public BarcodeData GetData()
        {
            return new BarcodeData((string)cbTopText.GetSelectedObject(),
                (string)cbBarcode.GetSelectedObject(),
                (string)cbBotText.GetSelectedObject(), tbPrefix.Text,
                (string)cbOrderBy.GetSelectedObject());
        }
        private void InitializeComboBoxes()
        {
            string[] arrStr;
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                arrStr = new string[] {
                "ID", "Наименование", "Наименование (англ.)", "Штрих-код", "Пусто"
            };
            else
                arrStr = new string[] {
                "ID", "Name", "Name (Eng.)", "Barcode", "No text"
            };
            IComparable[] arrObj = new IComparable[] {
                "Id", "Name", "NameEng", "Code", ""
            };
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                cbTopText.Initialize(arrStr, arrObj, "Пусто");
                cbBotText.Initialize(arrStr, arrObj, "Пусто");
            }
            else
            {
                cbTopText.Initialize(arrStr, arrObj, "No text");
                cbBotText.Initialize(arrStr, arrObj, "No text");
            }

            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                arrStr = new string[] {
                "ID", "Наименование", "Наименование (англ.)", "Штрих-код"
            };
            else
                arrStr = new string[] {
                "ID", "Name", "Name (Eng.)", "Barcode"
            };
            arrObj = new IComparable[] {
                "Id", "Name", "NameEng", "Code"
            };
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                cbBarcode.Initialize(arrStr, arrObj, "Штрих-код");
                cbOrderBy.Initialize(arrStr, arrObj, "Штрих-код");
            }
            else
            {
                cbBarcode.Initialize(arrStr, arrObj, "Barcode");
                cbOrderBy.Initialize(arrStr, arrObj, "Barcode");
            }
        }
        private void InitializeControlsValues(BarcodeData data)
        {
            cbTopText.SetSelectedText(data.topText);
            cbBarcode.SetSelectedText(data.barcode);
            cbBotText.SetSelectedText(data.botText);
            tbPrefix.Text = data.prefix;
            cbOrderBy.SetSelectedText(data.sort);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
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
            DialogResult = DialogResult.Retry;
            Close();
        }
    }
}