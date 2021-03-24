using clen_code_project.Application.Common.Interfaces;
using clen_code_project.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace clen_code_project.Application.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var entity = new Student
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
            };

            //entity.DomainEvents.Add(new StudentCreatedEvent(entity));

            _context.Students.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
