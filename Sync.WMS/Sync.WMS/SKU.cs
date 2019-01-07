using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class SKU
    {
        private WMSDataImportClient m_WSClient;
        public SKU()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {

            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.SKURequest wsEntity = new SKURequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.Name = "SKU Teste";
            wsEntity.SKU = "A0001";
            wsEntity.Unit = "UN";
            wsEntity.PurchaseUnit = "UN";
            wsEntity.ExpedUnit = "UN";
            //Saving
            object result;
            result = m_WSClient.SaveSKU(wsEntity);
        }

        public void Change()
        {

            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.SKURequest wsEntity = new SKURequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.Name = "Nova Descrição";
            wsEntity.OldSKU = "0000001";
            wsEntity.SKU = "0000001";
            wsEntity.Unit = "UN";
            wsEntity.PurchaseUnit = "UN";
            wsEntity.ExpedUnit = "UN";

            //Saving
            object result;
            result = m_WSClient.SaveSKU(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.SKURequest wsEntity = new SKURequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS10";
            wsEntity.SKU = "0000001";

            //Saving
            object result;
            result = m_WSClient.DeleteSKU(wsEntity);
        }

    }
}
