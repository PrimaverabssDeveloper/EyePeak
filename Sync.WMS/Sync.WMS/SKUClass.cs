using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class SKUClass
    {
        private WMSDataImportClient m_WSClient;

        public SKUClass()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.ClassRequest wsEntity = new ClassRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.Code = "AA";
            wsEntity.Name = "SKUClass AA";

            //Saving
            object result;
            result = m_WSClient.SaveClass(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.ClassRequest wsEntity = new ClassRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.Code = "AA";
            wsEntity.OldCode = "AA";
            wsEntity.Name = "SKUClass AAA";

            //Saving
            object result;
            result = m_WSClient.SaveClass(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.ClassRequest wsEntity = new ClassRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.Code = "AA";

            //Saving
            object result;
            result = m_WSClient.DeleteClass(wsEntity);
        }
    }
}
