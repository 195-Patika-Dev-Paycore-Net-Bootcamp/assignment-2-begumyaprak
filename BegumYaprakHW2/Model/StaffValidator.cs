using System;
using System.Text.RegularExpressions;
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


            RuleFor(a => a.Email).EmailAddress();

            //RuleFor(a => a.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası boş olamaz")
            //.Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");
        }


    }




}

