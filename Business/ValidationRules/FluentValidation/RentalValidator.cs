using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(c => c.RentDate).NotEmpty();
            RuleFor(c => c.RentDate).GreaterThan(DateTime.Today).WithMessage("Kiralama tarihi hatalı girildi!!");
            RuleFor(c => c.ReturnDate).GreaterThan(c => c.RentDate).WithMessage("Kiralama tarihi teslim tarihinden sonra olamaz !!");
        }
    }
}
