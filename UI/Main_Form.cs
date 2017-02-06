using System;
using System.Windows.Forms;
using UI.AuthorForm;
using UI.BookForm;

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
	}
}
