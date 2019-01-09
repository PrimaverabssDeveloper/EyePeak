using GlobalSist.Facades.Label;
using System;
using System.Collections.Generic;

namespace LabelExtention
{
    class LabelExt : ILabel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelExt"/> class.
        /// </summary>
        public LabelExt()
        {
        }

        /// <summary>
        /// Adds the extra detail fields to print.
        /// </summary>
        /// <param name="lbl">
        /// The label.
        /// </param>
        /// <param name="detail">
        /// The detail.
        /// </param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddExtraDetailFieldsToPrint(object lbl, object detail)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the extra expedition fields to print.
        /// </summary>
        /// <param name="lbl">
        /// The label.
        /// </param>
        /// <param name="doc">
        /// The document.
        /// </param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddExtraExpeditionFieldsToPrint(object lbl, object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the extra storage fields to print.
        /// </summary>
        /// <param name="lbl">
        /// The label.
        /// </param>
        /// <param name="doc">
        /// The document.
        /// </param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddExtraStorageFieldsToPrint(object lbl, object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the labels.
        /// </summary>
        /// <param name="EntityID">
        /// The entity identifier.
        /// </param>
        /// <param name="skuCode">
        /// The sku code.
        /// </param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<object> LoadLabels(int EntityID, string skuCode)
        {
            throw new NotImplementedException();
        }
    }
}
