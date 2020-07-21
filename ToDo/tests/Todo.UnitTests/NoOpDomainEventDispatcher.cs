using System.Threading.Tasks;
using Todo.SharedKernel.Interfaces;
using Todo.SharedKernel;

namespace Todo.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
