using clen_code_project.Application.Students.Commands.UpdateTodoItem;
using FluentValidation;

namespace clen_code_project.Application.TodoItems.Commands.UpdateTodoItem
{
    public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
    {
        public UpdateStudentCommandValidator()
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
