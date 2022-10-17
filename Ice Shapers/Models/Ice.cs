using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ice_Shapers.Models
{
	public class Ice
	{
        public int Id { get; set; }
        public string Title { get; set; }

        //[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
   
	}
}
