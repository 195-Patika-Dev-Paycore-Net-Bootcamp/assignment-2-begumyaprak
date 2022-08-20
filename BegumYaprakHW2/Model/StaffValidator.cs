using System;
using System.Text.RegularExpressions;
using System.Transactions;
using FluentValidation;
using FluentValidation.Validators;

namespace BegumYaprakHW2.Model

{


    public class StaffValidator:AbstractValidator<Staff>
	{

		public StaffValidator()
		{
            RuleFor(a => a.Id)
           .NotEmpty()
           .WithMessage("Id boş olamaz");

            RuleFor(a => a.Name).NotEmpty().WithMessage("İsim boş olamaz").Length(3, 120);
            RuleFor(a => a.Lastname).NotEmpty().WithMessage("Soyisim boş olamaz").Length(3, 120);

            RuleFor(a => a.Salary).NotEmpty().WithMessage("Gelir boş olamaz").GreaterThan(2000).LessThan(9000);

            RuleFor(a => a.Email).EmailAddress();

            
        }
        

    }




}

