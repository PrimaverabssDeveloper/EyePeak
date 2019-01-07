using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Warehouse
    {
        private WMSDataImportClient m_WSClient;

        public Warehouse()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.WarehouseRequest wsEntity = new WarehouseRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.WarehouseCode = "A100";
            wsEntity.WarehouseName = "Warehouse Teste";

            //Saving
            object result;
            result = m_WSClient.SaveWarehouse(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.WarehouseRequest wsEntity = new WarehouseRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.OldWarehouseCode = "A100";
            wsEntity.WarehouseCode = "A100";
            wsEntity.WarehouseName = "Nova Descrição";

            //Saving
            object result;
            result = m_WSClient.SaveWarehouse(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.WarehouseRequest wsEntity = new WarehouseRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.WarehouseCode = "A100";

            //Saving
            object result;
            result = m_WSClient.DeleteWarehouse(wsEntity);
        }
    }
}
