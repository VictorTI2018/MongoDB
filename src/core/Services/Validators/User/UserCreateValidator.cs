using Domain.Entities;
using FluentValidation;

namespace Services.Validators.User
{
    public class UserCreateValidator : AbstractValidator<UserEntity>
    {
        public UserCreateValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithMessage(u => $"Campo {nameof(u.Name)} é obrigatório.");

            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage(u => $"Campo {nameof(u.Email)} é obrigatório.");

            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage(u => $"Campo {nameof(u.Password)} é obrigatório.");
        }
    }
}
