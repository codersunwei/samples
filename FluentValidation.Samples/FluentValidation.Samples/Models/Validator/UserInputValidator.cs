using FluentValidation.Samples.Models.Input;

namespace FluentValidation.Samples.Models.Validator
{
    public class UserInputValidator : AbstractValidator<UserInput>
    {
        public UserInputValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage($"{nameof(UserInput.Name)} 不能为空。").MaximumLength(3).WithMessage($"{nameof(UserInput.Name)} 长度不能超过三个字符");
            RuleFor(t => t.Age).NotNull().WithMessage($"{nameof(UserInput.Age)} 不能为空。").InclusiveBetween(18, 55).WithMessage($"{nameof(UserInput.Age)} 取值范围必须在18~55之间。");
            RuleFor(t => t.Gender).NotNull().WithMessage($"{nameof(UserInput.Gender)} 不能为空。");
            RuleFor(t => t.Email).IsInEnum().WithMessage($"{nameof(UserInput.Email)} 不是合法的邮箱地址");
            RuleFor(t => t.UserState).IsInEnum().WithMessage($"{nameof(UserInput.UserState)} 取值不合法。");
            RuleFor(t => t.Pictures).NotNull().WithMessage($"{nameof(UserInput.Pictures)} 不可为空。");
        }
    }
}
