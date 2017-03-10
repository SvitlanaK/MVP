using System;
using System.Windows.Forms;
using Presenter.Interface;
using Presenter;
using Model.DataBase;
using System.Collections.Generic;

namespace UI.AuthorForm
{
	public partial class AuthorView : Form, IAuthorView
	{
		private AuthorPresenter _presenter;
		public AuthorView()
		{
			InitializeComponent();
			AuthorPresenter presenter = new AuthorPresenter(this);
			this._presenter = presenter;
		}

		private void AuthorView_Load(object sender, EventArgs e)
		{			
			this.booksTableAdapter.Fill(this._Model_DataBase_ModelContextDataSet.Books);
			comboBox1.SelectedItem = null;
			this.magazinesTableAdapter.Fill(this._Model_DataBase_ModelContextDataSet.Magazines);
			comboBox2.SelectedItem = null;
			_presenter.InitView();
			
		}
		public Author AuthorToAdd
		{
			get
			{
				var author = new Author { Id = Convert.ToInt32(txt_id.Text), FirstName = txt_fname.Text, MidleName = txt_mname.Text, LastName = txt_lname.Text };
				return author;
			}
		}
		public Magazine AddItem
		{
			get
			{
				var magazine = new Magazine { Id = Convert.ToInt32(comboBox2.SelectedValue) };
				return magazine;
			}
		}
		public void AddAuthorToList(Author author)
		{
			int row = dataGridView1.Rows.Add();
			dataGridView1.Rows[row].Cells[0].Value = author.Id;
			dataGridView1.Rows[row].Cells[1].Value = author.FirstName;
			dataGridView1.Rows[row].Cells[2].Value = author.MidleName;
			dataGridView1.Rows[row].Cells[3].Value = author.LastName;
			try
			{
				foreach(AuthorMagazine authorMagazine in _presenter.AddMagazineFromDB)
				{
					if(author.Id == authorMagazine.Author.Id)
						dataGridView1.Rows[row].Cells[4].Value = Convert.ToString(authorMagazine.Magazine.Name);
					
				}
				foreach(Book book in _presenter.AddBook)
				{
					if(book.AuthorId == author.Id)
						dataGridView1.Rows[row].Cells[5].Value += book.Name;
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Вы не выбрали Книгу или газету " + e);
			}
		}
		public void EditeAuthorToList(Author author)
		{
			try
			{
				int index = dataGridView1.SelectedRows[0].Index;
				dataGridView1.Rows[index].Cells["id"].Value = author.Id;
				dataGridView1.Rows[index].Cells[1].Value = author.FirstName;
				dataGridView1.Rows[index].Cells[2].Value = author.MidleName;
				dataGridView1.Rows[index].Cells[3].Value = author.LastName;
				MessageBox.Show("Объект изменен");
			}
			catch(Exception e)
			{
				MessageBox.Show("Некоректно введены данные " + e.ToString());
			}
		}
		public int RemoveAuthor
		{
			get
			{
				if(dataGridView1.SelectedRows.Count >= 0)
				{
					try
					{
						int index = dataGridView1.SelectedRows[0].Index;
						int id = 0;
						id = Convert.ToInt32(dataGridView1[0, index].Value);
						dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
						MessageBox.Show("Объект удален");
						return id;
					}
					catch(Exception e)
					{
						MessageBox.Show("Обьект для удаления не выбран " + e.ToString());
					}
				}
				return -1;
			}
		}
		public void Clear()
		{
			txt_id.Text = "0";
			txt_fname.Clear();
			txt_mname.Clear();
			txt_lname.Clear();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			_presenter.AddAuthor();
			MessageBox.Show("Новый объект добавлен");
			Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_presenter.EditeAuthor();
			Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_presenter.RemoveAuthor();
			Clear();
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int index = dataGridView1.SelectedRows[0].Index;
			txt_id.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
			txt_fname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
			txt_mname.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
			txt_lname.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
		}
	}
}
