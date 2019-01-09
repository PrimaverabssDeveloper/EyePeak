using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalSist.WMS.ERPExample.Integration
{
    public class Configuration : GlobalSist.WMS.Integration.IntegrationJobInterface
    {
        string _ConnectionString { get; set; }
        //Nullable<DateTime> anchorDate = null;

        public void Init()
        {
        }

        /// <summary>
        /// Run the Syncronization Process
        /// </summary>
        /// <param name="anchor">Initial Date for the Syncronization Process</param>
        /// <param name="anchorDate">Date of the Last document syncronized successfully</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool Run(ref string anchor, ref DateTime? anchorDate)
        {

            return true;
        }

        /// <summary>
        /// Set Up the Syncronization Process
        /// </summary>
        /// <param name="connectionString">Connection String to acces the ERP DataBase</param>
        /// <param name="company">ERP Company Name</param>
        /// <param name="username">Username to access the ERP Company</param>
        /// <param name="password">Password to Access the ERP Company</param>
        /// <param name="ERP_INSTANCE">ERP Intance</param>
        /// <param name="ERP_PLATFORMTYPE">ERP Platform Type</param>
        public void Setup(string connectionString, string company, string username, string password, string ERP_INSTANCE, string ERP_PLATFORMTYPE)
        {
            _ConnectionString = connectionString;

            //Service Registration
            GlobalSist.ServiceProvider.ServiceManager.AddRegister<DocExtension, Facades.DocLogic.IDoc>();
            GlobalSist.ServiceProvider.ServiceManager.AddRegister<BatchExtension, Facades.SKULogic.IBatchFacade>();
            GlobalSist.ServiceProvider.ServiceManager.AddRegister<InventoryExtension, Facades.TaskLogic.IInventory>();
            GlobalSist.ServiceProvider.ServiceManager.AddRegister<SerialNumberExtension, Facades.SKULogic.ISerialNumberFacade>();

        }


        #region IntegrationJobInterface Members

        public WMS.Integration.IntegrationExtension ERP
        {
            //Put here the ERP configured on Eye Peak Params
            get { return WMS.Integration.IntegrationExtension.PRIMAVERA; }
        }

        public Facades.DocLogic.IDoc DocFacade
        {
            get { return new DocExtension(); }
        }

        public Facades.SKULogic.IBatchFacade BatchFacade
        {
            get { return new BatchExtension(); }
        }

        public Facades.SKULogic.ISerialNumberFacade SerialNumberFacade
        {
            get { return new SerialNumberExtension(); }
        }

        public Facades.TaskLogic.IInventory InventoryFacade
        {
            get { return new InventoryExtension(); }
        }
        #endregion
    }
}
