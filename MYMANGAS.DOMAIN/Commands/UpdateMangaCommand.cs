using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Commands.Validations;

namespace MYMANGAS.DOMAIN.Commands
{
    public class UpdateMangaCommand : MangaCommand, ICommand
    {
        public bool Validate()
        {
            var validateCommand = new UpdateMangaValidation().Validate(this).IsValid;

            return validateCommand;
        }
    }
}
