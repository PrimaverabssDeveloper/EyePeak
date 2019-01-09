using System;
using System.Collections.Generic;
using System.Text;
using GlobalSist.Logic.TaskLogic;
using System.Linq;
using GlobalSist.Logic.PickingLogic;
using GlobalSist.Logic.DocLogic;

namespace PickingRoute
{
    public class Pickingroute : IPickingRoute
    {
        /// <summary>
        /// Stores the document
        /// </summary>
        GlobalSist.Logic.DocLogic.Doc _doc;

        /// <summary>
        /// Receive the document
        /// </summary>
        /// <param name="doc"></param>
        public void SetDocument(GlobalSist.Logic.DocLogic.Doc doc)
        {
            this._doc = doc;
        }

        /// <summary>
        /// Change picking route of all tasks
        /// </summary>
        public void Process()
        {
            try
            {
                if (!_doc.Warehouse.UsesRoutes)
                    return;

                var ops = Operation.GetAllFromDoc(_doc.DocID);
                if (ops == null)
                    return;

                ops = ops.Where(op => op.OperationStatus != OperationStatusEnum.CANCEL && op.OperationStatus != OperationStatusEnum.FINISHED).ToArray();
                if (ops == null)
                    return;

                using (var t = GlobalSist.DataAccess.Database.MyTranscationScope.GetNewTransaction())
                {
                    foreach (var op in ops)
                    {
                        Task[] allTasks = op.Tasks;
                        if (allTasks == null)
                            continue;
                        var tasks = allTasks.Where(task => task.TaskType == TaskTypeEnum.PICK && (task.TaskStatus == TaskStatusEnum.CREATED))
                                            .OrderBy(task => task.FromLocation.LocationCode)
                                            .ThenByDescending(task => task.FromContainer?.ContainerReserve?.ContainerReservationID ?? 0)
                                            .ThenBy(task => task.FromContainerCode)
                                            .ToList();

                        int i = 1;
                        foreach (var iterTask in tasks)
                        {
                            iterTask.Sequence = i;
                            iterTask.Update();
                            i++;
                        }
                    }
                    t.Complete();
                }
            }
            finally
            {
                this.IsComplete = true;
            }
        }

        /// <summary>
        /// Return True when is finished
        /// </summary>
        public bool IsComplete
        {
            get;
            private set;
        }
    }
}
