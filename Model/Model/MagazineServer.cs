using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Model.Model
{
	public class MagazineServer
	{
		private ModelContext db = new ModelContext();
		public MagazineServer()
		{
			db.Magazines.Load();
		}
		public IEnumerable<Magazine> GetAllBooks()
		{
			return db.Magazines;
		}
		public Magazine Save(Magazine _magazine, AuthorMagazine _author)
		{
			if(_magazine.Id == 0)
			{
				db.Magazines.Add(_magazine);
				db.AuthorMagazines.Add(_author);
				db.SaveChanges();
			}
			return _magazine;
		}

		public void Delete(int _id)
		{
			if(_id > 0)
			{
				Magazine updateMagazine = db.Magazines.Find(_id);
				db.Magazines.Remove(updateMagazine);
				db.SaveChanges();
			}
		}
		public Magazine Edite(Magazine _magazine, AuthorMagazine _author)
		{
			Magazine updateMagazine = db.Magazines.Where(p => p.Id == _magazine.Id).FirstOrDefault();
			if(updateMagazine != null)
			{
				db.Entry(updateMagazine).CurrentValues.SetValues(_magazine);
				db.AuthorMagazines.Add(_author);
			}
			db.SaveChanges();
			return updateMagazine;
		}
	}
}
	