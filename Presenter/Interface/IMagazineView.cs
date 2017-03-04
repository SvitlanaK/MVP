

using Model.DataBase;

namespace Presenter.Interface
{
	public interface IMagazineView
	{
		Magazine Add { get; }
		Author AddAuthor { get; }
		void AddMagazineToList(Magazine magazine);
		void EditeMagazineToList(Magazine magazine);
		int Remove { get; }
	}
}
