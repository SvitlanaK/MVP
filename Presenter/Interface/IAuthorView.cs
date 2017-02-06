using Presenter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
	public interface IAuthorView
	{
		Author AuthorToAdd { get; }
		void EditeAuthorToList(Author author);
		void AddAuthorToList(Author author);
		int RemoveAuthor { get; }
	}
}
