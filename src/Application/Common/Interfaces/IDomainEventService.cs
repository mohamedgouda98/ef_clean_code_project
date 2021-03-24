using clen_code_project.Domain.Common;
using System.Threading.Tasks;

namespace clen_code_project.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
