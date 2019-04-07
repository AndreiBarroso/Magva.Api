namespace Magva.Domain.Validations.Cards
{
   public class BalanceValidation
    {

        public BalanceValidation(decimal balance)
        {
            InsufficientBalanceValidate(balance);
        }

        public readonly bool positive = false;
        public readonly bool negative = true;


        public  bool InsufficientBalanceValidate(decimal balance)
        {
            decimal zero = 0.0m;

            return balance <= zero ? negative : positive;
        }
    }
}
