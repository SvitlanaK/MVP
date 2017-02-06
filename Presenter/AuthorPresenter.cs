using Presenter.DataBase;
using Presenter.Interface;
using Presenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
	public class AuthorPresenter
	{
		private IAuthorView view;
		private IAuthorServer model1;
		public AuthorPresenter(IAuthorView view)
		{
			this.view = view;
			model1 = new AuthorServer();
		}
		public void InitView()
		{
			IEnumerable<Author> authors = model1.GetAllAuthors();
			foreach(Author author in authors)
			{
				view.AddAuthorToList(author);
			}
		}
		public void AddAuthor()
		{
			Author a = model1.Create(view.AuthorToAdd);
			view.AddAuthorToList(a);
		}
		public void RemoveAuthor()
		{
			model1.Delete(view.RemoveAuthor);
		}
		public void EditeAuthor()
		{
			Author a = model1.Edite(view.AuthorToAdd);
			view.EditeAuthorToList(a);
		}
		private void registerToModelEvents()
		{
			model1.AuthorSaved += server_AuthorSaved;
		}


		private void server_AuthorSaved(object sender, AuthorSavedEventArgs e)
		{
			view.AddAuthorToList(e.Author);
		}
	}
}
