using GlobalSist.Common;

namespace UserInterfaceExtension
{
    public class UserInterfaceModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFormApp7Modules"/> class.
        /// </summary>
        public UserInterfaceModule()
            : base("Extensibilidade de User Interface")
        {
            this.IsLogic = false;
            this.IsTerminal = false; /// False for Frontend Form Extension, True for Terminal Form extension
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
