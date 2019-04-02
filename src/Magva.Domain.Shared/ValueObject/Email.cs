using FluentValidator;
using FluentValidator.Validation;
using Magva.Infra.Crosscutting.Constants;
using System.Text.RegularExpressions;

namespace Magva.Domain.Shared.ValueObject
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Email", ExceptionConstants.ERROR_IN_PASSWORD_SIZE)
            );
        }

        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }

        public static bool Validate(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
