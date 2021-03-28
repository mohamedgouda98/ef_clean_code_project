using AutoMapper;
using AutoMapper.QueryableExtensions;
using clen_code_project.Application.Common.Interfaces;
using clen_code_project.Application.Common.Mappings;
using clen_code_project.Application.Common.Models;
using clen_code_project.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace clen_code_project.Application.Students.Queries.GetStudentsWithPagination
{
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
