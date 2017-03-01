using Model.DataBase;
using Model.Model;
using Presenter.Interface;
using System;
using System.Collections.Generic;


namespace Presenter
{
	public class AuthorPresenter
	{
		private IAuthorView _view;
		private AuthorServer _model;
		public AuthorPresenter(IAuthorView view)
		{
			this._view = view;
			_model = new AuthorServer();
		}
		public void InitView()
		{
			IEnumerable<Author> authors = _model.GetAllAuthors();
			foreach(Author author in authors)
			{
				_view.AddAuthorToList(author);
			}
		}
		public List<Book> AddBook
		{
			get
			{
				return _model.BooksView();
			}
		}
		public List<AuthorMagazine> AddMagazine
		{
			get
			{
				return _model.AuthorView();
			}
		}
		public void AddAuthor()
		{
			var author = _model.Create(_view.AuthorToAdd, _view.AddItem);
			_view.AddAuthorToList(author);
		}
		public void RemoveAuthor()
		{
			_model.Delete(_view.RemoveAuthor);
		}
		public void EditeAuthor()
		{
			var author = _model.Edite(_view.AuthorToAdd);
			_view.EditeAuthorToList(author);
		}
		
	}
}
