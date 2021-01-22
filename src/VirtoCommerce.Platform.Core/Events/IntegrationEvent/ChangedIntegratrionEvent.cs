namespace VirtoCommerce.Platform.Core.Events
{
    public class ChangedIntegratrionEvent<TEntity> : IntegrationEventBase<TEntity>
    {
        public ChangedIntegratrionEvent(TEntity entity)
            : base(entity)
        {
        }
    }
}
