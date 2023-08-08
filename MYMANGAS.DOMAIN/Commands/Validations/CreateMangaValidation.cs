using FluentValidation;

namespace MYMANGAS.DOMAIN.Commands.Validations
{
    public class CreateMangaValidation : AbstractValidator<CreateMangaCommand> 
    {
        public CreateMangaValidation()
        {
            ValidateNameManga();
            ValidateDescriptionManga();
            ValidateRatingManga();
        }
        protected void ValidateNameManga()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidateDescriptionManga()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please ensure you have entered the Name")
                .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }

        protected void ValidateRatingManga()
        {
            RuleFor(c => c.Rating)
                .NotNull()
                .InclusiveBetween(1, 10);
        }
    }
}
