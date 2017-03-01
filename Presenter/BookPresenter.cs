using Model.DataBase;
using Model.Model;
using Presenter.Interface;
using System.Collections.Generic;

namespace Presenter
{
	public class BookPresenter
	{
		private IBookView _view;
		private BookServer _model;
		public BookPresenter(IBookView view)
		{
			this._view = view;
			_model = new BookServer();
		}
		public void InitView()
		{
			IEnumerable<Book> books = _model.GetAllBooks();
			foreach(Book book in books)
			{
				_view.AddBookToList(book);
			}
		}
		public void AddBook()
		{
			var bookUpdate = _model.Save(_view.BookToAdd);
			_view.AddBookToList(bookUpdate);
		}
		public void RemoveBook()
		{
			_model.Delete(_view.RemoveBook);
		}
		public void EditeBook()
		{
			var bookUpdate = _model.Edite(_view.BookToAdd);
			_view.EditeBookToList(bookUpdate);
		}
	}
}
