using Model.DataBase;


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
