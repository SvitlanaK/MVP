

using Model.DataBase;

namespace Presenter.Interface
{
	public interface IMagazineView
	{
		Magazine Add { get; }
		AuthorMagazine AddAuthor { get; }
		void AddMagazineToList(Magazine m);
		void EditeMagazineToList(Magazine m, AuthorMagazine m2);
		int Remove { get; }
	}
}
