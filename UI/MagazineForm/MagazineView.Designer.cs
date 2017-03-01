﻿namespace UI.MagazineForm
{
	partial class MagazineView
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
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Namr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._Model_DataBase_ModelContextDataSet = new UI._Model_DataBase_ModelContextDataSet();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.authorsTableAdapter = new UI._Model_DataBase_ModelContextDataSetTableAdapters.AuthorsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Namr,
            this.Author});
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(349, 172);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			// 
			// Namr
			// 
			this.Namr.HeaderText = "Name";
			this.Namr.Name = "Namr";
			// 
			// Author
			// 
			this.Author.HeaderText = "Author";
			this.Author.Name = "Author";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txt_name);
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 178);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(314, 176);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(184, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Author";
			// 
			// comboBox1
			// 
			this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.comboBox1.DataSource = this.authorsBindingSource;
			this.comboBox1.DisplayMember = "LastName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(187, 47);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.ValueMember = "Id";
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "Authors";
			this.authorsBindingSource.DataSource = this._Model_DataBase_ModelContextDataSet;
			// 
			// _Model_DataBase_ModelContextDataSet
			// 
			this._Model_DataBase_ModelContextDataSet.DataSetName = "_Model_DataBase_ModelContextDataSet";
			this._Model_DataBase_ModelContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(57, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 27);
			this.button2.TabIndex = 11;
			this.button2.Text = "Edite";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 89);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 28);
			this.button1.TabIndex = 10;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(57, 47);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(100, 20);
			this.txt_name.TabIndex = 9;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(57, 19);
			this.txt_id.Name = "txt_id";
			this.txt_id.ReadOnly = true;
			this.txt_id.Size = new System.Drawing.Size(100, 20);
			this.txt_id.TabIndex = 8;
			this.txt_id.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Id";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(320, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(130, 71);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(14, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 37);
			this.button3.TabIndex = 7;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// MagazineView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 366);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MagazineView";
			this.Text = "MagazineView";
			this.Load += new System.EventHandler(this.MagazineView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._Model_DataBase_ModelContextDataSet)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Namr;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Author;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private _Model_DataBase_ModelContextDataSet _Model_DataBase_ModelContextDataSet;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private _Model_DataBase_ModelContextDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
	}
}