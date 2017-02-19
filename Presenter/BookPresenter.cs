using Model.DataBase;
using Model.Model;
using Presenter.Interface;
using System.Collections.Generic;

namespace Presenter
{
	public class BookPresenter
	{
		private IBookView view;
		private BookServer model;
		public BookPresenter(IBookView view)
		{
			this.view = view;
			model = new BookServer();
		}
		public void InitView()
		{
			IEnumerable<Book> books = model.GetAllBooks();
			foreach(Book book in books)
			{
				view.AddBookToList(book);
			}
		}
		public void AddBook()
		{
			Book bookUpdate = model.Save(view.BookToAdd);
			view.AddBookToList(bookUpdate);
		}
		public void RemoveBook()
		{
			model.Delete(view.RemoveBook);
		}
		public void EditeBook()
		{
			Book bookUpdate = model.Edite(view.BookToAdd);
			view.EditeBookToList(bookUpdate);
		}
	}
}
