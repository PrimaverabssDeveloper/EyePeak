using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Container
    {
        private WMSDataImportClient m_WSClient;

        public Container()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void BlockContainer()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.ContainerRequest wsEntity = new ContainerRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.ContainerCode = "000000000010";

            //Saving
            object result;
            result = m_WSClient.BlockContainer(wsEntity);
        }

        public void UnBlockContainer()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.ContainerRequest wsEntity = new ContainerRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.ContainerCode = "000000000010";

            //Saving
            object result;
            result = m_WSClient.UnBlockContainer(wsEntity);
        }

    }
}
