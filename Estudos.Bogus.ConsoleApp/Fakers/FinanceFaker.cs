using Bogus;
using Estudos.Bogus.ConsoleApp.Model;

namespace Estudos.Bogus.ConsoleApp.Fakers;

public class FinanceFaker : BaseFaker<Finance>
{
    public FinanceFaker(string locale = "en_US")
    {
        Faker = new Faker<Finance>(locale)
            .RuleFor(u => u.Account, f => f.Finance.Account())
            .RuleFor(u => u.AccountName, f => f.Finance.AccountName())
            .RuleFor(u => u.Amount, f => f.Finance.Amount())
            .RuleFor(u => u.TransactionType, f => f.Finance.TransactionType())
            .RuleFor(u => u.Currency, f => f.Finance.Currency())
            .RuleFor(u => u.CreditCardNumber, f => f.Finance.CreditCardNumber())
            .RuleFor(u => u.CreditCardCvv, f => f.Finance.CreditCardCvv())
            .RuleFor(u => u.BitcoinAddress, f => f.Finance.BitcoinAddress())
            .RuleFor(u => u.EthereumAddress, f => f.Finance.EthereumAddress())
            .RuleFor(u => u.RoutingNumber, f => f.Finance.RoutingNumber())
            .RuleFor(u => u.Bic, f => f.Finance.Bic())
            .RuleFor(u => u.Iban, f => f.Finance.Iban());
    }
}
