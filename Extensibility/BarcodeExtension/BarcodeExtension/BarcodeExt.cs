using GlobalSist.Facades.Barcode;
using System;
using System.Collections.Generic;

namespace BarcodeExtension
{
    public class BarcodeExt : IBarcodeDecoder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeExt"/> class.
        /// </summary>
        public BarcodeExt()
        {
        }

        /// <summary>
        /// Decodes and return ucc ai table.
        /// </summary>
        /// <param name="barcode">
        /// The barcode.
        /// </param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Dictionary<string, string> DecodeAndReturnUCC_AITable(string barcode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Decodes and return ucc ai table.
        /// </summary>
        /// <param name="barcode">
        /// The barcode.
        /// </param>
        /// <param name="entityID">
        /// The entity identifier.
        /// </param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Dictionary<string, string> DecodeAndReturnUCC_AITable(string barcode, int entityID)
        {
            throw new NotImplementedException();
        }
    }
}
