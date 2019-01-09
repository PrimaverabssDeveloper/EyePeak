using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalSist.WMS.ERPExample.Integration
{
    internal class DocExtension : Facades.DocLogic.IDoc
    {
        #region IDoc Members

        /// <summary>
        /// Occurs when the document is closed
        /// </summary>
        /// <param name="doc">Doc Object</param>
        public void OnDocClosed(object doc)
        {
            this.OnDocExport(doc);
        }

        /// <summary>
        /// Occurs when the document is canceled or all the lines are removed
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <returns>Returns an Object of Type Report. If the object is not empy the operation can be canceled and throw back an error message to the user</returns>
        public Facades.Base.Report OnDocCanceled(object doc)
        {
            //In this example we will return an error message to the user
            Facades.Base.Report response = new Facades.Base.Report();
            Facades.Base.Information info = new Facades.Base.Information();

            info.Type = Facades.Base.InformationType.Error;
            info.Message = "It is not possible to cancel the document";

            response.AddInformation(info);

            return response;
        }

        /// <summary>
        /// Occurs when the document is exported
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool OnDocExport(object doc)
        {
            // On this example, write a new file on disk
            string text = "OnDocExport";
            System.IO.File.WriteAllText(@"C:\OnDocClosing.txt", text);

            //test
            //Write your code here
            return true;
        }

        /// <summary>
        /// Occurs when a new line is added to the document on the Front-End
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <param name="lineNumber">Number of the added line</param>
        /// <returns>Returns an Object of Type Report. If the object is not empy the operation can be canceled and throw back an error message to the user</returns>
        public Facades.Base.Report OnDocDetailAdding(object doc, int? lineNumber)
        {
            //In this example we will return an error message to the user
            Facades.Base.Report response = new Facades.Base.Report();
            Facades.Base.Information info = new Facades.Base.Information();

            info.Type = Facades.Base.InformationType.Error;
            info.Message = "It was not possible to add the new line to the document.";

            response.AddInformation(info);

            return response;
        }

        /// <summary>
        /// Occurs when the document is being closed
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool OnDocClosing(object doc)
        {

            return true;

        }

        /// <summary>
        /// Occurs when the document is being created based on a other document
        /// </summary>
        /// <param name="doc">Document to be created</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool OnDocTransformed(object doc)
        {
            return true;
        }

        /// <summary>
        /// Occurs when a new line is removed from the document. Only fires for documents which come from the ERP
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <param name="line">ID of the line in the ERP (ERPDocDetailID field, set in the documento creation process)</param>
        /// <returns>Returns a Boolean which indicates if the operation occured successfully or not</returns>
        public bool OnDocLineDeleted(object doc, string line)
        {
            return true;
        }

        /// <summary>
        /// Occurs when a composition is created
        /// </summary>
        /// <param name="doc">Doc Object</param>
        /// <param name="warehouseCode">Warehouse Code</param>
        /// <param name="skus">List of SKU codes</param>
        /// <returns></returns>
        public bool OnCreateComposition(object doc, string warehouseCode, Dictionary<string, decimal> skus)
        {
            return true;
        }

        /// <summary>
        /// Indicates if a document is allowed to be ReExported
        /// </summary>
        public bool AllowReExport()
        {
            return true;
        }
        #endregion
    }
}
