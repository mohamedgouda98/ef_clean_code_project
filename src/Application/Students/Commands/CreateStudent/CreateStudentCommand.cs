using clen_code_project.Domain.Events;
using MediatR;

namespace clen_code_project.Application.Students.Commands.CreateStudent
{
    public class CreateStudentCommand : IRequest<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
