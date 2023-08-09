using System;
using LoggingWrapper.Models;

namespace LoggingWrapper.Services
{
	public interface IPersonService
	{
		List<Person> GetPeople();
		Person GetPerson(int id);
		Task<List<Person>> GetPeopleAsync();
		Task<Person> GetPersonAsync(int id);
	}
}

