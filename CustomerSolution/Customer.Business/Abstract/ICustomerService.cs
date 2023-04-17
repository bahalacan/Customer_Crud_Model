using Customer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Business.Abstract
{
	public interface ICustomerService
	{
		List<Customerr> GetAllCustomers();
		Customerr GetCustomerById(int id);
		void CreateCustomer(Customerr customerr);
		void Update(Customerr customerr);
		void Delete(Customerr customerr);

	}
}
