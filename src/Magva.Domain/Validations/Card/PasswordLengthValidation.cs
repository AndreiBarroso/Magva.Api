using FluentValidator;
using FluentValidator.Validation;
using Magva.Infra.Crosscutting.Constants;

namespace Magva.Domain.Validations.Card
{
    public class PasswordLengthValidation : Notifiable
    {
        public PasswordLengthValidation(string password)
        {
            AddNotifications(new ValidationContract()
                .IsTrue(LengthIsNotValid(password), "Password", ExceptionConstants.ERROR_IN_PASSWORD_SIZE)
                );
        }

        public bool LengthIsNotValid(string password)
        {
            return (password.Length < 4 || password.Length > 6) ? true : false;
        }
    }
}
