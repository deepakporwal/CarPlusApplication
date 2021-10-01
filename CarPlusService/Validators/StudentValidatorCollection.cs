using Common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlusService.Validators
{
    public class StudentValidatorCollection : AbstractValidator<StudentData>
    {
        public StudentValidatorCollection()
        {
            RuleFor(Student => Student.FirstName).NotEmpty().WithMessage("Enter First Name")
                 .NotNull().WithMessage("First name is not null");
            RuleFor(Student => Student.LastName).NotEmpty().WithMessage("Enter Last Name")
                .NotNull().WithMessage("Last name is not null");
        }
    }
}
