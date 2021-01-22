using System;
using System.Collections.Generic;
using System.Text;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.Platform.Core.Events
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class IntegrationEventBase<TEntity> : Entity, IEvent
    {
        protected readonly Dictionary<string, object> _metaInfo;

        protected IntegrationEventBase(TEntity entity)
        {
            Id = Guid.NewGuid().ToString();
            TimeStamp = DateTime.UtcNow;
            _metaInfo = new Dictionary<string, object>();
            Entity = entity;
        }

        protected IntegrationEventBase(Dictionary<string, object> metaInfo)
        {
            _metaInfo = metaInfo;
        }

        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        /// <summary>
        /// Related entity with this event.
        /// </summary>
        public TEntity Entity { get; }

        public virtual IntegrationEventBase<TEntity> AddMetaInfo(string name, object data)
        {
            _metaInfo.Add(name, data);
            return this;
        }

        public virtual object GetMetaInfo(string name)
        {
            return _metaInfo.GetValueOrDefault(name);
        }

        public object ModuleId
        {
            get => _metaInfo.GetValueOrDefault(EventMetaInfoType.ModuleId);
            set => _metaInfo[EventMetaInfoType.ModuleId] = value;
        }
    }

    public static class IntegrationEventExtension
    {
        public static IntegrationEventBase<TEvent> AddModuleId<TEvent>(this IntegrationEventBase<TEvent> @event, string moduleId)
        {
            return @event.AddMetaInfo(EventMetaInfoType.ModuleId, moduleId);
        }
    }
}
