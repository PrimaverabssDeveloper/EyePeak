using GlobalSist.Common;

namespace AnyTablePersistDataExtension
{
    public class PersistDataModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersistDataModule"/> class.
        /// </summary>
        public PersistDataModule() : base("Extensibilidade para eventos de gravação de dados das tabelas Eye Peak")
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
