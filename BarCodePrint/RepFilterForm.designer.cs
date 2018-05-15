namespace BarCodePrint
{
    partial class RepFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepFilterForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.repBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewDataSet = new BarCodePrint.RewDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.repTableAdapter = new BarCodePrint.RewDataSetTableAdapters.RepTypeTableAdapter();
            this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repTypeNameEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBindingSource)).BeginInit();
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
            this.repTypeIdDataGridViewTextBoxColumn,
            this.repTypeNameDataGridViewTextBoxColumn,
            this.repTypeNameEngDataGridViewTextBoxColumn,
            this.repTypeCodeDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.repBindingSource;
            this.dgv.Font = null;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // repBindingSource
            // 
            this.repBindingSource.DataMember = "RepType";
            this.repBindingSource.DataSource = this.rewDataSet;
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
            // repTableAdapter
            // 
            this.repTableAdapter.ClearBeforeFill = true;
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
            resources.ApplyResources(this.visibleDataGridViewCheckBoxColumn, "visibleDataGridViewCheckBoxColumn");
            this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            // 
            // repTypeIdDataGridViewTextBoxColumn
            // 
            this.repTypeIdDataGridViewTextBoxColumn.DataPropertyName = "RepTypeId";
            resources.ApplyResources(this.repTypeIdDataGridViewTextBoxColumn, "repTypeIdDataGridViewTextBoxColumn");
            this.repTypeIdDataGridViewTextBoxColumn.Name = "repTypeIdDataGridViewTextBoxColumn";
            this.repTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repTypeNameDataGridViewTextBoxColumn
            // 
            this.repTypeNameDataGridViewTextBoxColumn.DataPropertyName = "RepTypeName";
            resources.ApplyResources(this.repTypeNameDataGridViewTextBoxColumn, "repTypeNameDataGridViewTextBoxColumn");
            this.repTypeNameDataGridViewTextBoxColumn.Name = "repTypeNameDataGridViewTextBoxColumn";
            this.repTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repTypeNameEngDataGridViewTextBoxColumn
            // 
            this.repTypeNameEngDataGridViewTextBoxColumn.DataPropertyName = "RepTypeNameEng";
            resources.ApplyResources(this.repTypeNameEngDataGridViewTextBoxColumn, "repTypeNameEngDataGridViewTextBoxColumn");
            this.repTypeNameEngDataGridViewTextBoxColumn.Name = "repTypeNameEngDataGridViewTextBoxColumn";
            this.repTypeNameEngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repTypeCodeDataGridViewTextBoxColumn
            // 
            this.repTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "RepTypeCode";
            resources.ApplyResources(this.repTypeCodeDataGridViewTextBoxColumn, "repTypeCodeDataGridViewTextBoxColumn");
            this.repTypeCodeDataGridViewTextBoxColumn.Name = "repTypeCodeDataGridViewTextBoxColumn";
            this.repTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RepFilterForm
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
            this.Name = "RepFilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.RepFilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBindingSource)).EndInit();
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
        private RewDataSet rewDataSet;
        private System.Windows.Forms.BindingSource repBindingSource;
        private BarCodePrint.RewDataSetTableAdapters.RepTypeTableAdapter repTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repTypeNameEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repTypeCodeDataGridViewTextBoxColumn;




    }
}

