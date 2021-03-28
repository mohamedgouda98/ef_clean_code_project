using clen_code_project.Application.Common.Exceptions;
using clen_code_project.Application.Common.Interfaces;
using clen_code_project.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace clen_code_project.Application.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Students.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Student), request.Id);
            }

            entity.Name = request.Name;
            entity.Email = request.Email;
            entity.Password = request.Password;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
