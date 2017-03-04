using Model.DataBase;
using Presenter;
using Presenter.Interface;
using System;
using System.Windows.Forms;

namespace UI.MagazineForm
{
	public partial class MagazineView : Form,IMagazineView
	{
		private MagazinePresenter _presenter;

		public MagazineView()
		{
			InitializeComponent();
			MagazinePresenter presenter = new MagazinePresenter(this);
			this._presenter = presenter;
		}
		public Magazine Add
		{
			get
			{
				var magazine = new Magazine { Id = Convert.ToInt32(txt_id.Text), Name = txt_name.Text};
				return magazine;
			}
		}
		public Author AddAuthor
		{
			get
			{
				var author = new Author { Id = Convert.ToInt32(comboBox1.SelectedValue) };
				return author;
			}
		}
		public void AddMagazineToList(Magazine magazine)
		{
			int row = dataGridView1.Rows.Add();
			dataGridView1.Rows[row].Cells[0].Value = magazine.Id;
			dataGridView1.Rows[row].Cells[1].Value = magazine.Name;
			try
			{
				foreach(AuthorMagazine authorMagazine in _presenter.AddAuthorFromDB)
				{
					if(magazine.Id == authorMagazine.Magazine.Id)
						dataGridView1.Rows[row].Cells[2].Value = authorMagazine.Author.LastName;
					
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Вы не выбрали Книгу или газету " + e);
			}

		}
		public void EditeMagazineToList(Magazine magazine)
		{
			try
			{
				int index = dataGridView1.SelectedRows[0].Index;
				dataGridView1.Rows[index].Cells[0].Value = magazine.Id;
				dataGridView1.Rows[index].Cells[1].Value = magazine.Name;
				foreach(AuthorMagazine authorMagazine in _presenter.AddAuthorFromDB)
				{
					if(magazine.Id == authorMagazine.Magazine.Id)
						dataGridView1.Rows[index].Cells[2].Value = authorMagazine.Author.LastName;
				}
				MessageBox.Show("Объект изменен");
			}
			catch(Exception e)
			{
				MessageBox.Show("Некоректно введены данные " + e.ToString());
			}
		}
		public int Remove
		{
			get
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
				return 0;
			}
		}
		public void Clear()
		{
			txt_id.Text = "0";
			txt_name.Clear();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			_presenter.Add();
			MessageBox.Show("Новый объект добавлен");
			Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_presenter.Edite();
			Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_presenter.Remove();
			Clear();
		}

		private void MagazineView_Load(object sender, EventArgs e)
		{
			comboBox1.ResetText();
			comboBox1.SelectedItem = -1;
			this.authorsTableAdapter.Fill(this._Model_DataBase_ModelContextDataSet.Authors);
			_presenter.InitView();
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int index = dataGridView1.SelectedRows[0].Index;
			txt_id.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
			txt_name.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.ResetText();
			comboBox1.SelectedItem = -1;
		}
	}
}
