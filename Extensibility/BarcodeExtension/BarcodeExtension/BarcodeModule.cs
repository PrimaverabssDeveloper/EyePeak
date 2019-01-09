using GlobalSist.Common;

namespace BarcodeExtension
{
    public class BarcodeModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeModule"/> class.
        /// </summary>
        public BarcodeModule() : base("Extensão para Códigos de Barras")
        {
            this.IsLogic = true;
            this.IsTerminal = false;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Init()
        {
            ///This method allows:
            ///Required components initialization
            ///Extensions registration
        }
    }
}
