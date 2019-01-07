using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync.WMS
{
    public partial class FormSyncWMS : Form
    {
        public FormSyncWMS()
        {
            InitializeComponent();
        }

        private void btnAddSKU_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKU SKU = new Sync.WMS.SKU();
            SKU.Add();
        }

        private void btnChangeSKU_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKU SKU = new Sync.WMS.SKU();
            SKU.Change();
        }

        private void btnRemoveSKU_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKU SKU = new Sync.WMS.SKU();
            SKU.Remove();
        }

        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            Sync.WMS.Entity Entity = new Sync.WMS.Entity();
            Entity.Add();
        }

        private void btnChangeEntity_Click(object sender, EventArgs e)
        {
            Sync.WMS.Entity Entity = new Sync.WMS.Entity();
            Entity.Change();
        }

        private void btnRemoveEntity_Click(object sender, EventArgs e)
        {
            Sync.WMS.Entity Entity = new Sync.WMS.Entity();
            Entity.Remove();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            Sync.WMS.Warehouse Warehouse = new Sync.WMS.Warehouse();
            Warehouse.Add();
        }

        private void btnChangeWarehouse_Click(object sender, EventArgs e)
        {
            Sync.WMS.Warehouse Warehouse = new Sync.WMS.Warehouse();
            Warehouse.Change();
        }

        private void btnRemoveWarehouse_Click(object sender, EventArgs e)
        {
            Sync.WMS.Warehouse Warehouse = new Sync.WMS.Warehouse();
            Warehouse.Remove();
        }

        private void btnAddDocDefinition_Click(object sender, EventArgs e)
        {
            Sync.WMS.DocDefinition DocDefinition = new Sync.WMS.DocDefinition();
            DocDefinition.Add();
        }

        private void btnChangeDocDefinition_Click(object sender, EventArgs e)
        {
            Sync.WMS.DocDefinition DocDefinition = new Sync.WMS.DocDefinition();
            DocDefinition.Change();
        }

        private void btnRemoveDocDefinition_Click(object sender, EventArgs e)
        {
            Sync.WMS.DocDefinition DocDefinition = new Sync.WMS.DocDefinition();
            DocDefinition.Remove();
        }

        private void btnAddSKUGroup_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUGroup SKUGroup = new Sync.WMS.SKUGroup();
            SKUGroup.Add();
        }

        private void btnChangeSKUGroup_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUGroup SKUGroup = new Sync.WMS.SKUGroup();
            SKUGroup.Change();
        }

        private void btnRemoveSKUGroup_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUGroup SKUGroup = new Sync.WMS.SKUGroup();
            SKUGroup.Remove();
        }

        private void btnAddSKUClass_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUClass SKUClass = new Sync.WMS.SKUClass();
            SKUClass.Add();
        }

        private void btnChangeSKUClass_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUClass SKUClass = new Sync.WMS.SKUClass();
            SKUClass.Change();
        }

        private void btnRemoveSKUClass_Click(object sender, EventArgs e)
        {
            Sync.WMS.SKUClass SKUClass = new Sync.WMS.SKUClass();
            SKUClass.Remove();
        }

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            Sync.WMS.Operators Operator = new Sync.WMS.Operators();
            Operator.Add();
        }

        private void btnChangeOperator_Click(object sender, EventArgs e)
        {
            Sync.WMS.Operators Operator = new Sync.WMS.Operators();
            Operator.Change();
        }

        private void btnChangeCompany_Click(object sender, EventArgs e)
        {
            Sync.WMS.Company Company = new Sync.WMS.Company();
            Company.Change();
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Add();
        }

        private void btnChangeDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Change();
        }

        private void btnRemoveDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Remove();
        }

        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Edit();
        }

        private void btnCancelDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Cancel();
        }

        private void btnCloseDocument_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.Close();
        }

        private void btnCreatePicking_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.CreatePickingByContainer();
        }

        private void btnDocumentsWithDivergencies_Click(object sender, EventArgs e)
        {
            Sync.WMS.Documents Document = new Sync.WMS.Documents();
            Document.ListDocumentListWithDivergencies();
        }

        private void btnBlockContainer_Click(object sender, EventArgs e)
        {
            Sync.WMS.Container Container = new Sync.WMS.Container();
            Container.BlockContainer();
        }

        private void btnUnBlockContainer_Click(object sender, EventArgs e)
        {
            Sync.WMS.Container Container = new Sync.WMS.Container();
            Container.UnBlockContainer();
        }

        private void btnGetSKUStock_Click(object sender, EventArgs e)
        {
            Sync.WMS.Stocks SKUStock = new Sync.WMS.Stocks();
            SKUStock.GetSKUStock();
        }
    }
}
