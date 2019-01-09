using GlobalSist.Facades.Base;
using GlobalSist.Facades.DocLogic;
using System;
using System.Collections.Generic;

namespace DocExtension
{
    public class DocExt : IDoc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocExt"/> class.
        /// </summary>
        public DocExt()
        {
        }

        /// <summary>
        /// Allows the re export.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool AllowReExport()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [create composition].
        /// </summary>
        /// <param name="doc">
        /// The document.
        /// </param>
        /// <param name="warehouseCode">
        /// The warehouse code.
        /// </param>
        /// <param name="skus">
        /// The skus.
        /// </param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnCreateComposition(object doc, string warehouseCode, Dictionary<string, decimal> skus)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document canceled].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Report OnDocCanceled(object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document closed].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnDocClosed(object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document closing].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnDocClosing(object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document detail adding].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="lineNumber">The line number.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Report OnDocDetailAdding(object doc, int? lineNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document export].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnDocExport(object doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document line deleted].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="Line">The line.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnDocLineDeleted(object doc, string Line)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [document transformed].
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnDocTransformed(object doc)
        {
            throw new NotImplementedException();
        }
    }
}
