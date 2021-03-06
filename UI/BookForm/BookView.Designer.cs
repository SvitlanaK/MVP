﻿namespace UI.BookForm
{
	partial class BookView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this._Model_DataBase_ModelContextDataSet = new UI._Model_DataBase_ModelContextDataSet();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.authorsTableAdapter = new UI._Model_DataBase_ModelContextDataSetTableAdapters.AuthorsTableAdapter();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.authorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameBook,
            this.AuthorId});
			this.dataGridView1.Location = new System.Drawing.Point(9, -1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(451, 197);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// NameBook
			// 
			this.NameBook.HeaderText = "NameBook";
			this.NameBook.Name = "NameBook";
			// 
			// AuthorId
			// 
			this.AuthorId.HeaderText = "Author";
			this.AuthorId.Name = "AuthorId";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txt_name);
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 214);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 174);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// authorsBindingSource1
			// 
			this.authorsBindingSource1.DataMember = "Authors";
			this.authorsBindingSource1.DataSource = this._Model_DataBase_ModelContextDataSet;
			// 
			// _Model_DataBase_ModelContextDataSet
			// 
			this._Model_DataBase_ModelContextDataSet.DataSetName = "_Model_DataBase_ModelContextDataSet";
			this._Model_DataBase_ModelContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(178, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Author";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(49, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 27);
			this.button2.TabIndex = 5;
			this.button2.Text = "Edite";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(49, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(49, 48);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(100, 20);
			this.txt_name.TabIndex = 3;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(49, 22);
			this.txt_id.Name = "txt_id";
			this.txt_id.ReadOnly = true;
			this.txt_id.Size = new System.Drawing.Size(100, 20);
			this.txt_id.TabIndex = 2;
			this.txt_id.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "Authors";
			this.authorsBindingSource.DataSource = this._Model_DataBase_ModelContextDataSet;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(326, 244);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(134, 82);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(16, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 37);
			this.button3.TabIndex = 6;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.authorsBindingSource2;
			this.comboBox1.DisplayMember = "LastName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(181, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.ValueMember = "Id";
			// 
			// authorsBindingSource2
			// 
			this.authorsBindingSource2.DataMember = "Authors";
			this.authorsBindingSource2.DataSource = this._Model_DataBase_ModelContextDataSet;
			// 
			// BookView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(494, 402);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "BookView";
			this.Text = "BookView";
			this.Load += new System.EventHandler(this.BookView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
		private System.Windows.Forms.Label label3;
		private _Model_DataBase_ModelContextDataSet _Model_DataBase_ModelContextDataSet;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private _Model_DataBase_ModelContextDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
		private System.Windows.Forms.BindingSource authorsBindingSource1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource authorsBindingSource2;
	}
}