using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities.Models
{
	public class Customerr : IEntity
	{
		[Key]
		public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
    }
}
