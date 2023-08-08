using FluentValidation;

namespace MYMANGAS.DOMAIN.Commands.Validations
{
    public class DeleteMangaValidation : AbstractValidator<DeleteMangaCommand>
    {
        public DeleteMangaValidation()
        {
            ValidateMangaId();
        }

        protected void ValidateMangaId()
        {         
        }
    }
}
