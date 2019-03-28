using Magva.Domain.Shared.Enum;

namespace Magva.Domain.Entities
{
    public class Transaction
    {
        public Transaction(decimal amount, ETransactionType type, int number, Card card)
        {
            Amount = amount;
            Type = type;
            Number = number;
            Card = card;
        }

        public decimal Amount { get; set; }
        public ETransactionType Type { get; set; }
        public int Number { get; set; }
        public Card Card { get; set; }
    }
}
