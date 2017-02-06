﻿using Presenter;
using Presenter.DataBase;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.BookForm
{
	public partial class BookView : Form, IBookView
	{
		private BookPresenter presenter;
		public BookView()
		{
			InitializeComponent();
			BookPresenter presenter = new BookPresenter(this);
			this.presenter = presenter;
		}
		public Book BookToAdd
		{
			get
			{
				Book a = new Book { Id = Convert.ToInt32(txt_id.Text), Name = txt_name.Text };

				return a;
			}
		}

		public void AddBookToList(Book book)
		{
			int row = dataGridView1.Rows.Add();
			dataGridView1.Rows[row].Cells[0].Value = book.Id;
			dataGridView1.Rows[row].Cells[1].Value = book.Name;
		
		}
		public void EditeBookToList(Book book)
		{
			try
			{
				int index = dataGridView1.SelectedRows[0].Index;
				dataGridView1.Rows[index].Cells[0].Value = book.Id;
				dataGridView1.Rows[index].Cells[1].Value = book.Name;
				MessageBox.Show("Объект изменен");
			}
			catch(Exception e)
			{
				MessageBox.Show("Некоректно введены данные " + e.ToString());
			}
		}
		public int RemoveBook
		{
			get
			{
				try
					{
						int index = dataGridView1.SelectedRows[0].Index;
						dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
						int id = 0;
						id = Convert.ToInt32(dataGridView1[0, index].Value);
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
		private void BookView_Load(object sender, EventArgs e)
		{
			presenter.InitView();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			presenter.AddBook();
			MessageBox.Show("Новый объект добавлен");
			Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			presenter.EditeBook();
			Clear();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			presenter.RemoveBook();
			Clear();
			
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int index = dataGridView1.SelectedRows[0].Index;
			txt_id.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
			txt_name.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
		}
	}
}