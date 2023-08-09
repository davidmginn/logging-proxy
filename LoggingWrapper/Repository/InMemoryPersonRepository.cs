using System;
using LoggingWrapper.Models;

namespace LoggingWrapper.Repository
{
    public class InMemoryPersonRepository : IPersonRepository
    {
        public List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Name 1"
                },
                new Person()
                {
                    Id = 2,
                    Name = "Name 2"
                }
            };
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return Task.FromResult(new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Name 1"
                },
                new Person()
                {
                    Id = 2,
                    Name = "Name 2"
                }
            });
        }

        public Person GetPerson(int id)
        {
            return new Person()
            {
                Id = id,
                Name = "My Name"
            };
        }

        public Task<Person> GetPersonAsync(int id)
        {
            return Task.FromResult(new Person()
            {
                Id = id,
                Name = "My Name"
            });
        }
    }
}

