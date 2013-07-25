﻿#region AgileEAS.NET-generated
//------------------------------------------------------------------------------
//     AgileEAS.NET应用开发平台，是基于敏捷并行开发思想以及.NET构件技术而开发的一个应用系统快速开发平台，用于帮助中小软件企业
//建立一条适合快速变化的开发团队，以达到节省开发成本、缩短开发时间，快速适应市场变化的目的。
//     AgileEAS.NET应用开发平台包含基础类库、资源管理平台、运行容器、开发辅助工具等四大部分，资源管理平台为敏捷并行开发提供了
//设计、实现、测试等开发过程的并行，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子
//功能模块按照业务功能组织成单独的程序集文件，各子系统开发完成后，由AgileEAS.NET资源管理平台进行统一的集成部署。
//
//     AgileEAS.NET SOA 中间件平台是一套免费的快速开发工具，可以不受限制的用于各种非商业开发之中，商业应用请向作者获取商业授权，
//商业授权也是免费的，但是对于非授权的商业应用视为侵权，开发人员可以参考官方网站和博客园等专业网站获取公开的技术资料，也可以向
//AgileEAS.NET官方团队请求技术支持。
//
// 官方网站：http://www.smarteas.net
// 团队网站：http://www.agilelab.cn
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由AgileEAS.NET数据模型设计工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

using System;
using System.ComponentModel;
using System.Data;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using System.Runtime.Serialization;

namespace HYPDM.Entities
{
    /// <summary>
    /// 实体对象 PDM_FILTER(过滤器)。
    /// </summary>
    [Serializable()]
    [Table("PDM_FILTER", "过滤器")]
    partial class PDM_FILTER : DataEntity<PDM_FILTER>, IDataEntity<PDM_FILTER>
    {
        public PDM_FILTER()
        {
        }

        protected PDM_FILTER(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// ID 。
        /// </summary>
        [Column("ID", "ID"), DataSize(128), PrimaryKey]
        [DisplayName("ID")]
        public string ID
        {
            get;
            set;
        }

        /// <summary>
        /// 所有权 。
        /// </summary>
        [Column("OWNERSHIP", "所有权"), DataSize(128)]
        [DisplayName("所有权")]
        public string OWNERSHIP
        {
            get;
            set;
        }

        /// <summary>
        /// 视图 。
        /// </summary>
        [Column("VIEWER", "视图"), DataSize(128)]
        [DisplayName("视图")]
        public bool VIEWER
        {
            get;
            set;
        }

        /// <summary>
        /// 编号 。
        /// </summary>
        [Column("PARTSNO", "编号"), DataSize(128)]
        [DisplayName("编号")]
        public string PARTSNO
        {
            get;
            set;
        }

        /// <summary>
        /// 版本 。
        /// </summary>
        [Column("VERSION", "版本"), DataSize(128)]
        [DisplayName("版本")]
        public string VERSION
        {
            get;
            set;
        }

        /// <summary>
        /// 版本类型 。
        /// </summary>
        [Column("VERSIONTYPE", "版本类型"), DataSize(128)]
        [DisplayName("版本类型")]
        public string VERSIONTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// FROMDATE 。
        /// </summary>
        [Column("FROMDATE", "FROMDATE"), DataSize(128)]
        [DisplayName("FROMDATE")]
        public string FROMDATE
        {
            get;
            set;
        }

        /// <summary>
        /// TODATE 。
        /// </summary>
        [Column("TODATE", "TODATE"), DataSize(128)]
        [DisplayName("TODATE")]
        public string TODATE
        {
            get;
            set;
        }

        /// <summary>
        /// 顺序 。
        /// </summary>
        [Column("SORTCODE", "顺序"), DataSize(128)]
        [DisplayName("顺序")]
        public string SORTCODE
        {
            get;
            set;
        }

        /// <summary>
        /// 规格代号 。
        /// </summary>
        [Column("SPECIFICATIONCODE", "规格代号"), DataSize(128)]
        [DisplayName("规格代号")]
        public string SPECIFICATIONCODE
        {
            get;
            set;
        }

        /// <summary>
        /// 描述 。
        /// </summary>
        [Column("DESCRIPTION", "描述"), DataSize(128)]
        [DisplayName("描述")]
        public string DESCRIPTION
        {
            get;
            set;
        }

        /// <summary>
        /// 数量 。
        /// </summary>
        [Column("QUANTITY", "数量"), DataSize(128)]
        [DisplayName("数量")]
        public string QUANTITY
        {
            get;
            set;
        }

        /// <summary>
        /// 单件净重 。
        /// </summary>
        [Column("SINGLENETWEIGHT", "单件净重"), DataSize(128)]
        [DisplayName("单件净重")]
        public string SINGLENETWEIGHT
        {
            get;
            set;
        }

        /// <summary>
        /// 表面处理 。
        /// </summary>
        [Column("SURFACESOLVE", "表面处理"), DataSize(128)]
        [DisplayName("表面处理")]
        public string SURFACESOLVE
        {
            get;
            set;
        }

        /// <summary>
        /// 过滤器名称 。
        /// </summary>
        [Column("FILTERNAME", "过滤器名称"), DataSize(128)]
        [DisplayName("过滤器名称")]
        public string FILTERNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 产品ID 。
        /// </summary>
        [Column("PRODUCTID", "产品ID"), DataSize(128)]
        [DisplayName("产品ID")]
        public string PRODUCTID
        {
            get;
            set;
        }

        #endregion
    }
}
