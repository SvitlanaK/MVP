using Model.DataBase;
using Model.Model;
using Presenter.Interface;
using System;
using System.Collections.Generic;

namespace Presenter
{
	public class MagazinePresenter
	{
		private IMagazineView view;
		private MagazineServer model;
		public MagazinePresenter(IMagazineView view)
		{
			this.view = view;
			model = new MagazineServer();
		}
		public void InitView()
		{
			IEnumerable<Magazine> magazines = model.GetAllBooks();
			foreach(Magazine magazine in magazines)
			{
				view.AddMagazineToList(magazine);
			}
		}
		public void Add()
		{
			Magazine magazineUpdate = model.Save(view.Add, view.AddAuthor);
			view.AddMagazineToList(magazineUpdate);
		}
		public void Remove()
		{
			model.Delete(view.Remove);
		}
		public void Edite()
		{
			Magazine magasineUpdate = model.Edite(view.Add,view.AddAuthor );
			view.EditeMagazineToList(magasineUpdate, view.AddAuthor);
		}
	}
}

