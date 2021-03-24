using clen_code_project.Domain.Common;
using clen_code_project.Domain.ValueObjects;
using System.Collections.Generic;

namespace clen_code_project.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
