using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class DocDefinition
    {
        private WMSDataImportClient m_WSClient;

        public DocDefinition()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocDefinitionRequest wsEntity = new DocDefinitionRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.DocSeries = "FA/2016";
            wsEntity.DocType = DocTypeEnum.CLI_OUT;
            wsEntity.DocName = "FActura Cli";

            //Saving
            object result;
            result = m_WSClient.SaveDocDefinition(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocDefinitionRequest wsEntity = new DocDefinitionRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.DocSeries = "FA/2016";
            wsEntity.DocType = DocTypeEnum.CLI_OUT;
            wsEntity.DocName = "FActura Cliente";

            //Saving
            object result;
            result = m_WSClient.SaveDocDefinition(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocDefinitionRequest wsEntity = new DocDefinitionRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.DocSeries = "FA/2016";

            //Saving
            object result;
            result = m_WSClient.DeleteDocDefinition(wsEntity);
        }
    }
}
