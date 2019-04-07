namespace Magva.Domain.Validations.Cards
{
    public class PasswordLengthValidation
    {

        public static bool Valid { get; set; }
        public static bool Invalid { get; set; }

        public static bool LengthIsNotValid(string password)
        {
            return (password.Length < 4 || password.Length > 6) ? Valid : Invalid;
        }
    }
}
