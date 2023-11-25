using Bogus;
using Estudos.Bogus.ConsoleApp.Model;

namespace Estudos.Bogus.ConsoleApp.Fakers;

public class CompanyFaker : BaseFaker<Company>
{
    public CompanyFaker()
    {
        Faker = new Faker<Company>()
            .RuleFor(u => u.CompanyName, f => f.Company.CompanyName())
            .RuleFor(u => u.CompanySuffix, f => f.Company.CompanySuffix())
            .RuleFor(u => u.CatchPhrase, f => f.Company.CatchPhrase())
            .RuleFor(u => u.Bs, f => f.Company.Bs());
    }
}
