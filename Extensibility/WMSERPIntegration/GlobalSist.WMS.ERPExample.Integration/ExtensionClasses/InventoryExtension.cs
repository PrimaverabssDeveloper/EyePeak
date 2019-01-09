using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GlobalSist.WMS.ERPExample.Integration
{
    internal class InventoryExtension : Facades.TaskLogic.IInventory
    {
        /// <summary>
        /// Occurs when a new Stock Count is created, and is used to get the Stock of all the SKU's available in the Warehouse
        /// </summary>
        /// <param name="warehouseCode">Warehouse Code</param>
        /// <returns>Should return a Data Table with the following fields: SKU; Batch; Current Stock; Requires Batch; Requires Serial</returns>
        public DataTable GetERPSkuStocks(string warehouseCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Occurs when a SKU is viewed in the Front-End, and returns the SKU Stock from the ERP
        /// </summary>
        /// <param name="warehouseCode">Wharehouse Code</param>
        /// <param name="skuCode">SKU Code</param>
        /// <param name="batchCode">Batch Code</param>
        /// <returns></returns>
        public decimal GetERPStock(string warehouseCode, string skuCode, string batchCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Occurs when the Inventory is exported
        /// </summary>
        /// <param name="inventory">List of InventoryExport Objects</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool OnInventoryExport(object inventory)
        {
            throw new NotImplementedException();
        }
    }
}
