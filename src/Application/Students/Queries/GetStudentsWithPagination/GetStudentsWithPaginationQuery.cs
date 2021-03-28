using clen_code_project.Application.Common.Models;
using clen_code_project.Application.TodoLists.Queries.GetTodos;
using clen_code_project.Domain.Entities;
using MediatR;

namespace clen_code_project.Application.Students.Queries.GetStudentsWithPagination
{
    public class GetStudentsWithPaginationQuery : IRequest<PaginatedList<Student>>
    {
        public string Name { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
