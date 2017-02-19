namespace Model.DataBase
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class ModelContext : DbContext
	{

		public ModelContext()
			: base("name=MVPDB")
		{ }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Magazine> Magazines { get; set; }
		public DbSet<AuthorMagazine> AuthorMagazines { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Author>()
		   .HasMany(p => p.Books)
		   .WithRequired(p => p.Author)
		   .HasForeignKey(f => f.AuthorId);

		}
	}
}