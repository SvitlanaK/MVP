namespace Presenter.DataBase
{
	using System;
	using System.Data.Entity;

	public class ModelContext : DbContext
	{
		public ModelContext()
			: base("name=MVPDB")
		{
		}
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Book> Books { get; set; }
	}
}