using Customer.Business.Abstract;
using Customer.DataAccess.Abstract;
using Customer.DataAccess.Concrete;
using Customer.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Business.Concrete
{
	public class CustomerManager : ICustomerService
	{
		private ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository repository)
        {
			_customerRepository = repository;
        }
        public void CreateCustomer(Customerr customerr)
		{
			_customerRepository.Add(customerr);
		}

		public void Delete(Customerr customer)
		{
			_customerRepository.Delete(customer);
		}

		public List<Customerr> GetAllCustomers()
		{
			return _customerRepository.GetAll();
		}

		public Customerr GetCustomerById(int id)
		{
			return _customerRepository.Get(p => p.CustomerId == id);
		}

		public void Update(Customerr customerr)
		{
			_customerRepository.Update(customerr);
		}
	}
}
