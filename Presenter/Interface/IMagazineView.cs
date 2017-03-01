

using Model.DataBase;

namespace Presenter.Interface
{
	public interface IMagazineView
	{
		Magazine Add { get; }
		AuthorMagazine AddAuthor { get; }
		void AddMagazineToList(Magazine magazine);
		void EditeMagazineToList(Magazine magazine, AuthorMagazine authorMagazine);
		int Remove { get; }
	}
}
