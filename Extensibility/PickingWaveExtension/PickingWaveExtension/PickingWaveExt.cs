using GlobalSist.Facades.Base;
using GlobalSist.Facades.PickingLogic;
using System;

namespace PickingWaveExtension
{
    public class PickingWaveExt : IWave
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PickingWaveExt"/> class.
        /// </summary>
        public PickingWaveExt()
        {
        }

        /// <summary>
        /// Called when [automatic wave launched].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="useTestMethod">if set to <c>true</c> [use test method].</param>
        /// <returns>returns a new instance of the <see cref="Report"/> class.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Report OnAutomaticWaveLaunched(object instance, bool useTestMethod)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [picking wave document closed].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="informationCallback">The information callback.</param>
        /// <returns>Returns true or false</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool OnPickingWaveDocumentClosed(object instance, Action<Information> informationCallback)
        {
            throw new NotImplementedException();
        }
    }
}
