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
            RuleFor(c => c.Password).MinimumLength(8);
            RuleFor(c => c.FirstName).NotNull();
            RuleFor(c => c.LastName).NotNull();
            RuleFor(c => c.Password).NotNull();
            RuleFor(c => c.EMail).NotNull();

        }
    }
}
