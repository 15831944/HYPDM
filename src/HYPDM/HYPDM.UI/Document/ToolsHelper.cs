﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.BLL;
using HYPDM.Entities;
namespace HYPDM.WinUI.Document
{
   public  class ToolsHelper
    {

        DataTable dtDirList = null;//获取文档目录的清单
        TreeNode rootNode = null; //treeview的根节点
        //DataTable dtDocFileList = null;//文档清单列表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentID"></param>
        /// <param name="dt"></param>
        public void CreatTree(TreeNodeCollection Nds, string parentID, DataTable dt)
        {
            //DataView dv = new DataView();
            TreeNode tmpNode;
            //dv.Table = dt;
            //dv.RowFilter = "上级单位ID='" + parentID + "'";
            DataRow[] dv = dt.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", parentID));
            foreach (DataRow drv in dv)
            {
                tmpNode = new TreeNode();
                tmpNode.Text = drv["DFD_PATH_NAME"].ToString();
                tmpNode.Tag = drv["DFD_ID"].ToString();
                tmpNode.ExpandAll();
                Nds.Add(tmpNode);
                CreatTree(tmpNode.Nodes, tmpNode.Tag.ToString(), dt);
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="tv"></param>
       /// <param name="dtDocList"></param>
        public void getTreeViewByPathDir(TreeView tv)
        {
             HYDocumentMS.IFileHelper filehelper = new HYDocumentMS.FileHelper();
            dtDirList = filehelper.getDocFileDir(true);//获取文档目录的清单
            CreatTree(tv.Nodes, "0", dtDirList);
            tv.ExpandAll();
        }
        //public void getTreeViewByPathDir(TreeView treeview)
        //{

        //    //dtDocFileList = dtDocList;
        //    rootNode = new TreeNode();
        //    TreeNode node;

        //     HYDocumentMS.IFileHelper   filehelper=new  FileHelper();
        //    //dtDirList = getDocFileDir(); //获取文档目录的清单
        //    dtDirList = filehelper.getDocFileDir(true);
        //    // dt.Select("DFD_PARENT_DIR_ID=0");

        //    DataRow[] rootDir = dtDirList.Select("DFD_PARENT_DIR_ID='0'"); //根目录
        //    if (rootDir.Length > 0)
        //    {
        //        foreach (DataRow row in rootDir)
        //        {

        //            rootNode.Text = row["DFD_PATH_NAME"].ToString();
        //            rootNode.Tag = row["DFD_ID"].ToString();  //根节点
        //           // listFileTree(rootNode);


        //            DataRow[] rowdir = dtDirList.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", row["DFD_ID"].ToString())); //一级子目录
        //            if (rowdir.Length > 0)
        //            {
        //                foreach (DataRow r in rowdir)
        //                {
        //                    node = new TreeNode();
        //                    node.Text = r["DFD_PATH_NAME"].ToString();
        //                    node.Tag = r["DFD_ID"].ToString();
        //                   // listFileTree(node);
        //                    listChildDir(node, r["DFD_ID"].ToString()); //遍历指定一级目录的子目录
        //                }
        //            }

        //        }
        //    }
        //    rootNode.ExpandAll();
        //    treeview.Nodes.Add(rootNode);
        //    //foreach(DataRow row in dtDocFileList.Rows)
        //    //{
        //    //    node = new TreeNode();
        //    //    node.Text = row["DFL_FILE_NAME"].ToString();
        //    //    node.Tag = row["DFL_FILE_ROOT_PATH"].ToString() +"\\"+row["DFL_FILE_CHILD_PATH"].ToString() +"\\"+ row["DFL_FILE_NAME"].ToString();
        //    //   // MessageBox.Show(node.Tag.ToString());
        //    //    rootNode.Nodes.Add(node);
        //    //}
        //    //treeview.Nodes.Add(rootNode);

        //}
       /// <summary>
       /// 获取文档路径
       /// </summary>
       /// <returns></returns>
        //public DataTable getDocFileDir()
        //{
        //    DataTable tbDirList = new DataTable();
        //    tbDirList = EAS.Services.ServiceContainer.GetService<IDocFileListService>().GetDocFileDir();
        //    return tbDirList;
        //}

        /// <summary>
        /// 遍历节点的子目录
        /// </summary>
        /// <param name="node"></param>
        /// <param name="dfd_id"></param>
        /// <returns></returns>
        //private void listChildDir(TreeNode node, string dfd_id)
        //{
        //    TreeNode nnode;

        //    DataRow[] rdir = dtDirList.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", dfd_id)); //指定目录存在的子目录
        //    if (rdir.Length > 0)
        //    {
        //        foreach (DataRow r in rdir)
        //        {
        //            nnode = new TreeNode();
        //            nnode.Text = r["DFD_PATH_NAME"].ToString();
        //            // nnode.Tag = r["DFD_ID"].ToString();
        //            nnode.Tag = r["DFD_ID"].ToString();
        //            //node.Nodes.Add(nnode);
        //            //listFileTree(nnode);
        //            listChildDir(nnode, r["DFD_ID"].ToString()); //遍历节点的子目录
 
        //            node.Nodes.Add(nnode);
        //        }
        //        rootNode.Nodes.Add(node);
        //    }

        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="node"></param>
        //private void listFileTree(TreeNode node)
        //{
        //    string id = node.Tag.ToString();
        //    TreeNode fileNode;
        //    DataRow[] fileRows = dtDocFileList.Select(string.Format("DFL_FILE_CHILD_PATH='{0}'", id));
        //    foreach (DataRow fileRow in fileRows)
        //    {
        //        fileNode = new TreeNode();
        //        fileNode.Text = fileRow["DFL_FILE_NAME"].ToString();
        //        //fileNode.Tag = fileRow["DFL_ID"].ToString();
        //        fileNode.Tag = fileRow;
        //        node.Nodes.Add(fileNode);
        //    }

        //}
        //List<string> list = null; //存放路径节点
        //DataTable dtTemp = null;
        //public string getDocumentAllPathByPathID(string pathid)
        //{
        //    list = new List<string>();
        //    dtTemp = this.getDocFileDir();
        //    string strPath = ""; //返回路径
        //    DataRow[] rows = dtTemp.Select(string.Format("DFD_ID='{0}'", pathid));
        //    DataRow row = null;
        //    if (rows.Length > 0)
        //    {
        //        row = rows[0];
        //        list.Add(row["DFD_PATH_NAME"].ToString());
        //        if (!row["DFD_PARENT_DIR_ID"].ToString().Equals("0"))
        //        {
        //            getFilePath(row["DFD_PARENT_DIR_ID"].ToString());
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("非法路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        //    }

        //    if (list.Count > 0)
        //    {
        //        for (int i = list.Count - 1; i >= 0; i--)
        //        {
        //            strPath += list[i].ToString() + "\\";
        //        }
        //    }

        //    return strPath;
        //}

        /// <summary>
        /// 递归出路径的子路径
        /// </summary>
        /// <param name="pathParentID"></param>
        //private void getFilePath(string pathParentID)
        //{
        //    DataRow[] rows = dtTemp.Select(string.Format("DFD_ID='{0}'", pathParentID));
        //    DataRow row = null;
        //    if (rows.Length > 0)
        //    {
        //        row = rows[0];
        //        list.Add(row["DFD_PATH_NAME"].ToString());
        //        if (!row["DFD_PARENT_DIR_ID"].ToString().Equals("0"))
        //        {
        //            getFilePath(row["DFD_PARENT_DIR_ID"].ToString());
        //        }
        //    }
        //}
    }
}
