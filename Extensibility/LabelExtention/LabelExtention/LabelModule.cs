using GlobalSist.Common;

namespace LabelExtention
{
    public class LabelModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelModule"/> class.
        /// </summary>
        public LabelModule() : base("Extensibilidade de Etiquetas")
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
