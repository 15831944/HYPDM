﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using EAS.Explorer;
using HYPDM.Entities;
using HYPDM.BLL;
namespace HYPDM.WinUI.ProductsAndParts.Material
{
    public partial class MaterialConfForm : Form
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        public MaterialConfForm()
        {
            InitializeComponent();
        }

        public MaterialConfForm(int p_type)
        {
            InitializeComponent();

            this.m_type = p_type;
            this.opStatus = false;
            service_Init();
            toolBaseClear_Click(null,null);
        }

        public MaterialConfForm(string t_productId, int p_type)
        {
            InitializeComponent();

            this.m_type = p_type;
            this.opStatus = false;
            service_Init();
            this.m_product = m_MaterailService.GetById(t_productId);
            allinit();
        }

        #region 属性基本数据
        
        private int m_type;     //类型（半成品，成品）
        private bool opStatus;  //操作状态（产品清空状态，配置状态）

        private IMaterailService m_MaterailService;      //材料服务类

        HYPDM.Entities.PDM_MATERAIL m_product;       //操作的产品
        public HYPDM.Entities.PDM_MATERAIL Product
        {
            get { return this.m_product; }
            set
            {
                this.m_product = value;
            }
        }

        #endregion

        #region 公共操作

        /************************************************************************
         ************************         公共操作        ***********************
         ************************************************************************/

        /// <summary>
        /// 初始化界面控件数据
        /// </summary>
        private void allinit()
        {
            baseInfo_Init();
        }

        /// <summary>
        /// //初始化服务类
        /// </summary>
        private void service_Init()
        {
            m_MaterailService = EAS.Services.ServiceContainer.GetService<IMaterailService>();
        }

        #endregion

        #region 基本操作

        /************************************************************************
         *******************     产品基本信息操作     *********************
         ************************************************************************/

        /// <summary>
        /// 基本信息--显示初始化
        /// </summary>
        private void baseInfo_Init()
        {
            this.tb_productNo.Text = this.m_product.MATERIALNO;
            this.tb_modelType.Text = this.m_product.MODELTYPE;
            this.tb_productType.Text = this.m_product.MATERIALTYPE;
            this.tb_rawMaterail.Text = this.m_product.RAWMATERIAL;
            this.tb_materailSrc.Text = this.m_product.MATERIALSRC;
            this.tb_version.Text = this.m_product.VERSION;
            //this.tb_status.Text = this.m_product.st;
            this.tb_creater.Text = this.m_product.CREATER;
            this.tb_modifier.Text = this.m_product.MODIFIER;
            this.tb_createTime.Text = this.m_product.CTREATETIME;
            this.tb_modifyTime.Text = this.m_product.MODIFYTIME;
            this.tb_memoZh.Text = this.m_product.MEMO_ZH;
            this.tb_memoEn.Text = this.m_product.MEMO_EN;
            this.rtbMemo.Text = this.m_product.MEMO;
        }

        /// <summary>
        /// 基本信息--修改按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseEdit_Click(object sender, EventArgs e)
        {
            //
            if (this.m_product == null) {
                MessageBox.Show("材料不存在,无法修改！"); return;
            }

            //判断是否需要修改
            if (MessageBox.Show("您确认要修改此材料基本信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            //1.更新数据库产品基本信息记录
            PDM_MATERAIL t_product = new PDM_MATERAIL();
            t_product.MATERIALID = this.m_product.MATERIALID;
            t_product.MATERIALNO = this.tb_productNo.Text;
            t_product.MODELTYPE = this.tb_modelType.Text;
            t_product.MATERIALTYPE = this.tb_productType.Text;
            t_product.RAWMATERIAL = this.tb_rawMaterail.Text;
            t_product.MATERIALSRC = this.tb_materailSrc.Text;
            t_product.VERSION = this.tb_version.Text;
            t_product.MEMO_ZH = this.tb_memoZh.Text;
            t_product.MEMO_EN = this.tb_memoEn.Text;
            t_product.MEMO = this.rtbMemo.Text;
            t_product.MODIFYTIME = DateTime.Now.ToString();
            t_product.MODIFIER = LoginInfo.LoginID;// LoginInfo.LoginID;//CommonVar.userName;
            m_MaterailService.UpdateByID(t_product);


            //2.基本信息改变后更新基本信息显示
            this.tb_modifyTime.Text = t_product.MODIFYTIME;
            this.tb_modifier.Text = t_product.MODIFIER;

            //3.更新（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面列表显示,更新基本属性信息
            this.m_product = m_MaterailService.GetById(t_product.MATERIALID);
            allinit();
        }

        /// <summary>
        /// 基本信息--新建按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseReg_Click(object sender, EventArgs e)
        {
           
            //1.判断产品编号是否为空
            if (string.IsNullOrEmpty(this.tb_productNo.Text.Trim()))
            {
                MessageBox.Show("编号不能为空"); return;
            }

            DataTable dt = m_MaterailService.GetListByNoDetail(this.tb_productNo.Text.Trim());

            //1.判断产品是否存在，如果存在是否生产新版本
            if (dt.Rows.Count>0)
            {
                if (MessageBox.Show("该编号材料已存在，是否生成新版本?\n如果不是请更改产品编号!", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            //3.保存新的产品记录
            HYPDM.Entities.PDM_MATERAIL temp_product = new HYPDM.Entities.PDM_MATERAIL();

            temp_product.MATERIALID = Guid.NewGuid().ToString();
            temp_product.MATERIALNO = this.tb_productNo.Text;
            temp_product.MODELTYPE = this.tb_modelType.Text;
            temp_product.MATERIALTYPE = this.tb_productType.Text;
            temp_product.RAWMATERIAL = this.tb_rawMaterail.Text;
            temp_product.MATERIALSRC = this.tb_materailSrc.Text;
            temp_product.VERSION = "V" + DateTime.Now.ToString("yyyyMMddHHmmss");
            temp_product.CREATER = LoginInfo.LoginID; // CommonVar.userName;
            //temp_product.MODIFIER = "";
            temp_product.CTREATETIME = DateTime.Now.ToString();
            //temp_product.MODIFYTIME ;
            temp_product.MEMO_ZH = this.tb_memoZh.Text;
            temp_product.MEMO_EN = this.tb_memoEn.Text;
            temp_product.MEMO = this.rtbMemo.Text;
            temp_product.Save();
            MessageBox.Show("保存成功");
            

            //4. 判断显示状态
            if (this.opStatus)
            {
                //a.显示（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面

                this.tabControl.TabPages.Add(tab_Doc);
                this.tabControl.TabPages.Add(tab_Drawing);

                //b.改变显示属性（产品清空状态 ，产品配置状态）
                this.opStatus = false;
            }

            //5.更新（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面列表显示,更新基本属性信息
            this.m_product = temp_product;
            allinit();
        }

        /// <summary>
        /// 基本信息--清空按钮的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseClear_Click(object sender, EventArgs e)
        {
            this.m_product = null;

            //1.清空基本信息显示
            this.tb_productNo.Text = "";
            this.tb_modelType.Text = "";
            this.tb_productType.Text = "";
            this.tb_rawMaterail.Text = "";
            this.tb_materailSrc.Text = "";
            this.tb_version.Text = "";      
            this.tb_creater.Text = "";
            this.tb_modifier.Text = "";
            this.tb_createTime.Text = "";
            this.tb_modifyTime.Text = "";
            this.tb_memoZh.Text = "";
            this.tb_memoEn.Text = "";
            this.rtbMemo.Text = "";

            //2.移除（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab 页面
            this.tabControl.TabPages.Remove(tab_Doc);
            this.tabControl.TabPages.Remove(tab_Drawing);

            //3.改变显示属性（产品清空状态 ，产品配置状态）
            this.opStatus = true;
        }

        #endregion


    }
}