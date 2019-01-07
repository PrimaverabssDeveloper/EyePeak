using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public class Documents
    {
        private WMSDataImportClient m_WSClient;

        public Documents()
        {
            m_WSClient = Utils.WS_CLIENT();
        }

        public void Add()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //Required Fields
            wsEntity.DocSeries = "VGR";
            wsEntity.DocNum = 52;
            wsEntity.WarehouseCode = "A1";
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.EntityCode = "0280";

            //This field is essential. Eye Peak wil search for the document by the following fields
            wsEntity.ERPDocID = wsEntity.DocSeries + wsEntity.DocNum.ToString();

            //Linhas do documento
            DocDetail[] docLines = new DocDetail[1];
            docLines[0] = new WMSDataImportWS.DocDetail();
            docLines[0].SKU = "2000000027";
            docLines[0].Qty = 10;
            docLines[0].DocLineNum = 1;
            docLines[0].Warehouse = "A1";
            docLines[0].ERPProductCode = "ERPProductCode";

            docLines[0].PreparationDate = DateTime.Now;
            docLines[0].ContainerQty = 1;

            //Set the lines to the document
            wsEntity.DocLines = docLines;

            //Saving
            object result;
            result = m_WSClient.SaveDoc(wsEntity);
        }

        public void Change()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //This field is essential. Eye Peak wil search for the document by the following fields
            wsEntity.ERPDocID = "VGT/2018" + "70";
            wsEntity.ERPCompany = "DEMOWMS510";

            //Required Fields
            wsEntity.DocSeries = "VGT/2018";
            wsEntity.DocNum = 70;
            wsEntity.WarehouseCode = "A1";
            wsEntity.ERPCompany = "DEMOWMS";
            wsEntity.EntityCode = "F0001";
            wsEntity.Active = true;

            //Documetn Lines
            DocDetail[] docLines = new DocDetail[1];
            docLines[0] = new WMSDataImportWS.DocDetail();
            docLines[0].SKU = "A0001";
            docLines[0].Qty = 20;
            docLines[0].DocLineNum = 1;
            docLines[0].Warehouse = "A1";

            docLines[0].PreparationDate = DateTime.Now;
            docLines[0].ContainerQty = 1;

            //This field is essential. Eye Peak will search the lines by this field
            docLines[0].ERPDocDetailID = wsEntity.ERPDocID + "1";

            //Set the lines to the document
            wsEntity.DocLines = docLines;

            //Saving
            object result;
            result = m_WSClient.SaveDoc(wsEntity);
        }

        public void Remove()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //This field is essential. Eye Peak wil search for the document by the following fields
            wsEntity.DocSeries = "VGR";
            wsEntity.DocNum = 68;
            wsEntity.ERPCompany = "DEMOWMS510";

            object result;
            result = m_WSClient.DeleteDoc(wsEntity);
        }

        public void Cancel()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //This field is essential. Eye Peak will do the search of the exsiting document by this Identifier which was sent at the time of the documento was addded
            wsEntity.ERPDocID = "{A9AF7F86-A6A5-11E6-9BEE-000C29C4601C}";

            //Required Fields
            wsEntity.DocSeries = "ECF/2016";
            wsEntity.DocNum = 12;
            wsEntity.WarehouseCode = "A1";
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.Active = false;

            //Saving
            object result;
            result = m_WSClient.SaveDoc(wsEntity);
        }

        public void Close()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.CloseDocRequest wsEntity = new CloseDocRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";
            wsEntity.DocID = 57;

            //Query to obtain the DocID for the document ECF/2016 with the number 12:

            /*
             * SELECT D.DocID FROM T_WMS_DOC D
             * INNER JOIN T_WMS_DOCDEFINITION DF ON DF.DocDefID = D.DocDefID
             * WHERE DF.DocSeries = 'ECF/2016' AND D.DocNum = 12
             */

            //Saving
            object result;
            result = m_WSClient.CloseDoc(wsEntity);
        }


        public void Edit()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //Required Fields
            wsEntity.DocID = 3198;
            wsEntity.ERPCompany = "TesteEyePeak";

            //Edit
            object result;
            result = m_WSClient.EditDocID(wsEntity);
        }




        public void CreatePickingByContainer()
        {
            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocRequest wsEntity = new DocRequest();

            //Required Fields
            wsEntity.ERPCompany = "DEMOWMS510";

            //Saving
            object result;
            result = m_WSClient.CreatePickingByContainer(wsEntity, 3174, 33, "999999999990");
        }


        public void ListDocumentListWithDivergencies()
        {

            // Web Service of the Entity to be used
            Sync.WMS.WMSDataImportWS.DocListRequest wsEntity = new DocListRequest();

            //Possible Fields
            wsEntity.ERPCompany = "TesteEyePeak";
            //wsEntity.IncludePending = true;
            //wsEntity.IncludeStart = true;
            wsEntity.IncludeToConfirm = true;
            //wsEntity.IncludeClosed = true;
            //wsEntity.IncludeCancel = true;
            //wsEntity.IncludeExport = true;
            //wsEntity.DocSeries = "VGR";
            //wsEntity.DocMinNum = 188;
            //wsEntity.DocMaxNum = 190;
            //wsEntity.EntityCode = "";
            //wsEntity.WarehouseCode = "";
            //wsEntity.DocMinDate = null;
            //wsEntity.DocMaxDate = null;
            //wsEntity.ERPDocID = "";
            //wsEntity.IncludeZeroConfirmedQtyLines = true;

            //Saving
            object result;
            result = m_WSClient.GetDocListWithDivergencies(wsEntity);
        }
    }
}
