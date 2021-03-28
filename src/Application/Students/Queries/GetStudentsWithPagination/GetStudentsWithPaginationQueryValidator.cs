using FluentValidation;

namespace clen_code_project.Application.Students.Queries.GetStudentsWithPagination
{
    public class GetStudentsWithPaginationQueryValidator : AbstractValidator<GetStudentsWithPaginationQuery>
    {
        public GetStudentsWithPaginationQueryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty().WithMessage("Name is required.");

            RuleFor(x => x.PageNumber)
                .GreaterThanOrEqualTo(1).WithMessage("PageNumber at least greater than or equal to 1.");

            RuleFor(x => x.PageSize)
                .GreaterThanOrEqualTo(1).WithMessage("PageSize at least greater than or equal to 1.");
        }
    }
}
