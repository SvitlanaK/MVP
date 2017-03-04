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
		public List<AuthorMagazine> ViewMagazines()
		{
			return _db.AuthorMagazines.Include(x => x.Magazine).Where(m => m.Magazine.Id >=0).ToList();
		}
		public IEnumerable<Author> GetAllAuthors()
		{
			return _db.Authors;
		}
		public Author Save(Author author, Magazine magazine)
		{
			if(author.Id == 0)
			{
				_db.Authors.Add(author);
			}
			var magazineAdd = _db.Magazines.Where(m => m.Id == magazine.Id).SingleOrDefault();
			if(magazineAdd != null)
			{
				var newMagazine = new AuthorMagazine { Magazine = magazineAdd,  Author = author };
				_db.AuthorMagazines.Add(newMagazine);
			}
			_db.SaveChanges();
			return author;
		}
		public void Delete(int id)
		{
			if(id > 0)
			{
				var author = _db.Authors.Find(id);
				_db.Authors.Remove(author);
			}
			var magazineDelete = _db.AuthorMagazines.Where(c => c.Author.Id == id).SingleOrDefault();
			if(magazineDelete != null)
			{
				_db.AuthorMagazines.Remove(magazineDelete);
			}
			_db.SaveChanges();
		}
		public Author Edite(Author author, Magazine magazine)
		{
			var authorUpdate = _db.Authors.Where(p => p.Id == author.Id).FirstOrDefault();
			if(authorUpdate != null)
			{
				_db.Entry(authorUpdate).CurrentValues.SetValues(author);
			}
			var magazineAdd = _db.Magazines.Where(m => m.Id == magazine.Id).SingleOrDefault();
			if(magazineAdd != null)
			{
				var newMagazine = new AuthorMagazine { Author = author, Magazine = magazineAdd };
				_db.AuthorMagazines.Add(newMagazine);
			}
			_db.SaveChanges();
			return authorUpdate;
		}
	}
}
