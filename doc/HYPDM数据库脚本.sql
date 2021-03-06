USE [drugshop]
GO
/****** Object:  Table [dbo].[PDM_DRAWING_TYPE]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_DRAWING_TYPE](
	[ID] [nvarchar](64) NOT NULL,
	[NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_DRAWING_TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING_TYPE', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING_TYPE', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING_TYPE'
GO
/****** Object:  Table [dbo].[PDM_DRAWING]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PDM_DRAWING](
	[DRAWINGID] [varchar](128) NOT NULL,
	[DRAWINGTYPE] [nvarchar](64) NOT NULL,
	[WORKNO] [varchar](128) NULL,
	[DRAWINGNAME] [nvarchar](128) NOT NULL,
	[DESCRIPTION] [nvarchar](128) NULL,
	[SOURCE] [nvarchar](128) NULL,
	[CUSTOMER] [nvarchar](128) NULL,
	[CUSTUMERPRONO] [nvarchar](128) NULL,
	[DRAWINGSIZE] [nvarchar](64) NULL,
	[STATUS] [nvarchar](128) NULL,
	[LASTUPDATEUSER] [nvarchar](128) NULL,
	[CREATEDATE] [nvarchar](128) NULL,
	[REMARK] [nvarchar](128) NULL,
	[PHYSICALFILE] [nvarchar](128) NULL,
	[VERSION] [float] NULL,
	[LASTUPDATEDATE] [nvarchar](128) NULL,
 CONSTRAINT [PK_PDM_DRAWING] PRIMARY KEY CLUSTERED 
(
	[DRAWINGID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'DRAWINGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'DRAWINGTYPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工作号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'WORKNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'DRAWINGNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'DESCRIPTION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'SOURCE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'CUSTOMER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'客户项目号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'CUSTUMERPRONO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图幅' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'DRAWINGSIZE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'STATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'LASTUPDATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'CREATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'物理文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'PHYSICALFILE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'版本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'VERSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING', @level2type=N'COLUMN',@level2name=N'LASTUPDATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图纸' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DRAWING'
GO
/****** Object:  Table [dbo].[PDM_DOCUMENT_TYPE]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_DOCUMENT_TYPE](
	[ID] [nvarchar](64) NOT NULL,
	[NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_DOCUMENT_TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT_TYPE', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT_TYPE', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT_TYPE'
GO
/****** Object:  Table [dbo].[PDM_DOCUMENT]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_DOCUMENT](
	[DOCID] [nvarchar](128) NOT NULL,
	[DOCNAME] [nvarchar](128) NULL,
	[DOCTYPE] [nvarchar](128) NULL,
	[CUSTOMERNAME] [nvarchar](128) NULL,
	[CUSTOMERPRONO] [nvarchar](128) NULL,
	[DOCSTATUS] [nvarchar](128) NULL,
	[LASTUPDATEUSER] [nvarchar](128) NULL,
	[CREATEDATE] [nvarchar](128) NULL,
	[LASTUPDATEDATE] [nvarchar](128) NULL,
	[REMARK] [nvarchar](128) NULL,
	[PHYSICALFILE] [nvarchar](128) NULL,
	[VERSION] [nvarchar](18) NULL,
	[DOCNO] [nvarchar](128) NULL,
 CONSTRAINT [PK_DBO_PDM_DOCUMENT] PRIMARY KEY CLUSTERED 
(
	[DOCID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'DOCID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'DOCNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'DOCTYPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'CUSTOMERNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'客户项目号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'CUSTOMERPRONO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'DOCSTATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'LASTUPDATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'CREATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'LASTUPDATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'物理文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'PHYSICALFILE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'版本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'VERSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT', @level2type=N'COLUMN',@level2name=N'DOCNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_DOCUMENT'
GO
/****** Object:  Table [dbo].[PDM_USER]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_USER](
	[NAME] [nvarchar](128) NOT NULL,
	[PASSWORD] [nvarchar](128) NULL,
 CONSTRAINT [PK_PDM_USER] PRIMARY KEY CLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'用户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_USER', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'用户密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_USER', @level2type=N'COLUMN',@level2name=N'PASSWORD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_USER'
GO
/****** Object:  Table [dbo].[PDM_UNIT]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_UNIT](
	[ID] [nvarchar](64) NOT NULL,
	[NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_UNIT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'单位ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_UNIT', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'单位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_UNIT', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_UNIT'
GO
/****** Object:  Table [dbo].[PDM_PRODUCT_STRUCT]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_PRODUCT_STRUCT](
	[PRODUCTID] [nvarchar](128) NOT NULL,
	[ISPRODUCT] [bit] NULL,
	[PARTSID] [nvarchar](128) NOT NULL,
	[SORTCODE] [int] NULL,
	[QUANTITY] [int] NULL,
	[REMARK] [nvarchar](128) NULL,
	[ID] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_PRODUCT_STRUCT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'PRODUCTID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'是不是产品' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'ISPRODUCT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零部件编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'PARTSID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'SORTCODE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'使用数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'QUANTITY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'产品结构' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT_STRUCT'
GO
/****** Object:  Table [dbo].[PDM_PRODUCT]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_PRODUCT](
	[PRODUCTID] [nvarchar](128) NOT NULL,
	[PRODUCTNAME] [nvarchar](128) NOT NULL,
	[VERSION] [nvarchar](128) NULL,
	[SORTCODE] [int] NULL,
	[MODELNO] [nvarchar](128) NULL,
	[SIZE] [nvarchar](128) NULL,
	[MATERIAL] [nvarchar](128) NULL,
	[TECHNAME] [nvarchar](128) NULL,
	[TECHINSTRUCTION] [nvarchar](128) NULL,
	[PRODUCTNOATTR] [nvarchar](128) NULL,
	[UNIT] [nvarchar](64) NULL,
	[PROPERTY] [nvarchar](128) NULL,
	[WORKCENTER] [nvarchar](128) NULL,
	[PRODUCTSTATUS] [nvarchar](128) NULL,
	[LASTUPDATEUSER] [nvarchar](128) NULL,
	[CREATEUSER] [nvarchar](128) NULL,
	[LASTUPDATEDATE] [nvarchar](128) NULL,
	[REMARK] [nvarchar](128) NULL,
	[DRAWINGID] [nvarchar](128) NULL,
 CONSTRAINT [PK_PDM_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[PRODUCTID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'PRODUCTID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'产品名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'PRODUCTNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'版本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'VERSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'顺序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'SORTCODE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'产品型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'MODELNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'规格/尺寸' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'SIZE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'材料' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'MATERIAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工艺名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'TECHNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工艺说明、' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'TECHINSTRUCTION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'品号属性' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'PRODUCTNOATTR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'单位ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'UNIT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'性质' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'PROPERTY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工作中心' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'WORKCENTER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'PRODUCTSTATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'LASTUPDATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'CREATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'LASTUPDATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT', @level2type=N'COLUMN',@level2name=N'DRAWINGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'产品' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PRODUCT'
GO
/****** Object:  Table [dbo].[PDM_PHYSICAL_FILE]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_PHYSICAL_FILE](
	[PHYSICALID] [nvarchar](128) NOT NULL,
	[FILENAME] [nvarchar](128) NULL,
	[FILEVERSION] [nvarchar](128) NULL,
	[FILETYPE] [nvarchar](128) NULL,
	[CHECKIN] [datetime] NULL,
	[CHECKOUT] [datetime] NULL,
	[DESCRIPTION] [nvarchar](128) NULL,
	[PARENT] [nvarchar](128) NULL,
	[OPERATEUSER] [nvarchar](128) NULL,
	[FILEID] [nvarchar](128) NULL,
	[PAPERS] [nvarchar](128) NULL,
	[FILEPATH] [nvarchar](128) NULL,
 CONSTRAINT [PK_DBO_PDM_PHYSICAL_FILE] PRIMARY KEY CLUSTERED 
(
	[PHYSICALID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'PHYSICALID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'FILENAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件版本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'FILEVERSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'FILETYPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'检入日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'CHECKIN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'检出日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'CHECKOUT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'DESCRIPTION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'父节点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'PARENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'操作人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'OPERATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'FILEID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'PAPERS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE', @level2type=N'COLUMN',@level2name=N'FILEPATH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'物理文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PHYSICAL_FILE'
GO
/****** Object:  Table [dbo].[PDM_PARTS_TYPE]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_PARTS_TYPE](
	[ID] [nvarchar](64) NOT NULL,
	[NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_PARTS_TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零件类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS_TYPE', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零件类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS_TYPE', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS_TYPE'
GO
/****** Object:  Table [dbo].[PDM_PARTS]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_PARTS](
	[PARTSID] [nvarchar](128) NOT NULL,
	[PARTSNAME] [nvarchar](128) NOT NULL,
	[SINGLENETWEIGHT] [float] NULL,
	[PARTSTYPE] [nvarchar](64) NOT NULL,
	[FACTORY] [nvarchar](128) NULL,
	[MATERIAL] [nvarchar](64) NULL,
	[DRAWINGID] [nvarchar](128) NULL,
	[ROLLINGSPECIFICTION] [nvarchar](128) NULL,
	[KEEPINGUNIT] [nvarchar](64) NULL,
	[TECHROUTENO] [nvarchar](128) NULL,
	[TECHROUTENUMBER] [nvarchar](128) NULL,
	[PARTSSTATUS] [nvarchar](128) NULL,
	[LASTUPDATEUSER] [nvarchar](128) NULL,
	[CREATEDATE] [nvarchar](128) NULL,
	[LASTUPDATEDATE] [nvarchar](128) NULL,
	[REMARK] [nvarchar](128) NULL,
	[ERPATTR] [nvarchar](128) NULL,
	[DOCID] [nvarchar](128) NULL,
	[CHANGEREQUEST] [nvarchar](128) NULL,
	[VERSION] [float] NULL,
 CONSTRAINT [PK_PDM_PARTS] PRIMARY KEY CLUSTERED 
(
	[PARTSID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零件编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'PARTSID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零件名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'PARTSNAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'单件净重' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'SINGLENETWEIGHT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零部件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'PARTSTYPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工厂' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'FACTORY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'材料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'MATERIAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'图号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'DRAWINGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'架次/轧制规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'ROLLINGSPECIFICTION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'库存单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'KEEPINGUNIT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工艺路线品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'TECHROUTENO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'工艺路线编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'TECHROUTENUMBER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'PARTSSTATUS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'LASTUPDATEUSER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'CREATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'LASTUPDATEDATE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'REMARK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'ERP属性' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'ERPATTR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'文档ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'DOCID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'变更请求' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'CHANGEREQUEST'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'版本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS', @level2type=N'COLUMN',@level2name=N'VERSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'零部件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_PARTS'
GO
/****** Object:  Table [dbo].[PDM_MATERIAL]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDM_MATERIAL](
	[ID] [nvarchar](128) NOT NULL,
	[NAME] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_PDM_MATERIAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'材料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_MATERIAL', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'材料名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_MATERIAL', @level2type=N'COLUMN',@level2name=N'NAME'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DESCRIPTION', @value=N'材料' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PDM_MATERIAL'
GO
/****** Object:  Table [dbo].[PDM_IDENTITYVALUES]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PDM_IDENTITYVALUES](
	[GUID] [varchar](36) NOT NULL,
	[ITEMKEY] [nvarchar](128) NOT NULL,
	[ITEMVALUE] [int] NOT NULL,
	[DESCRIPTION] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[ITEMKEY] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[PDM_GETIDENTITYVALUE]    Script Date: 07/04/2013 14:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PDM_GETIDENTITYVALUE] 
	-- Add the parameters for the stored procedure here
	@itemKey char(128)
AS
BEGIN TRANSACTION
	update dbo.PDM_IDENTITYVALUES Set ITEMVALUE = ITEMVALUE + 1 where ITEMKEY = @itemKey
	select ITEMVALUE from dbo.PDM_IDENTITYVALUES where ITEMKEY = @itemKey
COMMIT TRANSACTION
GO
/****** Object:  StoredProcedure [dbo].[GETIDENTITYVALUE]    Script Date: 07/04/2013 14:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GETIDENTITYVALUE]

	@itemKey char(128)

AS

BEGIN TRANSACTION
	update dbo.EAS_IDENTITYVALUES Set ITEMVALUE = ITEMVALUE + 1 where ITEMKEY = @itemKey
	select ITEMVALUE from dbo.EAS_IDENTITYVALUES where ITEMKEY = @itemKey
COMMIT TRANSACTION

GO
GO
/****** Object:  View [dbo].[EAS_GROUP_MODULES]    Script Date: 07/04/2013 14:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EAS_GROUP_MODULES]
AS
SELECT     A.GUID, A.NAME, A.TYPE, A.VERSION, A.[ASSEMBLY], A.DEVELOPER, A.URL, A.DESCRIPTION, A.PACKAGE, A.ICON, A.LMTIME, A.SORTCODE, b.GROUPID, 
                      C.NAME AS GROUPNAME, A.ATTRIBUTES
FROM         dbo.EAS_MODULES AS A LEFT OUTER JOIN
                      dbo.EAS_MODULEGROUPS AS b ON A.GUID = b.OBJECTID LEFT OUTER JOIN
                      dbo.EAS_GROUPS AS C ON b.GROUPID = C.ID
GO
/****** Object:  Default [DF__PDM_IDENTI__GUID__74794A92]    Script Date: 07/04/2013 14:13:09 ******/
ALTER TABLE [dbo].[PDM_IDENTITYVALUES] ADD  DEFAULT (newid()) FOR [GUID]
GO
