using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalSist.Common;

namespace PickingRoute
{
    public class PickingRouteModule : AppModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeModule"/> class.
        /// </summary>
        public PickingRouteModule() : base("Picking route module")
        {
            this.IsLogic = true;
            this.IsTerminal = false;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Init()
        {
            GlobalSist.Logic.TaskLogic.Picking.PickingRoutes.Add(new Pickingroute());
            ///This method allows:
            ///Required components initialization
            ///Extensions registration
        }
    }
}



