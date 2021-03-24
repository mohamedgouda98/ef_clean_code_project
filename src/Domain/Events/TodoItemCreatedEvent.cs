using clen_code_project.Domain.Common;
using clen_code_project.Domain.Entities;

namespace clen_code_project.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
