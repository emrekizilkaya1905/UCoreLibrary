using FluentValidation;
using FluentValidationApp.Web.Models;


namespace FluentValidationApp.Web.FluentValidator
{
	public class AdressValidator : AbstractValidator<Adress>
	{
		public string NotEmptyMessage { get; } = "{PropertyName} alani bos birakilamaz";
		public AdressValidator()
		{
			RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);
			RuleFor(x => x.Province).NotEmpty().WithMessage(NotEmptyMessage);
			RuleFor(x => x.PostCode).NotEmpty().WithMessage(NotEmptyMessage)
			.MaximumLength(5).WithMessage("{PropertyName} alani {MaxLength} en fazla karakter olmalidir");
			RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);

			
		}
	}
}
