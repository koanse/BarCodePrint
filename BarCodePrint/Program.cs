using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AxBARCODEWIZLib;
using BARCODEWIZLib;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BarCodePrint
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogonForm logonForm = new LogonForm();
            Application.Run(logonForm);
            if (logonForm.DialogResult == DialogResult.OK)
                Application.Run(new MainForm(logonForm.conn));
        }
    }
    public enum DialogMode
    {
        Usial, Master
    }
    public enum BcSource
    {
        Workers, Defects, Repairs
    }
    [Serializable]
    public class BarcodeState
    {
        public enumSYMBOLOGY symb;
        public enumOPTIONAL_CHECK optCheck;
        public enumORIENTATION orient;
        public float heigth;
        public float nbWigth;
        public enumB_T_POSITION bcTextPos;
        public enumBORDER border;
        public enumQUIET_ZONE qZone;
        public Font topFont;
        public Font bcFont;
        public Font botFont;
        public Color fColor;
        public Color bColor;
        public bool bBars;
        public BarcodeState(AxBarCodeWiz bc)
        {
            enumSCALE_MODE oldScaleMode = bc.ScaleMode;
            bc.ScaleMode = enumSCALE_MODE.Scale_Millimeter;
            symb = bc.Symbology;
            optCheck = bc.OptionalCheckChar;
            orient = bc.Orientation;
            heigth = bc.BarcodeHeight;
            nbWigth = bc.NarrowBarWidth;
            bcTextPos = bc.BarcodeTextPosition;
            border = bc.Border;
            qZone = bc.QuietZone;
            topFont = bc.TopTextFont;
            bcFont = bc.BarcodeTextFont;
            botFont = bc.BottomTextFont;
            fColor = bc.ForeColor;
            bColor = bc.BackColor;
            bBars = bc.BearerBars;
            bc.ScaleMode = oldScaleMode;
        }
        public void ApplyState(AxBarCodeWiz bc)
        {
            enumSCALE_MODE oldScaleMode = bc.ScaleMode;
            bc.ScaleMode = enumSCALE_MODE.Scale_Millimeter;
            bc.Symbology = symb;
            bc.OptionalCheckChar = optCheck;
            bc.Orientation = orient;
            bc.BarcodeHeight = heigth;
            bc.NarrowBarWidth = nbWigth;
            bc.BarcodeTextPosition = bcTextPos;
            bc.Border = border;
            bc.QuietZone = qZone;
            bc.TopTextFont = topFont;
            bc.BarcodeTextFont = bcFont;
            bc.BottomTextFont = botFont;
            bc.ForeColor = fColor;
            bc.BackColor = bColor;
            bc.BearerBars = bBars;
            bc.ScaleMode = oldScaleMode;
        }
    }
    [Serializable]
    public class BarcodeData
    {
        public string topText;
        public string barcode;
        public string botText;
        public string prefix;
        public string sort;
        public BarcodeData(string topText, string barcode,
            string botText, string prefix, string sort)
        {

            this.topText = topText;
            this.barcode = barcode;
            this.botText = botText;
            this.prefix = prefix;
            this.sort = sort;
        }
    }
    [Serializable]
    public class BcLayout
    {
        public string title;
        public Font titleFont;
        public bool printTitleOnce;
        public float xDist;
        public float yDist;
        public BcLayout(string title, Font titleFont, bool printTitleOnce,
            float xDist, float yDist)
        {
            this.title = title;
            this.titleFont = titleFont;
            this.printTitleOnce = printTitleOnce;
            this.xDist = xDist;
            this.yDist = yDist;
        }
    }
    [Serializable]
    public class BcProject
    {
        public BcSource source;
        public decimal plantId;
        public RewDataSet.BarcodeDataTable table;
        public BarcodeData data;
        public BarcodeState state;
        public BcLayout layout;
        public PageSettings pageSettings;
        public BcProject(BcSource source, decimal plantId,
            RewDataSet.BarcodeDataTable table,
            BarcodeData data, BarcodeState state, BcLayout layout,
            PageSettings pageSettings)
        {
            this.source = source;
            this.plantId = plantId;
            this.table = table;
            this.data = data;
            this.state = state;
            this.layout = layout;
            this.pageSettings = pageSettings;
        }
        static public BcProject FromFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            BcProject project = (BcProject)bf.Deserialize(fs);
            fs.Close();
            return project;
        }
        public void Save(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
    public class BcPrintDocument : PrintDocument
    {
        float xDist, yDist;
        string title;
        Font titleFont;
        bool printTitleOnce;
        AxBarCodeWiz bc;
        public RewDataSet.BarcodeDataTable table;
        public BindingSource bs;
        public BarcodeData data;
        public BcPrintDocument(AxBarCodeWiz bc, BcProject project)
        {
            this.bc = bc;
            DefaultPageSettings = project.pageSettings;
            table = project.table;
            data = project.data;
            project.state.ApplyState(bc);
            xDist = project.layout.xDist;
            yDist = project.layout.yDist;
            title = project.layout.title;
            titleFont = project.layout.titleFont;
            printTitleOnce = project.layout.printTitleOnce;
            bs = new BindingSource();
            bs.DataSource = table;
            bs.Sort = data.sort;
            MarginsConverter mc = new MarginsConverter();
            xDist = (float)PrinterUnitConvert.Convert(xDist * 10,
                PrinterUnit.TenthsOfAMillimeter,
                PrinterUnit.Display);
            yDist = (float)PrinterUnitConvert.Convert(yDist * 10,
                PrinterUnit.TenthsOfAMillimeter,
                PrinterUnit.Display);
        }
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            bs.MoveFirst();
            base.OnBeginPrint(e);
        }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            try
            {
                e.HasMorePages = true;
                bc.ScaleMode = enumSCALE_MODE.Scale_Inch;
                bool printed = false;
                float x = e.MarginBounds.Left, y = e.MarginBounds.Top;
                float titleHeight = 0;
                if (title != string.Empty && title != "" &&
                    (printTitleOnce == true && bs.Position == 0 ||
                        printTitleOnce == false))
                {
                    titleHeight = e.Graphics.MeasureString(title, titleFont).Height * 2;
                    RectangleF rect = new RectangleF(x, y, e.MarginBounds.Width, titleHeight);
                    e.Graphics.DrawString(title, titleFont, Brushes.Black, rect);
                }
                y += titleHeight;
                while (bs.Position < bs.Count)
                {
                    float widthMax = float.MinValue;
                    RewDataSet.BarcodeRow r = (bs.Current as DataRowView).Row
                        as RewDataSet.BarcodeRow;
                    if (data.topText == "")
                        bc.TopText = "";
                    else
                        bc.TopText = r[data.topText].ToString();
                    bc.Barcode = data.prefix + r[data.barcode].ToString().Trim();
                    if (data.botText == "")
                        bc.BottomText = "";
                    else
                        bc.BottomText = r[data.botText].ToString();
                    if (widthMax < bc.Picture.Width)
                        widthMax = bc.Picture.Width;
                    if (x + bc.Picture.Width > e.MarginBounds.Right)
                        break;
                    if (y + bc.Picture.Height > e.MarginBounds.Bottom)
                    {
                        x = x + widthMax + xDist;
                        if (x > e.MarginBounds.Right)
                            break;
                        y = e.MarginBounds.Top + titleHeight;
                        widthMax = float.MinValue;
                        continue;
                    }
                    e.Graphics.DrawImage(bc.Picture, x, y,
                        bc.Picture.Width, bc.Picture.Height);
                    printed = true;
                    if (bs.Position == table.Rows.Count - 1)
                    {
                        e.HasMorePages = false;
                        break;
                    }
                    bs.MoveNext();
                    y += bc.Picture.Height + yDist;
                }
                if (printed == false)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Print error. Check barcode size and symbology",
                    "Print error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.HasMorePages = false;
            }
            base.OnPrintPage(e);
        }
        protected override void OnEndPrint(PrintEventArgs e)
        {
            base.OnEndPrint(e);
        }
    }
    public class AdvComboBox : ComboBox
    {
        bool initializing;
        string[] arrStr;
        string defText;
        IComparable[] arrObj;
        public AdvComboBox() { }
        public void Initialize(string[] arrStr, IComparable[] arrObj, string defText)
        {
            if (arrStr.Length != arrObj.Length)
                throw new ArgumentException();
            this.arrStr = arrStr;
            this.arrObj = arrObj;
            this.defText = defText;
            this.Items.Clear();
            for (int i = 0; i < arrStr.Length; i++)
                this.Items.Add(arrStr[i]);
            initializing = true;
            this.SelectedItem = defText;
            initializing = false;
        }
        public Object GetSelectedObject()
        {
            for (int i = 0; i < arrStr.Length; i++)
                if (arrStr[i] == Text)
                    return arrObj[i];
            return null;
        }
        public void SetSelectedText(IComparable obj)
        {
            for (int i = 0; i < arrObj.Length; i++)
                if (arrObj[i].CompareTo(obj) == 0)
                    Text = arrStr[i];
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (arrStr == null || arrObj == null || initializing)
                return;
            int i;
            for (i = 0; i < arrStr.Length; i++)
                if (arrStr[i] == Text)
                    break;
            if (i == arrStr.Length)
                Text = defText;
            base.OnTextChanged(e);
        }
    }
}