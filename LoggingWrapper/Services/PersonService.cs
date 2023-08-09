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

        public async Task<List<Person>> GetPeopleAsync()
        {
            var result =  await GenericLogger.LogEntryAndExit<Task<List<Person>>>(_personRepository.GetPeopleAsync);

            return result;
        }

        public Person GetPerson(int id)
        {
            var result = GenericLogger.LogEntryAndExit<int, Person>(_personRepository.GetPerson, id);

            return result;
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            var result = await GenericLogger.LogEntryAndExit<int, Task<Person>>(_personRepository.GetPersonAsync, id);
            return result;
        }
    }
}

