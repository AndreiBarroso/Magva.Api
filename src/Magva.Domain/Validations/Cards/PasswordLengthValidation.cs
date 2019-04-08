namespace Magva.Domain.Validations.Cards
{
    public class PasswordLengthValidation
    {
        public PasswordLengthValidation(string password)
        {
            LengthIsNotValid(password);

        }


        public readonly bool Valid = false;
        public readonly bool Invalid = true;

        public bool LengthIsNotValid(string password)
        {
            return (password.Length < 4 || password.Length > 6) ? Valid : Invalid;
        }
    }
}
