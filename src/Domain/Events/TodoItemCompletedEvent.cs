using clen_code_project.Domain.Common;
using clen_code_project.Domain.Entities;

namespace clen_code_project.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
