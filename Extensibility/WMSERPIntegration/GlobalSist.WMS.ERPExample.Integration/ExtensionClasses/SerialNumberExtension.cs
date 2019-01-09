using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalSist.WMS.ERPExample.Integration
{
    internal class SerialNumberExtension : Facades.SKULogic.ISerialNumberFacade
    {
        /// <summary>
        /// Occors when a new Serial Number is created on the documents
        /// </summary>
        /// <param name="skuInstance">SKU Object</param>
        /// <param name="documentInstance">Doc Object</param>
        /// <param name="serialNumber">Serial Number to be created</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool CheckSerialNumber(object skuInstance, object documentInstance, string serialNumber)
        {
            return true;
        }

        /// <summary>
        /// Check if a Serial Number exists on a Document for a specific SKU
        /// </summary>
        /// <param name="skuCode">SKU Object</param>
        /// <param name="documentInstance">Doc Object</param>
        /// <param name="serialNumber">Serial Number</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool CheckSerialNumber(string skuCode, object documentInstance, string serialNumber)
        {
            return true;
        }

        /// <summary>
        /// Check if a Serial Number exists at the ERP System
        /// </summary>
        /// <param name="skuCode">SKU Code</param>
        /// <param name="serialNumber">Serial Number</param>
        /// <param name="warehouse">Warehoiuse Code</param>
        /// <returns></returns>
        public bool CheckSerialNumberInERP(string skuCode, string serialNumber, string warehouse)
        {
            return true;
        }

        /// <summary>
        /// Occurs when a Serial Number is Reused. ReUse SerialNumber Option.
        /// </summary>
        /// <param name="oldSerialNumber">Old SerialNumber Object</param>
        /// <param name="reutSerialNumber">New SerialNumber Object</param>
        /// <returns></returns>
        public object CreateAbateTask(object oldSerialNumber, object reutSerialNumber)
        {
            return reutSerialNumber;
        }

        /// <summary>
        /// Occurs when a Serial Number is Reused.
        /// </summary>
        /// <param name="sn">Object containing the SerialNUmber to be Reused.</param>
        /// <returns>Returns a boolean indicating if the Serial Number can be reused.</returns>
        public string GetReutSerialNumber(object sn)
        {
            GlobalSist.Logic.SKULogic.SerialNumber serialNum = (GlobalSist.Logic.SKULogic.SerialNumber) sn;
            return serialNum.Serial;
        }

        /// <summary>
        /// Occors when a Serial number is promoted to Principal. Promote to Principal Option
        /// </summary>
        /// <param name="reutSN"></param>
        /// <param name="promotedSN"></param>
        public void SerialNumberPromoted(object reutSN, object promotedSN)
        {
        }
    }
}
