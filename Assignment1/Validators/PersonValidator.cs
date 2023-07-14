using Assignment1.Models;
using FluentValidation;

namespace Assignment1.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name Required")
                .Length(5, 50).WithMessage("Name should be at least 5 and up to 100");

            RuleFor(p => p.Lastname).NotEmpty().WithMessage("Last Name Required")
                .Length(5, 50).WithMessage("Last Name should be at least 5 and up to 100"); ;

            RuleFor(p => p.Phone).NotEmpty().WithMessage("Phone Required");

            RuleFor(p => p.AccessLevel).NotEmpty().InclusiveBetween(1, 5).WithMessage("AccessLevel should be between 1 and 5");

            RuleFor(p => p.Salary).NotEmpty().InclusiveBetween(5000, 50000).WithMessage("Salary should be between 5000 and 50000");
           
        }
    }
}
