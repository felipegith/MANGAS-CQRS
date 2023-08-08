using FluentValidation;

namespace MYMANGAS.DOMAIN.Commands.Validations
{
    public class UpdateMangaValidation : AbstractValidator<UpdateMangaCommand> 
    {
        public UpdateMangaValidation()
        {
            RuleFor(c => c.Name)
                    .NotEmpty().WithMessage("Please ensure you have entered the Name")
                    .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }
    }
}
