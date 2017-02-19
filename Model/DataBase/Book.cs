﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		
		public int AuthorId { get; set; }
		[ForeignKey("AuthorId")]
		public Author Author { get; set; }
	}
}