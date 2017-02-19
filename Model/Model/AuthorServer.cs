using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.Model
{
	public class AuthorServer 
	{
		private ModelContext db = new ModelContext();
		public AuthorServer()
		{
			db.Authors.Load();
		}
		public IEnumerable<Author> GetAllAuthors()
		{
			return db.Authors;
		}
		public Author Create(Author _author)
		{
			if(_author.Id == 0)
			{
				db.Authors.Add(_author);
				db.SaveChanges();
			}
			return _author;
		}
		public void Delete(int _id)
		{
			if(_id > 0)
			{
				Author a = db.Authors.Find(_id);
				db.Authors.Remove(a);
				db.SaveChanges();
			}
		}
		public Author Edite(Author _author)
		{
			Author authorUpdate = db.Authors.Where(p => p.Id == _author.Id).FirstOrDefault();
			if(authorUpdate != null)
			{
				db.Entry(authorUpdate).CurrentValues.SetValues(_author);

			}
			db.SaveChanges();
			return authorUpdate;
		}
	}
}
