using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalSist.WMS.ERPExample.Integration
{
    internal class BatchExtension : Facades.SKULogic.IBatchFacade
    {
        /// <summary>
        /// Check if a Batch exists in the ERP System
        /// </summary>
        /// <param name="skucode">SKU Code</param>
        /// <param name="batchCode">Batch Code</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool CheckBatchInERP(string skucode, string batchCode)
        {
            return true;
        }

        /// <summary>
        /// Check if a SKU Contorls Batch in the ERP System
        /// </summary>
        /// <param name="skucode">SKU Code</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool ControlBatchInERP(string skuCode)
        {
            return true;
        }

        /// <summary>
        /// Returns a List of Batch available for the SKU in the ERP System
        /// </summary>
        /// <param name="skucode">SKU Code</param>
        /// <returns>Returns a List of Strings</returns>
        public List<string> GetPrimaveraSkuBatches(string skuCode)
        {
            List<string> response = new List<string>();
            return response;
        }
    }
}
