namespace VirtoCommerce.Platform.Core.Events
{
    public class ChangingIntegrationEvent<TEntity> : IntegrationEventBase<TEntity>
    {
        public ChangingIntegrationEvent(TEntity entity)
            : base(entity)
        {
        }
    }
}
