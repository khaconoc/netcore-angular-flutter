using FluentValidation;

namespace Domain.Application.DanhMuc.Question.Commands.Create
{
    public class CreateQuestionCommandValidator : AbstractValidator<CreateQuestionCommandRequest>
    {
        public CreateQuestionCommandValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("Không được bỏ trống");
        }
    }
}
