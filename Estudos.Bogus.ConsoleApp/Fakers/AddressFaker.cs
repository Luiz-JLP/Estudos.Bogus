using Bogus;
using Estudos.Bogus.ConsoleApp.Model;

namespace Estudos.Bogus.ConsoleApp.Fakers;

public class AddressFaker : BaseFaker<Address>
{
    public AddressFaker(string locale = "en_US")
    {
        Faker = new Faker<Address>(locale)
            .RuleFor(u => u.StreetSuffix, f => f.Address.StreetSuffix())
            .RuleFor(u => u.StreetName, f => f.Address.StreetName())
            .RuleFor(u => u.BuildingNumber, f => f.Address.BuildingNumber())
            .RuleFor(u => u.SecondaryAddress, f => f.Address.SecondaryAddress())
            .RuleFor(u => u.ZipCode, f => f.Address.ZipCode())
            .RuleFor(u => u.County, f => f.Address.County())
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.State, f => f.Address.State())
            .RuleFor(u => u.Country, f => f.Address.Country());
    }
}
