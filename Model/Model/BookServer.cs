using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.Model
{
	public class BookServer 
	{
		private ModelContext _db = new ModelContext();
		public BookServer()
		{
			_db.Books.Load();
		}
		public IEnumerable<Book> GetAllBooks()
		{
			return _db.Books;
		}
		public Book Save(Book book)
		{
			if(book.Id == 0)
			{
				_db.Books.Add(book);
				_db.SaveChanges();
			}
			return book;
		}
		public void Delete(int id)
		{
			if(id > 0)
			{
				Book updateBook = _db.Books.Find(id);
				_db.Books.Remove(updateBook);
				_db.SaveChanges();
			}
		}
		public Book Edite(Book book)
		{
			Book bookUpdate = _db.Books.Where(p => p.Id == book.Id).FirstOrDefault();
			if(bookUpdate != null)
			{
				_db.Entry(bookUpdate).CurrentValues.SetValues(book);

			}
			_db.SaveChanges();
			return bookUpdate;
		}
	}
}