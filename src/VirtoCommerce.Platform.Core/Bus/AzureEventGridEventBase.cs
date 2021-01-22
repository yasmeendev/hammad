using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VirtoCommerce.Platform.Core.Events;

namespace VirtoCommerce.Platform.Core.Bus
{
    public class AzureEventGridEventBase : EventBusBase
    {
        public override async Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default)
        {
            if (!EventSuppressor.EventsSuppressed && _routes.TryGetValue(@event.GetType(), out var handlers))
            {
                await Task.WhenAll(handlers.Select(handler => handler(@event, cancellationToken)));
            }
        }
    }
}
