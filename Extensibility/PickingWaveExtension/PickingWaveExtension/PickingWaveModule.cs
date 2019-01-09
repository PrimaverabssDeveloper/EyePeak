using GlobalSist.Common;

namespace PickingWaveExtension
{
    public class PickingWaveModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PickingWaveModule"/> class.
        /// </summary>
        public PickingWaveModule() : base("Extensibilidade de Onda de Picking")
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
