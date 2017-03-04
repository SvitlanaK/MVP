using Model.DataBase;
using Model.Model;
using Presenter.Interface;
using System;
using System.Collections.Generic;

namespace Presenter
{
	public class MagazinePresenter
	{
		private IMagazineView _view;
		private MagazineServer _model;
		public MagazinePresenter(IMagazineView view)
		{
			this._view = view;
			_model = new MagazineServer();
		}
		public void InitView()
		{
			IEnumerable<Magazine> magazines = _model.GetAllMagazines();
			foreach(Magazine magazine in magazines)
			{
				_view.AddMagazineToList(magazine);
			}
		}
		public List<AuthorMagazine> AddAuthorFromDB
		{
			get
			{
				return _model.ViewAuthors();
			}
		}
		public void Add()
		{
			var magazineUpdate = _model.Save(_view.Add, _view.AddAuthor);

			_view.AddMagazineToList(magazineUpdate);
		}
		public void Remove()
		{
			_model.Delete(_view.Remove);
		}
		public void Edite()
		{

			var magasineUpdate = _model.Edite(_view.Add, _view.AddAuthor);
			_view.EditeMagazineToList(magasineUpdate);
		}
	}
}

