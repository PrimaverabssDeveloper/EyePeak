using GlobalSist.DataAccess.Entities;

namespace AnyTablePersistDataExtension
{
    public class PersistDataExt : T_WMS_SKU
    {
        /// <summary>
        /// Called when [before insert].
        /// </summary>
        protected override void OnBeforeInsert()
        {
            base.OnBeforeInsert();
        }

        /// <summary>
        /// Called when [before update].
        /// </summary>
        protected override void OnBeforeUpdate()
        {
            base.OnBeforeUpdate();
        }

        /// <summary>
        /// Called when [before delete].
        /// </summary>
        protected override void OnBeforeDelete()
        {
            base.OnBeforeDelete();
        }

        /// <summary>
        /// Called when [after insert].
        /// </summary>
        protected override void OnAfterInsert()
        {
            base.OnAfterInsert();
        }

        /// <summary>
        /// Called when [after update].
        /// </summary>
        protected override void OnAfterUpdate()
        {
            base.OnAfterUpdate();
        }

        /// <summary>
        /// Called when [refresh].
        /// </summary>
        protected override void OnRefresh()
        {
            base.OnRefresh();
        }
    }
}
