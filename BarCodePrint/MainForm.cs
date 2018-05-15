using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OracleClient;
using System.Threading;
using AxBARCODEWIZLib;

namespace BarCodePrint
{
    public partial class MainForm : Form
    {
        int maxRecentProjects = 15;
        OracleConnection connection;
        BcProject prCur;
        string prevName;
        bool hasChanges = false;
        public MainForm(OracleConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            InitializeProjectList();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "Project.bcp";
            BcSource source = BcSource.Workers;
            decimal plantId = -1;
            RewDataSet.BarcodeDataTable table = null;
            BarcodeData data = null;
            BarcodeState state = null;
            BcLayout layout = null;
            
            int i = 0;
            do
            {
                DialogResult res = DialogResult.None;
                switch (i)
                {
                    case 0:
                        saveFileDialog1.FileName = filename;
                        res = saveFileDialog1.ShowDialog();
                        filename = saveFileDialog1.FileName;
                        break;
                    case 1:
                        DataSourceForm dForm = new DataSourceForm(source, plantId,
                            connection, DialogMode.Master);
                        res = dForm.ShowDialog();
                        source = dForm.GetSource(out plantId);
                        break;
                    case 2:
                        switch (source)
                        {
                            case BcSource.Workers:
                                WorkFilterForm fWork = new WorkFilterForm(connection,
                                    table, plantId, DialogMode.Master);
                                res = fWork.ShowDialog();
                                table = fWork.GetTable();
                                break;
                            case BcSource.Defects:
                                DefFilterForm fDef = new DefFilterForm(connection,
                                    table, plantId, DialogMode.Master);
                                res = fDef.ShowDialog();
                                table = fDef.GetTable();
                                break;
                            case BcSource.Repairs:
                                RepFilterForm fRep = new RepFilterForm(connection,
                                    table, plantId, DialogMode.Master);
                                res = fRep.ShowDialog();
                                table = fRep.GetTable();
                                break;
                        }
                        break;
                    case 3:
                        BarcodeDataForm fData = new BarcodeDataForm(data,
                            DialogMode.Master);
                        res = fData.ShowDialog();
                        data = fData.GetData();
                        break;
                    case 4:
                        BarcodeStateForm fState = new BarcodeStateForm(state,
                            DialogMode.Master);
                        res = fState.ShowDialog();
                        state = fState.GetState();
                        break;
                    case 5:
                        LayoutForm fLayout = new LayoutForm(layout, DialogMode.Master);
                        res = fLayout.ShowDialog();
                        layout = fLayout.GetLayout();
                        break;
                }
                switch (res)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.OK:
                        i++;
                        break;
                    case DialogResult.Retry:
                        i--;
                        break;
                }
            }
            while (i < 6);
            BcProject project = new BcProject(source, plantId, table,
                data, state, layout, new PageSettings());
            try
            {
                project.Save(filename);
            }
            catch
            {
                MessageBox.Show("Cannot write file", "Save error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hasChanges = false;
            AddToProjectList(filename);
        }
        private void lbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filename = (string)lbProjects.SelectedItem;
                if (filename != prevName)
                {
                    if (TryToSaveChanges() == DialogResult.Cancel)
                    {
                        lbProjects.SelectedItem = prevName;
                        return;
                    }
                    hasChanges = false;
                    prevName = filename;
                    prCur = BcProject.FromFile(filename);
                    BcPrintDocument doc = new BcPrintDocument(bc, prCur);
                    ppc.Document = doc;
                    ppc.InvalidatePreview();
                    ppc.Select();
                }
                else
                {
                    //if (hasChanges == false)
                    //    return;
                    BcPrintDocument doc = new BcPrintDocument(bc, prCur);
                    ppc.Document = doc;
                    ppc.InvalidatePreview();
                    ppc.Select();
                }
            }
            catch
            {
                prCur = null;
                RemoveFromProjectList((string)lbProjects.SelectedItem);
            }
        }
        private void InitializeProjectList()
        {
            if (Properties.Settings.Default.Projects == null)
            {
                Properties.Settings.Default.Projects = new ArrayList();
                Properties.Settings.Default.Save();
            }
            ArrayList projects = Properties.Settings.Default.Projects;
            foreach (string s in projects)
                lbProjects.Items.Add(s);
        }
        private void AddToProjectList(string filename)
        {
            ArrayList projects = Properties.Settings.Default.Projects;
            if (projects.Contains(filename))
                projects.Remove(filename);
            projects.Add(filename);
            while (projects.Count > maxRecentProjects)
                projects.RemoveAt(0);
            lbProjects.Items.Clear();
            foreach (string s in projects)
                lbProjects.Items.Add(s);
            Properties.Settings.Default.Projects = projects;
            Properties.Settings.Default.Save();
            lbProjects.SelectedItem = filename;
        }
        private void RemoveFromProjectList(string filename)
        {
            lbProjects.Items.Remove(filename);
            ArrayList projects = Properties.Settings.Default.Projects;
            projects.Remove(filename);
            Properties.Settings.Default.Projects = projects;
            Properties.Settings.Default.Save();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = ppc.Document;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDialog1.Document.Print();
            }
            catch
            {
                MessageBox.Show("Cannot print document", "Print error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                foreach (string s in openFileDialog1.FileNames)
                {
                    BcProject project = BcProject.FromFile(s);
                    AddToProjectList(s);
                }
            }
            catch
            {
                MessageBox.Show("Cannot open project", "File read error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (prCur.source)
                {
                    case BcSource.Workers:
                        WorkFilterForm fWork = new WorkFilterForm(connection,
                            prCur.table, prCur.plantId, DialogMode.Usial);
                        if (fWork.ShowDialog() != DialogResult.OK)
                            return;
                        prCur.table = fWork.GetTable();
                        break;
                    case BcSource.Defects:
                        DefFilterForm fDef = new DefFilterForm(connection,
                            prCur.table, prCur.plantId, DialogMode.Usial);
                        if (fDef.ShowDialog() != DialogResult.OK)
                            return;
                        prCur.table = fDef.GetTable();
                        break;
                    case BcSource.Repairs:
                        RepFilterForm fRep = new RepFilterForm(connection,
                            prCur.table, prCur.plantId, DialogMode.Usial);
                        if (fRep.ShowDialog() != DialogResult.OK)
                            return;
                        prCur.table = fRep.GetTable();
                        break;
                }
                hasChanges = true;
                lbProjects_SelectedIndexChanged(null, null);
            }
            catch { }
        }
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeDataForm bdForm = new BarcodeDataForm(prCur.data, DialogMode.Usial);
                if (bdForm.ShowDialog() != DialogResult.OK)
                    return;
                prCur.data = bdForm.GetData();
                hasChanges = true;
                lbProjects_SelectedIndexChanged(null, null);
            }
            catch { }
        }
        private void barcodePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeStateForm bsForm = new BarcodeStateForm(prCur.state, DialogMode.Usial);
                if (bsForm.ShowDialog() != DialogResult.OK)
                    return;
                prCur.state = bsForm.GetState();
                hasChanges = true;
                lbProjects_SelectedIndexChanged(null, null);
            }
            catch { }
        }
        private void pageLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LayoutForm lForm = new LayoutForm(prCur.layout, DialogMode.Usial);
                if (lForm.ShowDialog() != DialogResult.OK)
                    return;
                prCur.layout = lForm.GetLayout();
                hasChanges = true;
                lbProjects_SelectedIndexChanged(null, null);
            }
            catch { }
        }
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.Document = ppc.Document;
                if (pageSetupDialog1.ShowDialog() != DialogResult.OK)
                    return;
                prCur.pageSettings = pageSetupDialog1.PageSettings;
                hasChanges = true;
                lbProjects_SelectedIndexChanged(null, null);
            }
            catch { }
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ppc.Document.Print();
            }
            catch
            {
                MessageBox.Show("Cannot print document", "Print error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = ppc.Document;
                printPreviewDialog1.ShowDialog();
            }
            catch { }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BcProject project = BcProject.FromFile((string)lbProjects.SelectedItem);
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                project.Save(saveFileDialog1.FileName);
                AddToProjectList(saveFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Cannot save project", "File write error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                prCur.Save((string)lbProjects.SelectedItem);
                hasChanges = false;
            }
            catch { }
        }
        private void dataSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSourceForm dForm = new DataSourceForm(prCur.source,
                    prCur.plantId, connection, DialogMode.Usial);
                if (dForm.ShowDialog() != DialogResult.OK)
                    return;
                prCur.source = dForm.GetSource(out prCur.plantId);
                hasChanges = true;
                filterToolStripMenuItem_Click(null, null);
            }
            catch { }
        }
        private DialogResult TryToSaveChanges()
        {
            DialogResult res = DialogResult.OK;
            if (hasChanges)
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    res = MessageBox.Show("Сохранить изменения?", "Сохранение",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                else
                    res = MessageBox.Show("Save changes?", "Save",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return DialogResult.Cancel;
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        prCur.Save(prevName);
                    }
                    catch
                    {
                        MessageBox.Show("Cannot write to file", "File write error",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    hasChanges = false;
                }
            }
            return res;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TryToSaveChanges() == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}