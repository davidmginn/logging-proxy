using System;
using LoggingWrapper.Models;
using LoggingWrapper.Repository;

namespace LoggingWrapper.Services
{
    public class PersonService : IPersonService
    {
        IPersonRepository _personRepository;

        public PersonService()
        {
            _personRepository = new InMemoryPersonRepository();
        }

        public List<Person> GetPeople()
        {
            var result = GenericLogger.LogEntryAndExit<List<Person>>(_personRepository.GetPeople);

            return result;
        }

        public Person GetPerson(int id)
        {
            var result = GenericLogger.LogEntryAndExit<int, Person>(_personRepository.GetPerson, id);

            return result;
        }
    }
}

