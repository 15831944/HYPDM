﻿namespace HYPDM.WinUI.SysConfig
{
    partial class UcSysConfig
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl = new System.Windows.Forms.Panel();
            this.gpObjectProperties = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVObjectProperties = new HYPDM.BaseControl.DataGridViewExt();
            this.PARAMS_NAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASTER_TABLE_NAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAMS_DATA_TYPE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSCombPObject = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAddObjectPro = new System.Windows.Forms.ToolStripButton();
            this.gpCommonProperties = new System.Windows.Forms.GroupBox();
            this.dGVCommonProperties = new HYPDM.BaseControl.DataGridViewExt();
            this.PARAMS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASTER_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAMS_DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAddCommonPro = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.BtnEditObjectPro = new System.Windows.Forms.ToolStripButton();
            this.BtnEditCommonPro = new System.Windows.Forms.ToolStripButton();
            this.pnl.SuspendLayout();
            this.gpObjectProperties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVObjectProperties)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.gpCommonProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCommonProperties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.gpObjectProperties);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(764, 526);
            this.pnl.TabIndex = 0;
            // 
            // gpObjectProperties
            // 
            this.gpObjectProperties.Controls.Add(this.groupBox1);
            this.gpObjectProperties.Controls.Add(this.gpCommonProperties);
            this.gpObjectProperties.Controls.Add(this.panel1);
            this.gpObjectProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpObjectProperties.Location = new System.Drawing.Point(0, 0);
            this.gpObjectProperties.Name = "gpObjectProperties";
            this.gpObjectProperties.Size = new System.Drawing.Size(456, 526);
            this.gpObjectProperties.TabIndex = 0;
            this.gpObjectProperties.TabStop = false;
            this.gpObjectProperties.Text = "对象属性字段设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVObjectProperties);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指定对象属性";
            // 
            // dGVObjectProperties
            // 
            this.dGVObjectProperties.AllowUserToAddRows = false;
            this.dGVObjectProperties.BackgroundColor = System.Drawing.Color.White;
            this.dGVObjectProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVObjectProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVObjectProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMS_NAME1,
            this.MASTER_TABLE_NAME1,
            this.PARAMS_DATA_TYPE1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVObjectProperties.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVObjectProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVObjectProperties.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVObjectProperties.Location = new System.Drawing.Point(3, 42);
            this.dGVObjectProperties.Name = "dGVObjectProperties";
            this.dGVObjectProperties.ReadOnly = true;
            this.dGVObjectProperties.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVObjectProperties.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVObjectProperties.RowTemplate.Height = 23;
            this.dGVObjectProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVObjectProperties.Size = new System.Drawing.Size(444, 181);
            this.dGVObjectProperties.TabIndex = 2;
            // 
            // PARAMS_NAME1
            // 
            this.PARAMS_NAME1.DataPropertyName = "PARAMS_NAME";
            this.PARAMS_NAME1.HeaderText = "属性名称";
            this.PARAMS_NAME1.Name = "PARAMS_NAME1";
            this.PARAMS_NAME1.ReadOnly = true;
            this.PARAMS_NAME1.Width = 200;
            // 
            // MASTER_TABLE_NAME1
            // 
            this.MASTER_TABLE_NAME1.DataPropertyName = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME1.HeaderText = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME1.Name = "MASTER_TABLE_NAME1";
            this.MASTER_TABLE_NAME1.ReadOnly = true;
            this.MASTER_TABLE_NAME1.Visible = false;
            // 
            // PARAMS_DATA_TYPE1
            // 
            this.PARAMS_DATA_TYPE1.DataPropertyName = "PARAMS_DATA_TYPE";
            this.PARAMS_DATA_TYPE1.HeaderText = "属性类型";
            this.PARAMS_DATA_TYPE1.Name = "PARAMS_DATA_TYPE1";
            this.PARAMS_DATA_TYPE1.ReadOnly = true;
            this.PARAMS_DATA_TYPE1.Width = 200;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCombPObject,
            this.toolStripSeparator1,
            this.BtnAddObjectPro,
            this.BtnEditObjectPro});
            this.toolStrip2.Location = new System.Drawing.Point(3, 17);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(444, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSCombPObject
            // 
            this.tSCombPObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tSCombPObject.Name = "tSCombPObject";
            this.tSCombPObject.Size = new System.Drawing.Size(121, 25);
            this.tSCombPObject.SelectedIndexChanged += new System.EventHandler(this.tSCombPObject_SelectedIndexChanged);
            this.tSCombPObject.TextChanged += new System.EventHandler(this.tSCombPObject_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAddObjectPro
            // 
            this.BtnAddObjectPro.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.BtnAddObjectPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddObjectPro.Name = "BtnAddObjectPro";
            this.BtnAddObjectPro.Size = new System.Drawing.Size(76, 22);
            this.BtnAddObjectPro.Text = "属性添加";
            this.BtnAddObjectPro.Click += new System.EventHandler(this.BtnAddObjectPro_Click);
            // 
            // gpCommonProperties
            // 
            this.gpCommonProperties.Controls.Add(this.dGVCommonProperties);
            this.gpCommonProperties.Controls.Add(this.toolStrip1);
            this.gpCommonProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpCommonProperties.Location = new System.Drawing.Point(3, 51);
            this.gpCommonProperties.Name = "gpCommonProperties";
            this.gpCommonProperties.Size = new System.Drawing.Size(450, 246);
            this.gpCommonProperties.TabIndex = 1;
            this.gpCommonProperties.TabStop = false;
            this.gpCommonProperties.Text = "公共属性设定";
            // 
            // dGVCommonProperties
            // 
            this.dGVCommonProperties.AllowUserToAddRows = false;
            this.dGVCommonProperties.BackgroundColor = System.Drawing.Color.White;
            this.dGVCommonProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVCommonProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCommonProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMS_NAME,
            this.MASTER_TABLE_NAME,
            this.PARAMS_DATA_TYPE});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVCommonProperties.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVCommonProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCommonProperties.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVCommonProperties.Location = new System.Drawing.Point(3, 42);
            this.dGVCommonProperties.Name = "dGVCommonProperties";
            this.dGVCommonProperties.ReadOnly = true;
            this.dGVCommonProperties.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVCommonProperties.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVCommonProperties.RowTemplate.Height = 23;
            this.dGVCommonProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVCommonProperties.Size = new System.Drawing.Size(444, 201);
            this.dGVCommonProperties.TabIndex = 1;
            // 
            // PARAMS_NAME
            // 
            this.PARAMS_NAME.DataPropertyName = "PARAMS_NAME";
            this.PARAMS_NAME.HeaderText = "属性名称";
            this.PARAMS_NAME.Name = "PARAMS_NAME";
            this.PARAMS_NAME.ReadOnly = true;
            this.PARAMS_NAME.Width = 200;
            // 
            // MASTER_TABLE_NAME
            // 
            this.MASTER_TABLE_NAME.DataPropertyName = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.HeaderText = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.Name = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.ReadOnly = true;
            this.MASTER_TABLE_NAME.Visible = false;
            // 
            // PARAMS_DATA_TYPE
            // 
            this.PARAMS_DATA_TYPE.DataPropertyName = "PARAMS_DATA_TYPE";
            this.PARAMS_DATA_TYPE.HeaderText = "属性类型";
            this.PARAMS_DATA_TYPE.Name = "PARAMS_DATA_TYPE";
            this.PARAMS_DATA_TYPE.ReadOnly = true;
            this.PARAMS_DATA_TYPE.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.BtnAddCommonPro,
            this.BtnEditCommonPro});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAddCommonPro
            // 
            this.BtnAddCommonPro.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.BtnAddCommonPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddCommonPro.Name = "BtnAddCommonPro";
            this.BtnAddCommonPro.Size = new System.Drawing.Size(76, 22);
            this.BtnAddCommonPro.Text = "属性添加";
            this.BtnAddCommonPro.Click += new System.EventHandler(this.BtnAddCommonPro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 34);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(450, 34);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // BtnEditObjectPro
            // 
            this.BtnEditObjectPro.Image = global::HYPDM.WinUI.Properties.Resources.pagination_load;
            this.BtnEditObjectPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditObjectPro.Name = "BtnEditObjectPro";
            this.BtnEditObjectPro.Size = new System.Drawing.Size(76, 22);
            this.BtnEditObjectPro.Text = "属性修改";
            this.BtnEditObjectPro.Click += new System.EventHandler(this.BtnEditObjectPro_Click);
            // 
            // BtnEditCommonPro
            // 
            this.BtnEditCommonPro.Image = global::HYPDM.WinUI.Properties.Resources.pagination_load;
            this.BtnEditCommonPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditCommonPro.Name = "BtnEditCommonPro";
            this.BtnEditCommonPro.Size = new System.Drawing.Size(76, 22);
            this.BtnEditCommonPro.Text = "属性修改";
            this.BtnEditCommonPro.Click += new System.EventHandler(this.BtnEditCommonPro_Click);
            // 
            // UcSysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Name = "UcSysConfig";
            this.Size = new System.Drawing.Size(764, 526);
            this.pnl.ResumeLayout(false);
            this.gpObjectProperties.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVObjectProperties)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gpCommonProperties.ResumeLayout(false);
            this.gpCommonProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCommonProperties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox gpObjectProperties;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpCommonProperties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private BaseControl.DataGridViewExt dGVObjectProperties;
        private BaseControl.DataGridViewExt dGVCommonProperties;
        private System.Windows.Forms.ToolStripComboBox tSCombPObject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnAddObjectPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnAddCommonPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASTER_TABLE_NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_DATA_TYPE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASTER_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_DATA_TYPE;
        private System.Windows.Forms.ToolStripButton BtnEditObjectPro;
        private System.Windows.Forms.ToolStripButton BtnEditCommonPro;
    }
}
