namespace BarCodePrint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbProjects = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ppc = new System.Windows.Forms.PrintPreviewControl();
            this.bc = new AxBARCODEWIZLib.AxBarCodeWiz();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleDescription = null;
            this.splitContainer1.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BackgroundImage = null;
            this.splitContainer1.Font = null;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleDescription = null;
            this.splitContainer1.Panel1.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.BackgroundImage = null;
            this.splitContainer1.Panel1.Controls.Add(this.lbProjects);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Font = null;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleDescription = null;
            this.splitContainer1.Panel2.AccessibleName = null;
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.BackgroundImage = null;
            this.splitContainer1.Panel2.Controls.Add(this.ppc);
            this.splitContainer1.Panel2.Font = null;
            // 
            // lbProjects
            // 
            this.lbProjects.AccessibleDescription = null;
            this.lbProjects.AccessibleName = null;
            resources.ApplyResources(this.lbProjects, "lbProjects");
            this.lbProjects.BackgroundImage = null;
            this.lbProjects.Font = null;
            this.lbProjects.FormattingEnabled = true;
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.SelectedIndexChanged += new System.EventHandler(this.lbProjects_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = null;
            this.toolStrip1.AccessibleName = null;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackgroundImage = null;
            this.toolStrip1.Font = null;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripButton,
            this.openToolStripButton,
            this.toolStripLabel1,
            this.saveToolStripButton});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.AccessibleDescription = null;
            this.printToolStripButton.AccessibleName = null;
            this.printToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.printToolStripButton, "printToolStripButton");
            this.printToolStripButton.BackgroundImage = null;
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.AccessibleDescription = null;
            this.openToolStripButton.AccessibleName = null;
            this.openToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.BackgroundImage = null;
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AccessibleDescription = null;
            this.toolStripLabel1.AccessibleName = null;
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.BackgroundImage = null;
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AccessibleDescription = null;
            this.saveToolStripButton.AccessibleName = null;
            this.saveToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.BackgroundImage = null;
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // ppc
            // 
            this.ppc.AccessibleDescription = null;
            this.ppc.AccessibleName = null;
            resources.ApplyResources(this.ppc, "ppc");
            this.ppc.BackgroundImage = null;
            this.ppc.Font = null;
            this.ppc.Name = "ppc";
            // 
            // bc
            // 
            this.bc.AccessibleDescription = null;
            this.bc.AccessibleName = null;
            resources.ApplyResources(this.bc, "bc");
            this.bc.Font = null;
            this.bc.Name = "bc";
            this.bc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bc.OcxState")));
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = null;
            this.menuStrip1.AccessibleName = null;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackgroundImage = null;
            this.menuStrip1.Font = null;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.previewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.AccessibleDescription = null;
            this.newProjectToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.newProjectToolStripMenuItem, "newProjectToolStripMenuItem");
            this.newProjectToolStripMenuItem.BackgroundImage = null;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AccessibleDescription = null;
            this.openToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.BackgroundImage = null;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.AccessibleDescription = null;
            this.saveProjectAsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveProjectAsToolStripMenuItem, "saveProjectAsToolStripMenuItem");
            this.saveProjectAsToolStripMenuItem.BackgroundImage = null;
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.AccessibleDescription = null;
            this.previewToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.previewToolStripMenuItem, "previewToolStripMenuItem");
            this.previewToolStripMenuItem.BackgroundImage = null;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.AccessibleDescription = null;
            this.printToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.BackgroundImage = null;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleDescription = null;
            this.editToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.BackgroundImage = null;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourceToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.barcodePropertiesToolStripMenuItem,
            this.pageLayoutToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // dataSourceToolStripMenuItem
            // 
            this.dataSourceToolStripMenuItem.AccessibleDescription = null;
            this.dataSourceToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.dataSourceToolStripMenuItem, "dataSourceToolStripMenuItem");
            this.dataSourceToolStripMenuItem.BackgroundImage = null;
            this.dataSourceToolStripMenuItem.Name = "dataSourceToolStripMenuItem";
            this.dataSourceToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.dataSourceToolStripMenuItem.Click += new System.EventHandler(this.dataSourceToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.AccessibleDescription = null;
            this.filterToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.filterToolStripMenuItem, "filterToolStripMenuItem");
            this.filterToolStripMenuItem.BackgroundImage = null;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.AccessibleDescription = null;
            this.dataToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.dataToolStripMenuItem, "dataToolStripMenuItem");
            this.dataToolStripMenuItem.BackgroundImage = null;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // barcodePropertiesToolStripMenuItem
            // 
            this.barcodePropertiesToolStripMenuItem.AccessibleDescription = null;
            this.barcodePropertiesToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.barcodePropertiesToolStripMenuItem, "barcodePropertiesToolStripMenuItem");
            this.barcodePropertiesToolStripMenuItem.BackgroundImage = null;
            this.barcodePropertiesToolStripMenuItem.Name = "barcodePropertiesToolStripMenuItem";
            this.barcodePropertiesToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.barcodePropertiesToolStripMenuItem.Click += new System.EventHandler(this.barcodePropertiesToolStripMenuItem_Click);
            // 
            // pageLayoutToolStripMenuItem
            // 
            this.pageLayoutToolStripMenuItem.AccessibleDescription = null;
            this.pageLayoutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.pageLayoutToolStripMenuItem, "pageLayoutToolStripMenuItem");
            this.pageLayoutToolStripMenuItem.BackgroundImage = null;
            this.pageLayoutToolStripMenuItem.Name = "pageLayoutToolStripMenuItem";
            this.pageLayoutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.pageLayoutToolStripMenuItem.Click += new System.EventHandler(this.pageLayoutToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.AccessibleDescription = null;
            this.pageSetupToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.pageSetupToolStripMenuItem, "pageSetupToolStripMenuItem");
            this.pageSetupToolStripMenuItem.BackgroundImage = null;
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = null;
            this.helpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.BackgroundImage = null;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.EnableMetric = true;
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.Multiselect = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AccessibleDescription = null;
            this.printPreviewDialog1.AccessibleName = null;
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.BackgroundImage = null;
            this.printPreviewDialog1.Font = null;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // MainForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.menuStrip1);
            this.Font = null;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxBARCODEWIZLib.AxBarCodeWiz bc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbProjects;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewControl ppc;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem dataSourceToolStripMenuItem;
    }
}