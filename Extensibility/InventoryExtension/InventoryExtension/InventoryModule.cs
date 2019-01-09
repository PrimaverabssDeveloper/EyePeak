using GlobalSist.Common;

namespace InventoryExtension
{
    public class InventoryModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryModule"/> class.
        /// </summary>
        public InventoryModule() : base("Extensibilidade de Inventário")
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
