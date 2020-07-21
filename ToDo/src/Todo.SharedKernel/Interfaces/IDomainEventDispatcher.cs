using System.Threading.Tasks;
using Todo.SharedKernel;

namespace Todo.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}