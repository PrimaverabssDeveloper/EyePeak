using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class SKUGroup
    {
        private WMSDataImportClient m_WSClient;

        public SKUGroup()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.GroupRequest wsEntity = new GroupRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.GroupCode = "AA";
            wsEntity.Name = "Família AA";

            //Saving
            object result;
            result = m_WSClient.SaveGroup(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.GroupRequest wsEntity = new GroupRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.GroupCode = "AA";
            wsEntity.OldGroupCode = "AA";
            wsEntity.Name = "Família AAA";

            //Saving
            object result;
            result = m_WSClient.SaveGroup(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.GroupRequest wsEntity = new GroupRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.GroupCode = "AA";

            //Saving
            object result;
            result = m_WSClient.DeleteGroup(wsEntity);
        }
    }
}
