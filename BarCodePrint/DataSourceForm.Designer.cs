namespace BarCodePrint
{
    partial class DataSourceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbWork = new System.Windows.Forms.RadioButton();
            this.rbDef = new System.Windows.Forms.RadioButton();
            this.rbRep = new System.Windows.Forms.RadioButton();
            this.lbPlant = new System.Windows.Forms.ListBox();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewDataSet = new BarCodePrint.RewDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plantTableAdapter = new BarCodePrint.RewDataSetTableAdapters.PlantTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rbWork
            // 
            resources.ApplyResources(this.rbWork, "rbWork");
            this.rbWork.Name = "rbWork";
            this.rbWork.TabStop = true;
            this.rbWork.UseVisualStyleBackColor = true;
            // 
            // rbDef
            // 
            resources.ApplyResources(this.rbDef, "rbDef");
            this.rbDef.Name = "rbDef";
            this.rbDef.TabStop = true;
            this.rbDef.UseVisualStyleBackColor = true;
            // 
            // rbRep
            // 
            resources.ApplyResources(this.rbRep, "rbRep");
            this.rbRep.Name = "rbRep";
            this.rbRep.TabStop = true;
            this.rbRep.UseVisualStyleBackColor = true;
            // 
            // lbPlant
            // 
            this.lbPlant.DataSource = this.plantBindingSource;
            this.lbPlant.DisplayMember = "PlantName";
            resources.ApplyResources(this.lbPlant, "lbPlant");
            this.lbPlant.FormattingEnabled = true;
            this.lbPlant.Name = "lbPlant";
            this.lbPlant.ValueMember = "PlantId";
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.rewDataSet;
            // 
            // rewDataSet
            // 
            this.rewDataSet.DataSetName = "RewDataSet";
            this.rewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWork);
            this.groupBox1.Controls.Add(this.rbDef);
            this.groupBox1.Controls.Add(this.rbRep);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPlant);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataSourceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSourceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DataSourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbWork;
        private System.Windows.Forms.RadioButton rbDef;
        private System.Windows.Forms.RadioButton rbRep;
        private System.Windows.Forms.ListBox lbPlant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private RewDataSet rewDataSet;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private BarCodePrint.RewDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private System.Windows.Forms.Button btnBack;
    }
}