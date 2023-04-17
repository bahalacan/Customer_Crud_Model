using Customer.Business.Abstract;
using Customer.Business.Concrete;
using Customer.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		ICustomerService _customerService;
		public CustomerController(ICustomerService service)
		{
			_customerService = service;
		}
		[HttpGet("{id}")]
		public Customerr Get(int id)
		{
			return _customerService.GetCustomerById(id);
		}
		[HttpGet]
		public List<Customerr> GetAll()
		{
			return _customerService.GetAllCustomers();
		}
		[HttpPost]
		public void Post(Customerr customerr)
		{
			_customerService.CreateCustomer(customerr);
		}

		[HttpPut]
		public void Put(Customerr customerr)
		{
			_customerService.Update(customerr);
		}

		[HttpDelete]
		public void Delete(Customerr customerr)
		{
			_customerService.Delete(customerr);
		}

	}
}
