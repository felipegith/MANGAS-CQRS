using FluentValidation;

namespace MYMANGAS.DOMAIN.Commands.Validations
{
    public class UpdateMangaReadValidation : AbstractValidator<UpdateMangaReadCommand>
    {
        public UpdateMangaReadValidation()
        {
            ValidateMangaRead();
        }

        protected void ValidateMangaRead()
        {
            
        }
    }
}
