using LoggingWrapper.Services;

namespace LoggingWrapper;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var service = new PersonService();

        var people = service.GetPeople();

        var person = service.GetPerson(1);

        var asyncPeople = await service.GetPeopleAsync();

        var asyncPerson = await service.GetPersonAsync(2);

        Console.ReadKey();
    }
}

