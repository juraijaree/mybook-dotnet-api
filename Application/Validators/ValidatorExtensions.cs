using FluentValidation;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(8).WithMessage("Password must be at least 8 characters.")
                .Matches("[A-Z]").WithMessage("Password must contain uppercase character.")
                .Matches("[a-z]").WithMessage("Password must contain lowercase character.")
                .Matches("[0-9]").WithMessage("Password must contain a number.")
                .Matches("[^A-Za-z0-9]").WithMessage("Password must contain non-alphanumeric character.");

            return options;
        }
    }
}
