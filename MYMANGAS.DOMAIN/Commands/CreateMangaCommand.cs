using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Commands.Validations;

namespace MYMANGAS.DOMAIN.Commands
{
    public class CreateMangaCommand : MangaCommand, ICommand
    {

        public bool Validate()
        {
            var validateCommand = new CreateMangaValidation().Validate(this).IsValid;

            return validateCommand;
        }
    }
}
