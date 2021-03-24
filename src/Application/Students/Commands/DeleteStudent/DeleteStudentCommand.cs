using MediatR;

namespace clen_code_project.Application.Students.Commands.DeleteTodoItem
{
    public class DeleteStudentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
