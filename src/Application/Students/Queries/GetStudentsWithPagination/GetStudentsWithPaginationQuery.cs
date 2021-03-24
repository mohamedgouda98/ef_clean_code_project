using AutoMapper;
using AutoMapper.QueryableExtensions;
using clen_code_project.Application.Common.Interfaces;
using clen_code_project.Application.Common.Mappings;
using clen_code_project.Application.Common.Models;
using clen_code_project.Application.TodoLists.Queries.GetTodos;
using clen_code_project.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace clen_code_project.Application.TodoItems.Queries.GetTodoItemsWithPagination
{
    public class GetStudentsWithPaginationQuery : IRequest<PaginatedList<Student>>
    {
        public string Name { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetStudentsWithPaginationQueryHandler : IRequestHandler<GetStudentsWithPaginationQuery, PaginatedList<Student>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetStudentsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<Student>> Handle(GetStudentsWithPaginationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students
                .Where(x => x.Name == request.Name)
                .OrderBy(x => x.Email)
                .ProjectTo<Student>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize); ;
        }

        
    }
}
