namespace UI.AuthorForm
{
	partial class AuthorView
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
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MidleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Magazine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.magazinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.modelDataBaseModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Model_DataBase_ModelContextDataSet = new UI._Model_DataBase_ModelContextDataSet();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_lname = new System.Windows.Forms.TextBox();
			this.txt_mname = new System.Windows.Forms.TextBox();
			this.txt_fname = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.magazinesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.magazinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.magazinesTableAdapter = new UI._Model_DataBase_ModelContextDataSetTableAdapters.MagazinesTableAdapter();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksTableAdapter = new UI._Model_DataBase_ModelContextDataSetTableAdapters.BooksTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modelDataBaseModelContextDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.MidleName,
            this.LastName,
            this.Magazine,
            this.Books});
			this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(659, 239);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Width = 30;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			// 
			// MidleName
			// 
			this.MidleName.HeaderText = "MidleName";
			this.MidleName.Name = "MidleName";
			// 
			// LastName
			// 
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// Magazine
			// 
			this.Magazine.HeaderText = "Magazine";
			this.Magazine.Name = "Magazine";
			this.Magazine.ReadOnly = true;
			// 
			// Books
			// 
			this.Books.HeaderText = "Books";
			this.Books.Name = "Books";
			this.Books.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 259);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 286);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "FirstName";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "MiddleName";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "LastName";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txt_lname);
			this.groupBox1.Controls.Add(this.txt_mname);
			this.groupBox1.Controls.Add(this.txt_fname);
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Location = new System.Drawing.Point(12, 246);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 213);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.magazinesBindingSource1;
			this.comboBox2.DisplayMember = "Name";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(195, 80);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 11;
			this.comboBox2.ValueMember = "Id";
			// 
			// magazinesBindingSource1
			// 
			this.magazinesBindingSource1.DataMember = "Magazines";
			this.magazinesBindingSource1.DataSource = this.modelDataBaseModelContextDataSetBindingSource;
			// 
			// modelDataBaseModelContextDataSetBindingSource
			// 
			this.modelDataBaseModelContextDataSetBindingSource.DataSource = this._Model_DataBase_ModelContextDataSet;
			this.modelDataBaseModelContextDataSetBindingSource.Position = 0;
			// 
			// _Model_DataBase_ModelContextDataSet
			// 
			this._Model_DataBase_ModelContextDataSet.DataSetName = "_Model_DataBase_ModelContextDataSet";
			this._Model_DataBase_ModelContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.booksBindingSource1;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(195, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.ValueMember = "Id";
			// 
			// booksBindingSource1
			// 
			this.booksBindingSource1.DataMember = "Books";
			this.booksBindingSource1.DataSource = this.modelDataBaseModelContextDataSetBindingSource;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(192, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Magazine";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(192, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Books";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(68, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Edite";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(68, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_lname
			// 
			this.txt_lname.Location = new System.Drawing.Point(68, 91);
			this.txt_lname.Name = "txt_lname";
			this.txt_lname.Size = new System.Drawing.Size(100, 20);
			this.txt_lname.TabIndex = 3;
			// 
			// txt_mname
			// 
			this.txt_mname.Location = new System.Drawing.Point(68, 65);
			this.txt_mname.Name = "txt_mname";
			this.txt_mname.Size = new System.Drawing.Size(100, 20);
			this.txt_mname.TabIndex = 2;
			// 
			// txt_fname
			// 
			this.txt_fname.Location = new System.Drawing.Point(68, 39);
			this.txt_fname.Name = "txt_fname";
			this.txt_fname.Size = new System.Drawing.Size(100, 20);
			this.txt_fname.TabIndex = 1;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(68, 13);
			this.txt_id.Name = "txt_id";
			this.txt_id.ReadOnly = true;
			this.txt_id.Size = new System.Drawing.Size(100, 20);
			this.txt_id.TabIndex = 0;
			this.txt_id.Text = "0";
			// 
			// magazinesBindingSource2
			// 
			this.magazinesBindingSource2.DataMember = "Magazines";
			this.magazinesBindingSource2.DataSource = this.modelDataBaseModelContextDataSetBindingSource;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(18, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(111, 33);
			this.button3.TabIndex = 6;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(423, 311);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(147, 77);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// magazinesBindingSource
			// 
			this.magazinesBindingSource.DataMember = "Magazines";
			this.magazinesBindingSource.DataSource = this.modelDataBaseModelContextDataSetBindingSource;
			// 
			// magazinesTableAdapter
			// 
			this.magazinesTableAdapter.ClearBeforeFill = true;
			// 
			// booksBindingSource
			// 
			this.booksBindingSource.DataMember = "Books";
			this.booksBindingSource.DataSource = this.modelDataBaseModelContextDataSetBindingSource;
			// 
			// booksTableAdapter
			// 
			this.booksTableAdapter.ClearBeforeFill = true;
			// 
			// AuthorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(657, 466);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AuthorView";
			this.Text = "Author";
			this.Load += new System.EventHandler(this.AuthorView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modelDataBaseModelContextDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.magazinesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_lname;
		private System.Windows.Forms.TextBox txt_mname;
		private System.Windows.Forms.TextBox txt_fname;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource modelDataBaseModelContextDataSetBindingSource;
		private _Model_DataBase_ModelContextDataSet _Model_DataBase_ModelContextDataSet;
		private System.Windows.Forms.BindingSource magazinesBindingSource;
		private _Model_DataBase_ModelContextDataSetTableAdapters.MagazinesTableAdapter magazinesTableAdapter;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private _Model_DataBase_ModelContextDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MidleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Magazine;
		private System.Windows.Forms.DataGridViewTextBoxColumn Books;
		private System.Windows.Forms.BindingSource magazinesBindingSource2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource booksBindingSource1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource magazinesBindingSource1;
	}
}