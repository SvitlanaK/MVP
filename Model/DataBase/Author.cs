using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
	public class Author
	{
		public int Id { get; set; }
		public string FirstName { get; set; }

		public string MidleName { get; set; }
		public string LastName { get; set; }
		public virtual List<AuthorMagazine> Magazines { get; set; }
		public virtual List<Book> Books { get; set; }

	}
}