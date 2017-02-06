using Presenter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
	public class AuthorSavedEventArgs : EventArgs
	{
		private readonly Author allAuthors;
		public AuthorSavedEventArgs(Author _author)
		{
			allAuthors = _author;
		}
		public Author Author
		{
			get { return allAuthors; }
		}
	}
	public interface IAuthorServer
	{
		IEnumerable<Author> GetAllAuthors();
		Author Edite(Author _author);
		Author Create(Author _author);
		void Delete(int id);
		event EventHandler<AuthorSavedEventArgs> AuthorSaved;
	}
}
