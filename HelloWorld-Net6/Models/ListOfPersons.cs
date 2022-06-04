using System;
namespace HelloWorld_Net6.Models
{
	public class ListOfPersons
	{
		public int EntryID { get; set; }
		public ICollection<Person> Persons { get; set; }
		public DateTime DateAdded { get; set; }
	}
}

