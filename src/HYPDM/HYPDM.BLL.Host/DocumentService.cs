﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IDocumentService))]
    public class DocumentService : BaseServiceObject, HYPDM.BLL.IDocumentService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_DOCUMENT().DbTableName);
        }

        public IList<PDM_DOCUMENT> GetDocumentList()
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     select item
                );

            return p.ToList();
        }

        #region 保存

        public void DocSave(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), documentList, physicalList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DOCUMENT> documentList = parameters[0] as IList<PDM_DOCUMENT>;
            IList<PDM_PHYSICAL_FILE> physicalList = parameters[1] as IList<PDM_PHYSICAL_FILE>;

            foreach (PDM_DOCUMENT document in documentList)
            {
                document.Save();
            }

            foreach (PDM_PHYSICAL_FILE physical in physicalList)
            {
                physical.Save();
            }
        }
        #endregion

        #region 删除

        public void DocDel(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), documentList, physicalList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DOCUMENT> documentList = parameters[0] as IList<PDM_DOCUMENT>;
            IList<PDM_PHYSICAL_FILE> physicalList = parameters[1] as IList<PDM_PHYSICAL_FILE>;

            foreach (PDM_DOCUMENT document in documentList)
            {
                document.Delete();
            }

            foreach (PDM_PHYSICAL_FILE physical in physicalList)
            {
                physical.Delete();
            }
        }
        #endregion

        public IList<PDM_DOCUMENT> GetDocList(Condition c)
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();
            return query.Select(c).ToList();
        }
    }
}