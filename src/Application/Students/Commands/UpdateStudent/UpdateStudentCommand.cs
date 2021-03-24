using MediatR;

namespace clen_code_project.Application.Students.Commands.UpdateTodoItem
{
    public class UpdateStudentCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
