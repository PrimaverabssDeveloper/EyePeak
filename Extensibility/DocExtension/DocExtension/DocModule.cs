using GlobalSist.Common;

namespace DocExtension
{
    public class DocModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocModule"/> class.
        /// </summary>
        public DocModule() : base("Extensibilidade de Documentos")
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
