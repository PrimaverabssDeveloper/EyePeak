using GlobalSist.Facades.TaskLogic;
using System;
using System.Data;

namespace InventoryExtension
{
    public class InventoryExt : IInventory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryExt"/> class.
        /// </summary>
        public InventoryExt()
        {
        }

        /// <summary>
        /// Gets the erp sku stocks.
        /// </summary>
        /// <param name="warehouseCode">The warehouse code.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DataTable GetERPSkuStocks(string warehouseCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the erp stock.
        /// </summary>
        /// <param name="warehouseCode">The warehouse code.</param>
        /// <param name="skuCode">The sku code.</param>
        /// <param name="batchCode">The batch code.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal GetERPStock(string warehouseCode, string skuCode, string batchCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [inventory export].
        /// </summary>
        /// <param name="inventory">The inventory.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnInventoryExport(object inventory)
        {
            throw new NotImplementedException();
        }
    }
}
