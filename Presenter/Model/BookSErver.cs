using Presenter.DataBase;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Model
{
	class BookServer : IBookServer
	{
		private ModelContext db = new ModelContext();
		public event EventHandler<BookSavedEventArgs> BookSaved;
		public BookServer()
		{
			db.Books.Load();
		}
		public IEnumerable<Book> GetAllBooks()
		{
			return db.Books;
		}
		public Book Save(Book _book)
		{
			if(_book.Id == 0)
			{
				db.Books.Add(_book);
				db.SaveChanges();
				raiseBookSaved(_book);
			}
			return _book;
		}
		public void Delete(int _id)
		{
			if(_id > 0)
			{
				Book updateBook = db.Books.Find(_id);
				db.Books.Remove(updateBook);
				db.SaveChanges();
				raiseBookSaved(updateBook);
			}
		}
		public Book Edite(Book _book)
		{
			Book bookUpdate = db.Books.Where(p => p.Id == _book.Id).FirstOrDefault();
			if(bookUpdate != null)
			{
				db.Entry(bookUpdate).CurrentValues.SetValues(_book);

			}
			db.SaveChanges();
			raiseBookSaved(bookUpdate);
			return bookUpdate;
		}

		private void raiseBookSaved(Book _book)
		{
			if(BookSaved != null)
			{
				BookSaved(this, new BookSavedEventArgs(_book));
			}
		}
	}
}