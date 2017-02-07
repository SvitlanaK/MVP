using Presenter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
	public interface IBookServer
	{
		IEnumerable<Book> GetAllBooks();
		Book Edite(Book _book);
		Book Save(Book _author);
		void Delete(int id);
	}
}
