using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Commands.Validations;

namespace MYMANGAS.DOMAIN.Commands
{
    public class DeleteMangaCommand : MangaCommand, ICommand
    {
        public bool Validate()
        {
            var validateCommand = new DeleteMangaValidation().Validate(this).IsValid;

            return validateCommand;
        }
    }
}
