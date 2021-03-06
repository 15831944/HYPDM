﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS.Modularization;
using HYPDM.Entities;
using EAS.Services;
using EAS.Data.ORM;
using HYPDM.BLL;
using EAS.Data;
using EAS.Explorer;
using HYPDM.BaseControl;
namespace HYPDM.WinUI.SysConfig
{
    public partial class FrmAddNewProperties : Form
    {
        private PDM_Params m_PDM_Params=new PDM_Params();
        public PDM_Params M_PDM_Params {
            get { return this.m_PDM_Params; }
        }

        private bool isEditModel = false;

        public FrmAddNewProperties(String p_TableName)
        {
            InitializeComponent();
            this.CenterToParent();
            m_PDM_Params.MASTER_TABLE_NAME = p_TableName.Trim().ToUpper();
        }

        public FrmAddNewProperties(PDM_Params p_PDM_Params)
        {
            InitializeComponent();
            this.CenterToParent();
            isEditModel = true;
            InitControl(p_PDM_Params);
        }
        private void InitControl(PDM_Params p_PDM_Params)
        {
            this.txtParamsColName.Text = p_PDM_Params.PARAMS_NAME;
            if (p_PDM_Params.PARAMS_DATA_TYPE.Equals(DataType.DataColumnType.Text.ToString())) { this.btnTxtValue.Checked = true; this.btnNumberValue.Enabled = false; this.btnDateTime.Enabled = false; }
            if (p_PDM_Params.PARAMS_DATA_TYPE.Equals(DataType.DataColumnType.Number.ToString())) { this.btnNumberValue.Checked = true; this.btnDateTime.Enabled = false; }
            if (p_PDM_Params.PARAMS_DATA_TYPE.Equals(DataType.DataColumnType.DateTime.ToString())) { this.btnDateTime.Checked = true; this.btnNumberValue.Enabled = false; }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isEditModel)
            {
                UpdateValue();
            }
            else {
                SaveValue();
            }
            
        }
        private void  UpdateValue() {
            m_PDM_Params.PARAMS_NAME = this.txtParamsColName.Text;

            if (this.btnTxtValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Text.ToString();
            if (this.btnNumberValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Number.ToString();
            if (this.btnDateTime.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.DateTime.ToString();

            this.DialogResult = DialogResult.OK;
        }
        private void  SaveValue(){
            m_PDM_Params.PARAMS_NAME = this.txtParamsColName.Text;

            if (this.btnTxtValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Text.ToString();
            if (this.btnNumberValue.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.Number.ToString();
            if (this.btnDateTime.Checked) m_PDM_Params.PARAMS_DATA_TYPE = DataType.DataColumnType.DateTime.ToString();
            // 
            int maxcolumns = GetMaxCountForProperties(m_PDM_Params.MASTER_TABLE_NAME);
            if (maxcolumns >= 30)
            {
                MessageBox.Show("最多只能添加30个属性");
                this.btnTxtValue.Select();
                return;
            }
            m_PDM_Params.TARGET_COLNAME = "C" + (maxcolumns + 1);
            try
            {
                m_PDM_Params.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败:" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnTxtValue.Select();
                return;
            }
        }
        private int GetMaxCountForProperties(string tableName)
        {
            DataTable dt = WinUI.AddObjectParams.ObjectParams.getDataTableBySql(
                           "MAX(convert(int,substring(TARGET_COLNAME,2,len(TARGET_COLNAME)-1)))  as ROWCNT  ",
                           "WHERE   MASTER_TABLE_NAME ='ALL' OR  MASTER_TABLE_NAME ='" + tableName + "' ",
                           "PDM_Params");
            if (dt == null || dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(dt.Rows[0]["ROWCNT"].ToString());
            }
        }

    }
}
