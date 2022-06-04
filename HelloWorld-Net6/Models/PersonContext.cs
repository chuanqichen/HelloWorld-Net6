using System;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld_Net6.Models
{
	public class PersonContext : DbContext
	{
		public PersonContext()
		{
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<ListOfPersons> ListOfPersons { get; set; }

}
}

