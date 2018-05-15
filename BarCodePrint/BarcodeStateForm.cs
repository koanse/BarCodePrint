using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxBARCODEWIZLib;
using BARCODEWIZLib;
using System.IO;
using System.Threading;

namespace BarCodePrint
{
    public partial class BarcodeStateForm : Form
    {
        public BarcodeStateForm(BarcodeState state, DialogMode mode)
        {
            InitializeComponent();
            InitializeComboBoxes();
            bc.ScaleMode = enumSCALE_MODE.Scale_Millimeter;
            bc.Barcode = "12345";
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                bc.TopText = "Заголовок";
                bc.BottomText = "Подпись";
            }
            else
            {
                bc.TopText = "Top text";
                bc.BottomText = "Bottom text";
            }
            bc.BackColor = Color.White;
            if (state == null)
                state = new BarcodeState(bc);
            InitializeControlsValues(state);
            if (mode == DialogMode.Master)
            {
                btnBack.Visible = true;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    btnOk.Text = "Далее";
                else
                    btnOk.Text = "Next";
            }
        }
        public BarcodeState GetState()
        {
            return new BarcodeState(bc);
        }
        void InitializeComboBoxes()
        {
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                string[] arrStr = new string[] {
                "Code 39", "Code 39 Extended",
                "Code 128 A", "Code 128 B",
                "Code 128 C", "Code 128 Auto",
                "EAN 128", "Interleaved 2of5",
                "Standart 2of5", "Code 93",
                "Code 11", "Codabar",
                "UPC A", "UPC E",
                "EAN 13", "EAN 8",
                "PostNet", "RoyalMail"
            };
                IComparable[] arrObj = new IComparable[] {
                enumSYMBOLOGY.Code_39, enumSYMBOLOGY.Code_39_Extended,
                enumSYMBOLOGY.Code_128_A, enumSYMBOLOGY.Code_128_B,
                enumSYMBOLOGY.Code_128_C, enumSYMBOLOGY.Code_128_Auto,
                enumSYMBOLOGY.EAN_128, enumSYMBOLOGY.Interleaved_2of5,
                enumSYMBOLOGY.Standard_2of5, enumSYMBOLOGY.Code_93,
                enumSYMBOLOGY.Code_11, enumSYMBOLOGY.Codabar,
                enumSYMBOLOGY.UPC_A, enumSYMBOLOGY.UPC_E,
                enumSYMBOLOGY.EAN_13, enumSYMBOLOGY.EAN_8,
                enumSYMBOLOGY.PostNet, enumSYMBOLOGY.RoyalMail
            };
                cbSymb.Initialize(arrStr, arrObj, "Code 39");

                arrStr = new string[] {
                "Без знака", "Код и текст",
                "Только код"
            };
                arrObj = new IComparable[] {
                enumOPTIONAL_CHECK.No_Check_Char, enumOPTIONAL_CHECK.Barcode_And_Text,
                enumOPTIONAL_CHECK.Barcode_Only
            };
                cbOptCheck.Initialize(arrStr, arrObj, "Без знака");

                arrStr = new string[] {
                "0 градусов", "90 градусов",
                "180 градусов", "270 градусов"
            };
                arrObj = new IComparable[] {
                enumORIENTATION.Degrees_0, enumORIENTATION.Degrees_90,
                enumORIENTATION.Degrees_180, enumORIENTATION.Degrees_270
            };
                cbOrient.Initialize(arrStr, arrObj, "0 градусов");

                arrStr = new string[] {
                "Внизу", "Вверху",
                "Без текста"
            };
                arrObj = new IComparable[] {
                enumB_T_POSITION.Bottom_Center, enumB_T_POSITION.Top_Center,
                enumB_T_POSITION.No_Text
            };
                cbCodePos.Initialize(arrStr, arrObj, "Внизу");

                arrStr = new string[] {
                "Без рамки", "Тонкая сплошная",
                "Тонкая пунктирная", "Тонкая точечная",
                "Толстая сплошная", "Толстая пунктирная",
                "Толстая точечная", "Тонкая округлая"
            };
                arrObj = new IComparable[] {
                enumBORDER.No_Border, enumBORDER.Thin_Solid,
                enumBORDER.Thin_Dash, enumBORDER.Thin_Dot,
                enumBORDER.Thick_Solid, enumBORDER.Thick_Dash,
                enumBORDER.Thick_Dot, enumBORDER.Thin_Rd_Solid
            };
                cbBorder.Initialize(arrStr, arrObj, "Без рамки");

                arrStr = new string[] {
                "Без зоны", "Наименьшая зона",
                "Малая зона", "Средняя зона",
                "Большая зона", "Наибольшая зона"
            };
                arrObj = new IComparable[] {
                enumQUIET_ZONE.No_Zone, enumQUIET_ZONE.Smallest_Zone,
                enumQUIET_ZONE.Small_Zone, enumQUIET_ZONE.Medium_Zone,
                enumQUIET_ZONE.Large_Zone, enumQUIET_ZONE.Largest_Zone
            };
                cbQz.Initialize(arrStr, arrObj, "Средняя зона");
            }
            else
            {
                string[] arrStr = new string[] {
                "Code 39", "Code 39 Extended",
                "Code 128 A", "Code 128 B",
                "Code 128 C", "Code 128 Auto",
                "EAN 128", "Interleaved 2of5",
                "Standart 2of5", "Code 93",
                "Code 11", "Codabar",
                "UPC A", "UPC E",
                "EAN 13", "EAN 8",
                "PostNet", "RoyalMail"
            };
                IComparable[] arrObj = new IComparable[] {
                enumSYMBOLOGY.Code_39, enumSYMBOLOGY.Code_39_Extended,
                enumSYMBOLOGY.Code_128_A, enumSYMBOLOGY.Code_128_B,
                enumSYMBOLOGY.Code_128_C, enumSYMBOLOGY.Code_128_Auto,
                enumSYMBOLOGY.EAN_128, enumSYMBOLOGY.Interleaved_2of5,
                enumSYMBOLOGY.Standard_2of5, enumSYMBOLOGY.Code_93,
                enumSYMBOLOGY.Code_11, enumSYMBOLOGY.Codabar,
                enumSYMBOLOGY.UPC_A, enumSYMBOLOGY.UPC_E,
                enumSYMBOLOGY.EAN_13, enumSYMBOLOGY.EAN_8,
                enumSYMBOLOGY.PostNet, enumSYMBOLOGY.RoyalMail
            };
                cbSymb.Initialize(arrStr, arrObj, "Code 39");

                arrStr = new string[] {
                "No check char", "Barcode and text",
                "Barcode only"
            };
                arrObj = new IComparable[] {
                enumOPTIONAL_CHECK.No_Check_Char, enumOPTIONAL_CHECK.Barcode_And_Text,
                enumOPTIONAL_CHECK.Barcode_Only
            };
                cbOptCheck.Initialize(arrStr, arrObj, "No check char");

                arrStr = new string[] {
                "0 degrees", "90 degrees",
                "180 degrees", "270 degrees"
            };
                arrObj = new IComparable[] {
                enumORIENTATION.Degrees_0, enumORIENTATION.Degrees_90,
                enumORIENTATION.Degrees_180, enumORIENTATION.Degrees_270
            };
                cbOrient.Initialize(arrStr, arrObj, "0 degrees");

                arrStr = new string[] {
                "Bottom", "Top",
                "No text"
            };
                arrObj = new IComparable[] {
                enumB_T_POSITION.Bottom_Center, enumB_T_POSITION.Top_Center,
                enumB_T_POSITION.No_Text
            };
                cbCodePos.Initialize(arrStr, arrObj, "Bottom");

                arrStr = new string[] {
                "No border", "Thin solid",
                "Thin dash", "Thin dot",
                "Thick solid", "Thick dash",
                "Thick dot", "Thin round solid"
            };
                arrObj = new IComparable[] {
                enumBORDER.No_Border, enumBORDER.Thin_Solid,
                enumBORDER.Thin_Dash, enumBORDER.Thin_Dot,
                enumBORDER.Thick_Solid, enumBORDER.Thick_Dash,
                enumBORDER.Thick_Dot, enumBORDER.Thin_Rd_Solid
            };
                cbBorder.Initialize(arrStr, arrObj, "No border");

                arrStr = new string[] {
                "No quiet zone", "Smallest zone",
                "Small zone", "Medium zone",
                "Large zone", "Largest zone"
            };
                arrObj = new IComparable[] {
                enumQUIET_ZONE.No_Zone, enumQUIET_ZONE.Smallest_Zone,
                enumQUIET_ZONE.Small_Zone, enumQUIET_ZONE.Medium_Zone,
                enumQUIET_ZONE.Large_Zone, enumQUIET_ZONE.Largest_Zone
            };
                cbQz.Initialize(arrStr, arrObj, "Medium zone");
            }
        }
        void InitializeControlsValues(BarcodeState state)
        {
            cbSymb.SetSelectedText(state.symb);
            cbOptCheck.SetSelectedText(state.optCheck);
            cbOrient.SetSelectedText(state.orient);
            tbHeight.Text = state.heigth.ToString();
            tbNbw.Text = state.nbWigth.ToString();
            cbCodePos.SetSelectedText(state.bcTextPos);
            cbBorder.SetSelectedText(state.border);
            cbQz.SetSelectedText(state.qZone);
            lBackColor.BackColor = state.bColor;
            lForeColor.BackColor = state.fColor;
            bc.BackColor = state.bColor;
            bc.ForeColor = state.fColor;
            chbBb.Checked = state.bBars;
            bc.TopTextFont = state.topFont;
            bc.BarcodeTextFont = state.bcFont;
            bc.BottomTextFont = state.botFont;
        }
        void cb_tb_TextChanged(object sender, EventArgs e)
        {
            bc.Symbology = (enumSYMBOLOGY)cbSymb.GetSelectedObject();
            bc.OptionalCheckChar = (enumOPTIONAL_CHECK)cbOptCheck.GetSelectedObject();
            bc.Orientation = (enumORIENTATION)cbOrient.GetSelectedObject();
            bc.BarcodeTextPosition = (enumB_T_POSITION)cbCodePos.GetSelectedObject();
            bc.Border = (enumBORDER)cbBorder.GetSelectedObject();
            bc.QuietZone = (enumQUIET_ZONE)cbQz.GetSelectedObject();
            bc.BearerBars = chbBb.Checked;
            
            float height, nbw;
            try
            {
                height = float.Parse(tbHeight.Text);
                if (height < 1 || height > 200)
                    throw new Exception();
            }
            catch
            {
                height = 15;
            }
            bc.BarcodeHeight = height;
            try
            {
                nbw = float.Parse(tbNbw.Text);
                if (nbw < 0.1f || nbw > 5)
                    throw new Exception();
            }
            catch
            {
                nbw = 0.35f;
            }
            bc.NarrowBarWidth = nbw;
        }
        void tb_Leave(object sender, EventArgs e)
        {
            tbHeight.Text = bc.BarcodeHeight.ToString();
            tbNbw.Text = bc.NarrowBarWidth.ToString();
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }
        void btnTopTextFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = bc.TopTextFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                bc.TopTextFont = fontDialog1.Font;
        }
        void btnBarcodeTextFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = bc.BarcodeTextFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                bc.BarcodeTextFont = fontDialog1.Font;
        }
        void btnBottomTextFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = bc.BottomTextFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                bc.BottomTextFont = fontDialog1.Font;
        }
        void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bc.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bc.BackColor = colorDialog1.Color;
                lBackColor.BackColor = colorDialog1.Color;
            }
        }
        void btnForeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bc.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bc.ForeColor = colorDialog1.Color;
                lForeColor.BackColor = colorDialog1.Color;
            }
        }
    }
}