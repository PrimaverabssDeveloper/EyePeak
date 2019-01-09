using GlobalSist.Common;
using GlobalSist.Server.Jobs;
using System;

namespace GlobalSist.JobExtension.Job
{
    public class JobExample : BaseJob
    {

        #region --- Variables ---
        /// <summary>
        /// The job name
        /// </summary>
        public const string JOB_NAME = "Example Job";
        /// <summary>
        /// Is Job running
        /// </summary>
        private bool _running = false;
        #endregion --- Variables ---

        /// <summary>
        /// Initializes a new instance of the <see cref="JobExample"/> class.
        /// </summary>
        public JobExample()
        {
            this.Interval = 60; /// Elapsed time between runs in miliseconds
            this.jobName = JOB_NAME; /// The Job Name
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override bool Run()
        {
            if (this._running)
                return true;

            try
            {
                this._running = true;
                foreach (var databaseCfg in AppConfig.RunningConfig.AvailableDatabases)
                {
                    ///Implement actions needed
                }
            }
            finally
            {
                this._running = false;
            }

            return true;

        }
    }
}
