using Presenter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
	public interface IAuthorServer
	{
		IEnumerable<Author> GetAllAuthors();
		Author Edite(Author _author);
		Author Create(Author _author);
		void Delete(int id);
	}
}
