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
		public IEnumerable<Magazine> GetAllBooks()
		{
			return _db.Magazines;
		}
		public List<AuthorMagazine> AuthorView()
		{
			return _db.AuthorMagazines.Include(x => x.Author).Where(m => m.MagazineId == m.Magazine.Id).ToList();

		}
		public Magazine Save(Magazine magazine, AuthorMagazine authorMagazine)
		{
			if(magazine.Id == 0)
			{
				_db.Magazines.Add(magazine);
				_db.AuthorMagazines.Add(authorMagazine);
				_db.SaveChanges();
			}
			return magazine;
		}

		public void Delete(int id)
		{
			if(id > 0)
			{
				Magazine updateMagazine = _db.Magazines.Find(id);
				_db.Magazines.Remove(updateMagazine);
				_db.SaveChanges();
			}
		}
		public Magazine Edite(Magazine magazine, AuthorMagazine authorMagazine)
		{
			Magazine updateMagazine = _db.Magazines.Where(p => p.Id == magazine.Id).FirstOrDefault();
			if(updateMagazine != null)
			{
				_db.Entry(updateMagazine).CurrentValues.SetValues(magazine);
				_db.AuthorMagazines.Add(authorMagazine);
			}
			_db.SaveChanges();
			return updateMagazine;
		}
	}
}
	