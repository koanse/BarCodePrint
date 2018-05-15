namespace BarCodePrint
{
    partial class BarcodeStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeStateForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.bc = new AxBARCODEWIZLib.AxBarCodeWiz();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbQz = new BarCodePrint.AdvComboBox();
            this.cbBorder = new BarCodePrint.AdvComboBox();
            this.cbCodePos = new BarCodePrint.AdvComboBox();
            this.cbOrient = new BarCodePrint.AdvComboBox();
            this.cbOptCheck = new BarCodePrint.AdvComboBox();
            this.cbSymb = new BarCodePrint.AdvComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNbw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbBb = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lForeColor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lBackColor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBottomTextFont = new System.Windows.Forms.Button();
            this.btnTopTextFont = new System.Windows.Forms.Button();
            this.btnBarcodeTextFont = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bc
            // 
            resources.ApplyResources(this.bc, "bc");
            this.bc.Name = "bc";
            this.bc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bc.OcxState")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bc);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbQz);
            this.groupBox2.Controls.Add(this.cbBorder);
            this.groupBox2.Controls.Add(this.cbCodePos);
            this.groupBox2.Controls.Add(this.cbOrient);
            this.groupBox2.Controls.Add(this.cbOptCheck);
            this.groupBox2.Controls.Add(this.cbSymb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbNbw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbQz
            // 
            this.cbQz.FormattingEnabled = true;
            resources.ApplyResources(this.cbQz, "cbQz");
            this.cbQz.Name = "cbQz";
            this.cbQz.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // cbBorder
            // 
            this.cbBorder.FormattingEnabled = true;
            resources.ApplyResources(this.cbBorder, "cbBorder");
            this.cbBorder.Name = "cbBorder";
            this.cbBorder.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // cbCodePos
            // 
            this.cbCodePos.FormattingEnabled = true;
            resources.ApplyResources(this.cbCodePos, "cbCodePos");
            this.cbCodePos.Name = "cbCodePos";
            this.cbCodePos.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // cbOrient
            // 
            this.cbOrient.FormattingEnabled = true;
            resources.ApplyResources(this.cbOrient, "cbOrient");
            this.cbOrient.Name = "cbOrient";
            this.cbOrient.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // cbOptCheck
            // 
            this.cbOptCheck.FormattingEnabled = true;
            resources.ApplyResources(this.cbOptCheck, "cbOptCheck");
            this.cbOptCheck.Name = "cbOptCheck";
            this.cbOptCheck.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // cbSymb
            // 
            this.cbSymb.FormattingEnabled = true;
            resources.ApplyResources(this.cbSymb, "cbSymb");
            this.cbSymb.Name = "cbSymb";
            this.cbSymb.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbNbw
            // 
            resources.ApplyResources(this.tbNbw, "tbNbw");
            this.tbNbw.Name = "tbNbw";
            this.tbNbw.Leave += new System.EventHandler(this.tb_Leave);
            this.tbNbw.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbHeight
            // 
            resources.ApplyResources(this.tbHeight, "tbHeight");
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Leave += new System.EventHandler(this.tb_Leave);
            this.tbHeight.TextChanged += new System.EventHandler(this.cb_tb_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chbBb
            // 
            resources.ApplyResources(this.chbBb, "chbBb");
            this.chbBb.Name = "chbBb";
            this.chbBb.UseVisualStyleBackColor = true;
            this.chbBb.CheckedChanged += new System.EventHandler(this.cb_tb_TextChanged);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lForeColor);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lBackColor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnForeColor);
            this.groupBox4.Controls.Add(this.chbBb);
            this.groupBox4.Controls.Add(this.btnBackColor);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lForeColor
            // 
            this.lForeColor.BackColor = System.Drawing.Color.Black;
            this.lForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lForeColor, "lForeColor");
            this.lForeColor.Name = "lForeColor";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // lBackColor
            // 
            this.lBackColor.BackColor = System.Drawing.Color.White;
            this.lBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lBackColor, "lBackColor");
            this.lBackColor.Name = "lBackColor";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnForeColor
            // 
            resources.ApplyResources(this.btnForeColor, "btnForeColor");
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBackColor
            // 
            resources.ApplyResources(this.btnBackColor, "btnBackColor");
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBottomTextFont);
            this.groupBox3.Controls.Add(this.btnTopTextFont);
            this.groupBox3.Controls.Add(this.btnBarcodeTextFont);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnBottomTextFont
            // 
            resources.ApplyResources(this.btnBottomTextFont, "btnBottomTextFont");
            this.btnBottomTextFont.Name = "btnBottomTextFont";
            this.btnBottomTextFont.UseVisualStyleBackColor = true;
            this.btnBottomTextFont.Click += new System.EventHandler(this.btnBottomTextFont_Click);
            // 
            // btnTopTextFont
            // 
            resources.ApplyResources(this.btnTopTextFont, "btnTopTextFont");
            this.btnTopTextFont.Name = "btnTopTextFont";
            this.btnTopTextFont.UseVisualStyleBackColor = true;
            this.btnTopTextFont.Click += new System.EventHandler(this.btnTopTextFont_Click);
            // 
            // btnBarcodeTextFont
            // 
            resources.ApplyResources(this.btnBarcodeTextFont, "btnBarcodeTextFont");
            this.btnBarcodeTextFont.Name = "btnBarcodeTextFont";
            this.btnBarcodeTextFont.UseVisualStyleBackColor = true;
            this.btnBarcodeTextFont.Click += new System.EventHandler(this.btnBarcodeTextFont_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BarcodeStateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeStateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.bc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private AxBARCODEWIZLib.AxBarCodeWiz bc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNbw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.CheckBox chbBb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lBackColor;
        private System.Windows.Forms.Label lForeColor;
        private System.Windows.Forms.Label label15;
        private AdvComboBox cbSymb;
        private AdvComboBox cbOrient;
        private AdvComboBox cbOptCheck;
        private AdvComboBox cbCodePos;
        private AdvComboBox cbBorder;
        private AdvComboBox cbQz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBarcodeTextFont;
        private System.Windows.Forms.Button btnTopTextFont;
        private System.Windows.Forms.Button btnBottomTextFont;
        private System.Windows.Forms.Button btnBack;
    }
}