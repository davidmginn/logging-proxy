using System;
using LoggingWrapper.Models;

namespace LoggingWrapper.Services
{
	public interface IPersonService
	{
		List<Person> GetPeople();
		Person GetPerson(int id);
	}
}

