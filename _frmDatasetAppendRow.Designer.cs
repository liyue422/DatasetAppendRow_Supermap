namespace SuperMap.Desktop.DatasetAppendRow
{
    partial class _frmDatasetAppendRow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDataset = new System.Windows.Forms.ComboBox();
            this.cmbDatasource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFloor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDatasetAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDatasourceAdd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDataset);
            this.groupBox1.Controls.Add(this.cmbDatasource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(25, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目标数据";
            // 
            // cmbDataset
            // 
            this.cmbDataset.FormattingEnabled = true;
            this.cmbDataset.Location = new System.Drawing.Point(440, 48);
            this.cmbDataset.Name = "cmbDataset";
            this.cmbDataset.Size = new System.Drawing.Size(201, 28);
            this.cmbDataset.TabIndex = 4;
            this.cmbDataset.Click += new System.EventHandler(this.cmbDataset_Click);
            // 
            // cmbDatasource
            // 
            this.cmbDatasource.FormattingEnabled = true;
            this.cmbDatasource.Location = new System.Drawing.Point(108, 46);
            this.cmbDatasource.Name = "cmbDatasource";
            this.cmbDatasource.Size = new System.Drawing.Size(201, 28);
            this.cmbDatasource.TabIndex = 3;
            this.cmbDatasource.Click += new System.EventHandler(this.cmbDatasource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(348, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据集：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据源：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFloor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbDatasetAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbDatasourceAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(25, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "源数据";
            // 
            // textFloor
            // 
            this.textFloor.Location = new System.Drawing.Point(462, 104);
            this.textFloor.Name = "textFloor";
            this.textFloor.Size = new System.Drawing.Size(179, 30);
            this.textFloor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(348, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "目标楼层：";
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(125, 104);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(186, 28);
            this.cmbField.TabIndex = 8;
            this.cmbField.Click += new System.EventHandler(this.cmbField_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "目标字段：";
            // 
            // cmbDatasetAdd
            // 
            this.cmbDatasetAdd.FormattingEnabled = true;
            this.cmbDatasetAdd.Location = new System.Drawing.Point(440, 50);
            this.cmbDatasetAdd.Name = "cmbDatasetAdd";
            this.cmbDatasetAdd.Size = new System.Drawing.Size(201, 28);
            this.cmbDatasetAdd.TabIndex = 6;
            this.cmbDatasetAdd.Click += new System.EventHandler(this.cmbDatasetAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(348, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "数据集：";
            // 
            // cmbDatasourceAdd
            // 
            this.cmbDatasourceAdd.FormattingEnabled = true;
            this.cmbDatasourceAdd.Location = new System.Drawing.Point(110, 50);
            this.cmbDatasourceAdd.Name = "cmbDatasourceAdd";
            this.cmbDatasourceAdd.Size = new System.Drawing.Size(201, 28);
            this.cmbDatasourceAdd.TabIndex = 4;
            this.cmbDatasourceAdd.Click += new System.EventHandler(this.cmbDatasourceAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据源：";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(441, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(571, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // _frmDatasetAppendRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_frmDatasetAppendRow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "追加各层数据";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataset;
        private System.Windows.Forms.ComboBox cmbDatasource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDatasetAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDatasourceAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFloor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;

        //private System.Windows.Forms.Label lblY;
        //private System.Windows.Forms.TextBox txtY;
        //private System.Windows.Forms.Timer timer1;
    }
}