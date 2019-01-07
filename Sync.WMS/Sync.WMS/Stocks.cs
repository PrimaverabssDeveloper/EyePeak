using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Stocks
    {
        private WMSDataImportClient m_WSClient;
        public Stocks()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void GetSKUStock()
        {

            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.SkuStockRequest wsEntity = new SkuStockRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.SKU = "A0001";
            wsEntity.DeductPendingQtyOrders = false;

            //Get Data
            object result;
            result = m_WSClient.GetSkuStock(wsEntity);
        }

    }
}