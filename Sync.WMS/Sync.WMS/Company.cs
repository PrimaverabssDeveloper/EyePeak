using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Company
    {
        private WMSDataImportClient m_WSClient;

        public Company()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Change()
        {

            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.CompanyRequest wsEntity = new CompanyRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.Name = "Company DEMO";

            //Saving
            object result;
            result = m_WSClient.SaveCompany(wsEntity);
        }
    }
}
