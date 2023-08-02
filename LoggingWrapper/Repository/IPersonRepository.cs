using System;
using LoggingWrapper.Models;

namespace LoggingWrapper.Repository
{
	public interface IPersonRepository
	{
		List<Person> GetPeople();
		Person GetPerson(int id);
	}
}

