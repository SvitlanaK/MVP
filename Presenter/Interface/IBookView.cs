using Presenter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
	public interface IBookView
	{
		Book BookToAdd { get; }
		void EditeBookToList(Book author);
		void AddBookToList(Book author);
		int RemoveBook { get; }
	}
}
