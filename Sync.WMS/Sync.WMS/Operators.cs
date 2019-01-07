using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Operators
    {
        private WMSDataImportClient m_WSClient;

        public Operators()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.OperatorsRequest wsEntity = new OperatorsRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.OperatorCode = "123";
            wsEntity.Name = "António";

            //Saving
            object result;
            result = m_WSClient.SaveOperator(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.OperatorsRequest wsEntity = new OperatorsRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.OperatorCode = "123";
            wsEntity.Name = "António António";

            //Saving
            object result;
            result = m_WSClient.SaveOperator(wsEntity);
        }

    }
}
