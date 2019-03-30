using FluentValidator;
using FluentValidator.Validation;
using Magba.Infra.Crosscutting.Constants;

namespace Magva.Domain.Validations.Customer
{
    public class BalanceValidate : Notifiable
    {
        public BalanceValidate(decimal balance)
        {
            AddNotifications(new ValidationContract()
                .IsTrue(InsufficientBalanceValidate(balance), "Balance",
                ExceptionConstants.INSUFFICIENT_BALANCE
         ));
        }


         bool InsufficientBalanceValidate(decimal balance)
        {
           return balance <= 0 ? true : false;
        }
    }
}
