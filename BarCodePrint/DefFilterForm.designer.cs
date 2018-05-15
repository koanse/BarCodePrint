namespace BarCodePrint
{
    partial class DefFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefFilterForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.defTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defTypeNameEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewDataSet = new BarCodePrint.RewDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.defTableAdapter = new BarCodePrint.RewDataSetTableAdapters.DefTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AccessibleDescription = null;
            this.dgv.AccessibleName = null;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundImage = null;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visibleDataGridViewCheckBoxColumn,
            this.defTypeIdDataGridViewTextBoxColumn,
            this.defTypeNameDataGridViewTextBoxColumn,
            this.defTypeNameEngDataGridViewTextBoxColumn,
            this.defTypeCodeDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.defBindingSource;
            this.dgv.Font = null;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
            resources.ApplyResources(this.visibleDataGridViewCheckBoxColumn, "visibleDataGridViewCheckBoxColumn");
            this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            // 
            // defTypeIdDataGridViewTextBoxColumn
            // 
            this.defTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DefTypeId";
            resources.ApplyResources(this.defTypeIdDataGridViewTextBoxColumn, "defTypeIdDataGridViewTextBoxColumn");
            this.defTypeIdDataGridViewTextBoxColumn.Name = "defTypeIdDataGridViewTextBoxColumn";
            this.defTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defTypeNameDataGridViewTextBoxColumn
            // 
            this.defTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DefTypeName";
            resources.ApplyResources(this.defTypeNameDataGridViewTextBoxColumn, "defTypeNameDataGridViewTextBoxColumn");
            this.defTypeNameDataGridViewTextBoxColumn.Name = "defTypeNameDataGridViewTextBoxColumn";
            this.defTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defTypeNameEngDataGridViewTextBoxColumn
            // 
            this.defTypeNameEngDataGridViewTextBoxColumn.DataPropertyName = "DefTypeNameEng";
            resources.ApplyResources(this.defTypeNameEngDataGridViewTextBoxColumn, "defTypeNameEngDataGridViewTextBoxColumn");
            this.defTypeNameEngDataGridViewTextBoxColumn.Name = "defTypeNameEngDataGridViewTextBoxColumn";
            this.defTypeNameEngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defTypeCodeDataGridViewTextBoxColumn
            // 
            this.defTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "DefTypeCode";
            resources.ApplyResources(this.defTypeCodeDataGridViewTextBoxColumn, "defTypeCodeDataGridViewTextBoxColumn");
            this.defTypeCodeDataGridViewTextBoxColumn.Name = "defTypeCodeDataGridViewTextBoxColumn";
            this.defTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defBindingSource
            // 
            this.defBindingSource.DataMember = "DefType";
            this.defBindingSource.DataSource = this.rewDataSet;
            // 
            // rewDataSet
            // 
            this.rewDataSet.DataSetName = "RewDataSet";
            this.rewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AccessibleDescription = null;
            this.btnSelectAll.AccessibleName = null;
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.BackgroundImage = null;
            this.btnSelectAll.Font = null;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = null;
            this.btnClear.AccessibleName = null;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackgroundImage = null;
            this.btnClear.Font = null;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = null;
            this.btnOk.AccessibleName = null;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackgroundImage = null;
            this.btnOk.Font = null;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.Font = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleDescription = null;
            this.btnBack.AccessibleName = null;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackgroundImage = null;
            this.btnBack.Font = null;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // defTableAdapter
            // 
            this.defTableAdapter.ClearBeforeFill = true;
            // 
            // DefFilterForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = null;
            this.Icon = null;
            this.Name = "DefFilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DefFilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource defBindingSource;
        private RewDataSet rewDataSet;
        private BarCodePrint.RewDataSetTableAdapters.DefTypeTableAdapter defTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defTypeNameEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defTypeCodeDataGridViewTextBoxColumn;




    }
}

