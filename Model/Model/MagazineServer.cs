using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Model.Model
{
	public class MagazineServer
	{
		private ModelContext _db = new ModelContext();
		public MagazineServer()
		{
			_db.Magazines.Load();
		}
		public IEnumerable<Magazine> GetAllMagazines()
		{
			return _db.Magazines;
		}
		public List<AuthorMagazine> ViewAuthors()
		{
			return _db.AuthorMagazines.Include(x => x.Author).Where(m => m.Author.Id >= 0).ToList();
		}
		
		public Magazine Save(Magazine magazine, Author author)
		{
			if(magazine.Id == 0)
			{
				_db.Magazines.Add(magazine);
			}
			var authorAdd = _db.Authors.Where(m => m.Id == author.Id).SingleOrDefault();
			if(authorAdd != null)
			{
				var newAuthor = new AuthorMagazine { Author = authorAdd, Magazine = magazine };
				_db.AuthorMagazines.Add(newAuthor);
			}
			_db.SaveChanges();
			
			return magazine;
		}

		public void Delete(int id)
		{
			if(id > 0)
			{
				var magazine = _db.Magazines.Find(id);
				_db.Magazines.Remove(magazine);
				
			}
			var authorDelete = _db.AuthorMagazines.Where(c => c.Magazine.Id == id).SingleOrDefault();
			if(authorDelete != null)
			{
				_db.AuthorMagazines.Remove(authorDelete);
			}
			_db.SaveChanges();
		}
		public Magazine Edite(Magazine magazine, Author author)
		{
			var magazineUpdate = _db.Magazines.Where(p => p.Id == magazine.Id).FirstOrDefault();
			if(magazineUpdate != null)
			{
				_db.Entry(magazineUpdate).CurrentValues.SetValues(magazine);	
			}
			var authorAdd = _db.Authors.Where(m => m.Id == author.Id).SingleOrDefault();
			if(authorAdd != null)
			{
				var newAuthor = new AuthorMagazine { Author = authorAdd, Magazine = magazine };
				_db.AuthorMagazines.Add(newAuthor);
			}
			_db.SaveChanges();
			return magazineUpdate;
		}
	}
}
	