using clen_code_project.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace clen_code_project.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
