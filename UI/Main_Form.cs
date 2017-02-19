using Model.DataBase;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using UI.AuthorForm;
using UI.BookForm;
using UI.MagazineForm;

namespace UI
{
	public partial class Main_Form : Form
	{
		public Main_Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AuthorView view1 = new AuthorView();
			view1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			BookView view2 = new BookView();
			view2.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MagazineView  view3 = new MagazineView();
			view3.Show();
		}
	}
}
