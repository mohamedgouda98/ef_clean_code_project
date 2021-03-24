using clen_code_project.Application.Common.Mappings;
using clen_code_project.Domain.Entities;

namespace clen_code_project.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
