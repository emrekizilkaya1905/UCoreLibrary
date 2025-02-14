using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidator
{
	public class CustomerValidator:AbstractValidator<Customer>
	{
		public string NotEmptyMessage { get; } = "{PropertyName} alani bos birakilamaz";
		public CustomerValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage(NotEmptyMessage);

			RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).
			EmailAddress().WithMessage("Email alani dogru formatta olmalidir.");

			RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).
			InclusiveBetween(18, 60).WithMessage("Age alani 18 ile 60 arasinda olmalidir");

			RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
			{
				return DateTime.Now.AddYears(-18) >= x;
			}).WithMessage("Yasiniz 18 yasindan buyuk olmalidir.");
			RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} alani Erkek=1, Bayan=2 degeri almalidir");

			RuleForEach(x=>x.Adresses).SetValidator(new AdressValidator());	
		}
	}
}
