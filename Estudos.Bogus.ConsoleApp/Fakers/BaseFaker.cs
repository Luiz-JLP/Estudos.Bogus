using Bogus;

namespace Estudos.Bogus.ConsoleApp.Fakers;

public class BaseFaker<T> where T : class
{
    public Faker<T>? Faker { get; set; }

    public T Generate()
    {
        return Faker != null ? Faker.Generate() : throw new NullReferenceException();
    }

    public IEnumerable<T> Generate(int maximum)
    {
        return Faker != null ? Faker.GenerateBetween(1, maximum) : throw new NullReferenceException();
    }

    public IEnumerable<T> Generate(int minimum, int maximum)
    {
        return Faker != null ? Faker.GenerateBetween(minimum, maximum) : throw new NullReferenceException();
    }
}
