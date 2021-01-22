using System;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Bus;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Events;
using Xunit;

namespace VirtoCommerce.Platform.Tests.Events
{
    public class InProcessBusTests
    {
        [Fact]
        public async Task RegisterHandler_RegisterFakeHandler()
        {
            //Arrange
            var handler = new FakeEventHandler();
            var eventBus = GetEventBus();
            eventBus.RegisterHandler<ChangedIntegratrionEvent<IEntity>>((message, token) =>
            {
                message.AddModuleId("SomeModuleId");
                return handler.Handle(message);
            });
            var @event = new ChangedIntegratrionEvent<IEntity>(new FakeEntity());

            //Act
            await eventBus.PublishAsync(@event);

            //Assert
            Assert.True(handler.IsTrigged);
            Assert.Equal("SomeModuleId", @event.ModuleId);
        }

        public AzureEventGridEventBase GetEventBus()
        {
            return new AzureEventGridEventBase();
        }
    }
        
    class FakeEventHandler : IEventHandler<ChangedIntegratrionEvent<IEntity>>, IEventHandler<ChangedIntegratrionEvent<FakeEntity>>
    {
        public bool IsTrigged { get; set; }
        public Task Handle(ChangedIntegratrionEvent<IEntity> message)
        {
            IsTrigged = true;
            return Task.CompletedTask;
        }

        public Task Handle(ChangedIntegratrionEvent<FakeEntity> message)
        {
            throw new NotImplementedException();
        }
    }

    class FakeEntity : Entity { }
}
