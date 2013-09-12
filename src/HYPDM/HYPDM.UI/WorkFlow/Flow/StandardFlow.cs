﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Modularization;
using EAS.Data.Linq;
using EAS.Data.ORM;
namespace HYPDM.WinUI.WorkFlow.Flow
{
    public partial class StandardFlow : Form
    {

        /// <summary>
        /// 对象主键
        /// </summary>
        private string objectKey = "";
        /// <summary>
        /// 关联类型
        /// </summary>
        private DataType.RelationObjectType relationObjectType;

        ///// <summary>
        ///// 当前存储的WF_APP
        ///// </summary>
        //private WF_APP wfApp;

        //public WF_APP WfApp
        //{
        //    get { return wfApp; }
        //    set { wfApp = value; }
        //}
        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        private string wfAppID = "";

        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        public string WfAppID
        {
            get { return wfAppID; }
            set { wfAppID = value; }
        }
        /// <summary>
        /// 工作流模板主键
        /// </summary>
        private string wfTemplatesID = "";
        /// <summary>
        /// 工作流模板主键
        /// </summary>
        public string WfTemplatesID
        {
            get { return wfTemplatesID; }
            set { wfTemplatesID = value; }
        }

        /// <summary>
        /// 对象主键
        /// </summary>
        public string ObjectKey
        {
            get { return objectKey; }
            set { objectKey = value; }
        }
        /// <summary>
        /// 关联类型
        /// </summary>
        public DataType.RelationObjectType RelationObjectType
        {
            get { return relationObjectType; }
            set { relationObjectType = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        public StandardFlow()
        {

            InitializeComponent();
            this.CenterToParent();
        }

        /// <summary>
        /// 传参构造方法
        /// </summary>
        /// <param name="objectKey">对象主键</param>
        /// <param name="relationObjectType">关联类型</param>
        /// <param name="wfTemplates">工作流模板ID</param>
        public StandardFlow(string objectKey, DataType.RelationObjectType relationObjectType, string wfTemplates)
        {
            InitializeComponent();
            this.ObjectKey = objectKey;
            this.RelationObjectType = relationObjectType;
            this.WfTemplatesID = wfTemplates;
            this.CenterToParent();
        }

        private void StandardFlow_Load(object sender, EventArgs e)
        {
            this.gpFlowDetail.Visible = false;
            if (this.ObjectKey == "")
            {
                MessageBox.Show("没有指定对象主键【ObjectKey】", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            this.txtUserPM.Text = CommonFuns.NewInstance.LoginInfo.LoginID;
            this.txtStatus.Text = "未激活";
            this.txtSubject.SelectAll();
            loadIni();
        }

        /// <summary>
        /// 
        /// </summary>
        string flowName = ""; //工作流名称
        protected void loadIni()
        {
            string tableName = WorkFlow.GetTableName(this.RelationObjectType);
            if (tableName == "")
            {
                MessageBox.Show("指定参数错误【RelationObjectType】", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                flowName = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.WfTemplatesID).WFT_NAME.ToString();
                this.Text = "【" + flowName + "】" + WorkFlow.GetObjectTitle(this.RelationObjectType);
                this.txtFlowName.Text = flowName;
            }
            CreateFlowGraphicByWFTID();
        }

        protected void CreateFlowGraphicByWFTID()
        {

            DataTable dtTemp = CommonFuns.getDataTableBySql("1", "WHERE DEL_FLAG='N' AND STATUS='Complete' AND WFT_ID='" + this.WfTemplatesID + "'", "WF_TEMPLATES");
            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不存在或者被删除(或者未提交使用)", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
            else
            {
                IList<HYPDM.Entities.WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(this.WfTemplatesID);
                CreateWF(list, this.gpFlowDetail);
                CreateButtonClickEvent(this.gpFlowDetail);
            }

        }
        private void CreateWF(IList<HYPDM.Entities.WF_TEMPLATES_STEP> list, System.Windows.Forms.Control ctl)
        {
            int x = 5;
            int y = 18;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不没有设置任何节点", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
                Panel pnl = null;  //放箭头
                foreach (WF_TEMPLATES_STEP step in list)
                {
                    Button btnStep = new Button();

                    btnStep.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.banner;
                    btnStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    // btnStep.Location = new System.Drawing.Point(5, 18);
                    btnStep.Location = new System.Drawing.Point(x, y);
                    // btnStep.Name = "btnName";
                    btnStep.Size = new System.Drawing.Size(113, 161);
                    // btnStep.TabIndex = 0;
                    // btnStep.Text = "btnText";
                    btnStep.UseVisualStyleBackColor = true;
                    btnStep.Tag = step; //节点信息放在button的tag中
                    btnStep.BackColor = System.Drawing.SystemColors.InactiveBorder;
                    // btnStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    // btnStep.FlatAppearance.BorderSize = 5;
                    // btnStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
                    //  btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    //  btnStep.Location = new System.Drawing.Point(x, y);
                    btnStep.Name = step.WFT_STEP_ID;
                    // btnStep.Size = new System.Drawing.Size(200, 50);
                    // btnStep.TabIndex = 0;
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + "\n" + "发起人:【" + CommonFuns.NewInstance.LoginInfo.LoginID + "】";
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    else
                    {
                        btnStep.Text = "当前步骤:" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    btnStep.TextAlign = ContentAlignment.MiddleLeft;
                    pnl = new Panel();
                    pnl.BackColor = System.Drawing.Color.Transparent;
                    pnl.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.line2;
                    pnl.Location = new System.Drawing.Point(113 + x, (161 / 2 + 18));
                    pnl.Name = "pnl";
                    pnl.Size = new System.Drawing.Size(32, 30);
                    pnl.TabIndex = 0;
                    btnStep.UseVisualStyleBackColor = false;
                    ctl.Controls.Add(btnStep);
                    ctl.Controls.Add(pnl);
                    x += 113 + 32;
                }
                ctl.Controls.Remove(pnl);
            }
        }
        private void CreateButtonClickEvent(System.Windows.Forms.Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl.GetType().Name == "Button")
                {
                    if (((WF_TEMPLATES_STEP)((Button)ctl).Tag).IS_START_STEP != "Y")
                    {
                        ((Button)ctl).Click += new EventHandler(StandardFlow_Click);
                    }

                    // ((Button)ctl).DoubleClick += new EventHandler(StandardFlow_DoubleClick);
                }
            }
        }
        //private void StandardFlow_DoubleClick(Object sender, EventArgs e)
        //{
        //    string stepID = ((Button)sender).Name.ToString();
        //    if (stepID == "")
        //    {
        //        return;
        //    }
        //    cMenu.Tag = stepID;
        //    foreach (Control ctl in this.gpFlowDetail.Controls)
        //    {
        //        if (ctl.GetType().Name == "Button")
        //        {
        //            ((Button)ctl).BackColor = System.Drawing.SystemColors.InactiveBorder;
        //            ((Button)ctl).ContextMenuStrip = null;
        //        }
        //    }
        //    ((Button)sender).ContextMenuStrip = cMenu;
        //    ((Button)sender).BackColor = System.Drawing.Color.Red;
        //    //stepID
        //    //show出用户、群组设定界面
        //    UserAndUserRoleForm frm = new UserAndUserRoleForm();
        //    frm.ShowDialog();
        //}
        StringBuilder stbUser = null;//存放当前选中的用户、用户群组
        private void StandardFlow_Click(Object sender, EventArgs e)
        {
            string stepID = ((Button)sender).Name.ToString();
            if (stepID == "")
            {
                return;
            }
            //  cMenu.Tag = stepID;
            cMenu.Tag = sender;
            // MessageBox.Show(cMenu.Tag.ToString());
            foreach (Control ctl in this.gpFlowDetail.Controls)
            {
                if (ctl.GetType().Name == "Button")
                {
                    ((Button)ctl).BackColor = System.Drawing.SystemColors.InactiveBorder;
                    ((Button)ctl).ContextMenuStrip = null;
                }
            }
            ((Button)sender).ContextMenuStrip = cMenu;
            ((Button)sender).BackColor = System.Drawing.Color.Red;

            //UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //frm.ShowDialog();
            // WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStepInfoByStepID(stepID);
            //stepID

            selUser(((Button)sender).Name.ToString());
            if (stbUser != null && stbUser.ToString() != "")
            {
                ((Button)sender).Text += "\n" + stbUser.ToString();
            }

        }

        private void tspMenuUserOrGroup_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cMenu.Tag.ToString());
            //// //show出用户、群组设定界面
            //UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //frm.ShowDialog();
            Button Clickbtn = (Button)cMenu.Tag;
            selUser(Clickbtn.Name.ToString());
            if (stbUser != null && stbUser.ToString() == "")
            {
                Clickbtn.Text += "\n" + stbUser.ToString();
            }
        }
        private List<DataType.UserOrGroupSelected> selectedUserOrGroupList = new List<DataType.UserOrGroupSelected>();
        /// <summary>
        /// 
        /// </summary>
        private void selUser(string wftStepID)
        {
            stbUser = new StringBuilder();
            UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //DialogResult dialogResult = frm.ShowDialog();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                selectedUserOrGroupList = frm.SelectedUserOrGroupList;
                if (selectedUserOrGroupList == null || selectedUserOrGroupList.Count == 0)
                {
                    return;
                }
                else
                {

                    stbUser = new StringBuilder("\n");
                    foreach (DataType.UserOrGroupSelected sel in selectedUserOrGroupList)
                    {
                        //添加

                        WF_APP_HANDLE wfah = new HYPDM.Entities.WF_APP_HANDLE();
                        wfah.WFAH_ID = Guid.NewGuid().ToString();
                        wfah.LASTUPDATEDATE = "";
                        wfah.LASTUPDATEUSER = "";
                        wfah.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        wfah.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                        wfah.DEL_FLAG = "N";
                        wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                        wfah.OBJECTTYPE = sel.ObjectType.ToString();
                        wfah.OBJECTVALUE = sel.Value.ToString();
                        wfah.WFA_ID = this.wfAppID;
                        wfah.WFT_STEP_ID = wftStepID;
                        wfah.IS_THROUGH = "";
                        try
                        {
                            wfah.Save();
                            if (wfah.OBJECTTYPE == DataType.AuthObjectType.SingleUser.ToString())
                            {
                                stbUser.Append("用户:【" + wfah.OBJECTVALUE + "】" + "\n");
                            }
                            else
                            {
                                stbUser.Append("群组:【" + wfah.OBJECTVALUE + "】" + "\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("处理人设定信息存储异常:" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    // stbUser.Remove(stbUser.Length-1, 1);


                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtSubject.Text == "")
            {
                this.txtSubject.Focus();
                return;
            }
            else
            {
                WF_APP wf = new WF_APP();
                wf.WFA_ID = Guid.NewGuid().ToString();
                wf.WFT_ID = this.WfTemplatesID;
                wf.SUBJECT = this.txtSubject.Text.ToString();
                wf.STATUS = DataType.WFDetailSTATUS.UNActivate.ToString();
                wf.START_DATE = "";
                wf.RELATIONOBJECTTYPE = this.RelationObjectType.ToString();
                wf.OBJECTKEY = this.ObjectKey;
                wf.LASTUPDATEDATE = "";
                wf.LASTUPDATEUSER = "";
                wf.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                wf.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                wf.DEL_FLAG = "N";


                try
                {
                    wf.Save();
                    this.gpFlowDetail.Visible = true;
                    WfAppID = wf.WFA_ID;
                    this.txtSubject.ReadOnly = true;
                    this.btnSubmit.Enabled = false;
                    ///新增拟制人员(发起人)的WF_APP_HANDLE表信息
                    WF_APP_HANDLE wfah = new HYPDM.Entities.WF_APP_HANDLE();

                    wfah.WFAH_ID = Guid.NewGuid().ToString();
                    wfah.LASTUPDATEDATE = "";
                    wfah.LASTUPDATEUSER = "";
                    wfah.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    wfah.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wfah.DEL_FLAG = "N";
                    wfah.IS_THROUGH = "N";
                    wfah.MSG = "";
                    wfah.OBJECTTYPE = DataType.AuthObjectType.SingleUser.ToString();
                    wfah.OBJECTVALUE = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wfah.WFA_ID = this.wfAppID;
                    wfah.WFT_STEP_ID = WorkFlow.NewInstance.GetWFStartStepByWFID(this.WfTemplatesID).WFT_STEP_ID;
                    wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wfah.WFT_STEP_ID).WFT_CURRENT_STEP_ID;

                    // wfah.WFT_STEP_ID = wftStepID;
                    
                    wfah.Save();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("创建新流程信息存储异常:" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }

        private void tspStart_Click(object sender, EventArgs e)
        {
            string contentMsg;
            string nowDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string loginID = CommonFuns.NewInstance.LoginInfo.LoginID;
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            WF_APP app = WorkFlow.NewInstance.GetWFappByWFID(this.WfAppID);
            FlowStepHandle flowstep = new FlowStepHandle();
            if (flowstep.ShowDialog() == DialogResult.OK)
            {
                contentMsg = flowstep.ContentMsg;
                if (app == null)
                {
                    MessageBox.Show("获取流程实例异常", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    if (app.STATUS == DataType.WFDetailSTATUS.Activated.ToString())
                    {
                        MessageBox.Show("当前工作流已经启用，无需再一次启用!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        app.LASTUPDATEUSER = loginID;
                        app.LASTUPDATEDATE = nowDate;
                        app.STATUS = DataType.WFDetailSTATUS.Activated.ToString();
                        try
                        {
                            app.Update();

                            this.txtStatus.Text = "已激活";

                            ///新增拟制节点完成信息
                            WF_DETAIL detail = new HYPDM.Entities.WF_DETAIL();
                            WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStartStepByWFID(app.WFT_ID);
                            detail.Current_STEP_ID = step.WFT_CURRENT_STEP_ID;
                            // detail.CURRENT_STEP_NAME = _wfService.GetWFStep(WorkFlow.NewInstance.GetWFStepInfoByStepID(detail.CURRENT_STEP_ID).WFT_CURRENT_STEP_ID).COMBTEXT;

                            detail.MSG = contentMsg;
                            detail.DEL_FLAG = "N";
                            detail.IS_Through = "Y";
                            detail.COMPLEMENTDATE = nowDate;
                            detail.RECIVEDATE = nowDate;
                            detail.WFD_ID = Guid.NewGuid().ToString();
                            detail.WFA_ID = app.WFA_ID;
                            detail.WFT_STEP_ID = step.WFT_STEP_ID;
                            try
                            {
                                detail.Save();

                                ///新增WF_DETAIL记录，指向下一工作流信息
                                // wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                                WF_DETAIL detailNew = new HYPDM.Entities.WF_DETAIL();
                                detailNew.Current_STEP_ID = WorkFlow.NewInstance.GetWFStartStepByWFID(app.WFT_ID).WFT_NEXT_STEP_ID;
                                //_wfService.GetWFStep(detailNew.Current_STEP_ID).COMBTEXT;
                                // WorkFlow.NewInstance.GetWFStepInfoByStepID(detail.Current_STEP_ID).WFT_NEXT_STEP_ID;
                                // detailNew.CURRENT_STEP_NAME = _wfService.GetWFStep(detailNew.CURRENT_STEP_ID).COMBTEXT;
                                detailNew.MSG = "";
                                //  detailNew.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                                detailNew.IS_Through = "";
                                detailNew.DEL_FLAG = "N";
                                detailNew.COMPLEMENTDATE = "";
                                detailNew.RECIVEDATE = detail.COMPLEMENTDATE;
                                detailNew.WFD_ID = Guid.NewGuid().ToString();
                                detailNew.WFA_ID = detail.WFA_ID;
                                detailNew.WFT_STEP_ID = WorkFlow.NewInstance.GetWftStepIDByStepIDAndAppID(detailNew.WFA_ID, detailNew.Current_STEP_ID);
                                detailNew.Save();



                              
                                ///更新表WF_APP_HANDLE
                                WF_APP_HANDLE item = WorkFlow.NewInstance.GetWfAppHandleItem(detail.WFA_ID, detail.Current_STEP_ID, loginID);
                                item.DEL_FLAG = "N";
                                item.LASTUPDATEDATE = nowDate;
                                item.LASTUPDATEUSER = loginID;
                                item.IS_THROUGH = "Y";
                                item.MSG = contentMsg;
                                item.Update();
                               


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("信息存储异常,错误信息如下:" + "\n" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                return;
                            }

                            MessageBox.Show("当前工作流启用成功!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.tspStart.Enabled = false;
                            this.btnModify.Enabled = false;
                            this.btnSubmit.Enabled = false;
                            this.gpFlowDetail.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("当前工作流启用失败,错误信息如下:" + "\n" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentStepHandle han = new CurrentStepHandle();
            han.ShowDialog();
        }
    }
}
