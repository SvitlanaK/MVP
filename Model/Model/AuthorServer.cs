using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.Model
{
	public class AuthorServer 
	{
		private ModelContext _db = new ModelContext();
		public AuthorServer()
		{
			_db.Authors.Load();
			
		}
		public List<Book> BooksView()
		{
			return _db.Books.Include(x => x.Author).Where(x => x.Author.Id == x.AuthorId).ToList();
			
		}
		public List<AuthorMagazine> AuthorView()
		{
			return _db.AuthorMagazines.Include(x => x.Magazine).Include(r=>r.Author)..ToList();

		}
		public IEnumerable<Author> GetAllAuthors()
		{
			return _db.Authors;
			
		}
		public Author Create(Author author, AuthorMagazine magazine)
		{
			if(author.Id == 0)
			{
				_db.Authors.Add(author);
				_db.AuthorMagazines.Add(magazine);
				_db.SaveChanges();
			}
			return author;
		}
		public void Delete(int id)
		{
			if(id > 0)
			{
				var author = _db.Authors.Find(id);
				_db.Authors.Remove(author);
				_db.SaveChanges();
			}
		}
		public Author Edite(Author author)
		{
			var authorUpdate = _db.Authors.Where(p => p.Id == author.Id).FirstOrDefault();
			if(authorUpdate != null)
			{
				_db.Entry(authorUpdate).CurrentValues.SetValues(author);

			}
			_db.SaveChanges();
			return authorUpdate;
		}
	}
}
