using Presenter.DataBase;
using Presenter.Interface;
using Presenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
	public class BookPresenter
	{
		private IBookView view;
		private IBookServer model;
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
		private void registerToModelEvents()
		{
			model.BookSaved += server_BookSaved;
		}
		private void server_BookSaved(object sender, BookSavedEventArgs e)
		{
			view.AddBookToList(e.Book);
		}
	}
}
