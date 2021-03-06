﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(5);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.Description).Must(StartWithA);
            RuleFor(c => c.BrandId).NotNull();
            RuleFor(c => c.ColorId).NotNull();

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
