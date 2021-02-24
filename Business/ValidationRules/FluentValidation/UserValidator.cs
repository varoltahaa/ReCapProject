using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.EMail).EmailAddress();
            RuleFor(c => c.EMail).NotNull();
            RuleFor(c => c.FirstName).NotNull();
            RuleFor(c => c.LastName).NotNull();
            RuleFor(c => c.Password).NotNull();
            RuleFor(c => c.Password).Length(8,24).WithMessage("Şifre en az 8 en fazla 24 karakter olmak zorunda");
            RuleFor(c => c.Password).Matches("[A-Z]").WithMessage("Şifre büyük harfler içermek zorunda")
                .Matches("[a-z]").WithMessage("Şifre küçük harfler içermek zorunda")
                .Matches("[0-9]").WithMessage("Şifre rakam içermek zorunda")
                .Matches("(?=.*?[.,=|;:<>+#?!@$%^&*-])").WithMessage("Şifre en az 1 tane özel karakter içermek zorunda" );

        }
    }
}
