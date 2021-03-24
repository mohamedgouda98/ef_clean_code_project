using clen_code_project.Application.Students.Commands.CreateStudent;
using FluentValidation;

namespace clen_code_project.Application.TodoItems.Commands.CreateTodoItem
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(s => s.Name)
                .MaximumLength(200)
                .NotEmpty();

            RuleFor(s => s.Email)
               .MaximumLength(200)
               .NotEmpty();

            RuleFor(s => s.Password)
               .MaximumLength(200)
               .NotEmpty();
        }
    }
}
