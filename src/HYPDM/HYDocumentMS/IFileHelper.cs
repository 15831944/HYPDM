﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HYDocumentMS
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileHelper
    {
        /// <summary>
        /// 返回指定删除标识的文件清单列表,true:delflag为N,false:delfalg为Y
        /// </summary>
        /// <param name="bl">true为只会返回删除标识为N的文件列表清单，false返回删除标识为Y的文件列表清单</param>
        /// <returns>DataTable</returns>
        DataTable getDocFileList(Boolean bl);
        /// <summary>
        /// 返回所有文件清单，不管是否删除
        /// </summary>
        /// <returns></returns>
        DataTable getDocFileList();
        /// <summary>
        /// 获取treeview的目录结构及文件列表
        /// </summary>
        /// <param name="treeview"></param>
        /// <param name="dtDocList"></param>
        void getTreeViewByDocFileList(System.Windows.Forms.TreeView treeview, DataTable dtDocFileList);
      /// <summary>
        /// 获取文件目录清单
      /// </summary>
      /// <param name="bl">true标识没有删除,false标识没有删除</param>
      /// <returns></returns>
        DataTable getDocFileDir(Boolean bl);
        /// <summary>
        /// 根据传入的路径pathID获取文件的传输路径
        /// </summary>
        /// <param name="pathid"></param>
        /// <returns></returns>
        string getDocumentAllPathByPathID(string pathid);
        /// <summary>
        /// 获取文件目录清单，不区别是否删除
        /// </summary>
        /// <returns></returns>
        DataTable getAllDocFileDir();
    }
}