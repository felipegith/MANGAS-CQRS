using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Commands.Validations;

namespace MYMANGAS.DOMAIN.Commands
{
    public class UpdateMangaReadCommand : MangaCommand, ICommand
    {
        public bool Validate()
        {
            var validateCommand = new UpdateMangaReadValidation().Validate(this).IsValid;

            return validateCommand;
        }
    }
}
