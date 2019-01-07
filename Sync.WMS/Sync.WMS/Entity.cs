using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Entity
    {
        private WMSDataImportClient m_WSClient;

        public Entity()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.EntityRequest wsEntity = new EntityRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.Name = "Entity para teste de integração3";
            wsEntity.EntityCode = "T5";

            //Saving
            object result;
            result = m_WSClient.SaveEntity(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.EntityRequest wsEntity = new EntityRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.Name = "Entidade para teste de integração3";
            wsEntity.EntityCode = "T5";
            wsEntity.OldEntityCode = "T5";

            //Saving
            object result;
            result = m_WSClient.SaveEntity(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.EntityRequest wsEntity = new EntityRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.EntityCode = "T5";

            //Saving
            object result;
            result = m_WSClient.DeleteEntity(wsEntity);
        }
    }
}
