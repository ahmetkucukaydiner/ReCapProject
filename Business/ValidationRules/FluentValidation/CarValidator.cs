using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(3);
            RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.Description).Must(StartWithA).WithMessage("Araç açıklaması A harfi ile başlamalı.");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
