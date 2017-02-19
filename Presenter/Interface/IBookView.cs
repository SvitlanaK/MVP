

using Model.DataBase;

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
