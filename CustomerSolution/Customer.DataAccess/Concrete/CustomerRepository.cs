using Common.DataAccess;
using Customer.DataAccess.Abstract;
using Customer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DataAccess.Concrete
{
	public class CustomerRepository :  EntityRepositoryBase<Customerr, CustomerContext>, ICustomerRepository
	{
	}
}
