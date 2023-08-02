using LoggingWrapper.Services;

namespace LoggingWrapper;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var service = new PersonService();

        var people = service.GetPeople();

        var person = service.GetPerson(1);

        Console.ReadKey();
    }
}

