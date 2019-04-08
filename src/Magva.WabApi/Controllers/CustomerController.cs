using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Magva.WabApi.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("v1/customers")]
        public CustomerDto Insert([FromBody] CustomerDto customerDto)
        {
            return _service.Register(customerDto);
        }

        [HttpDelete]
        [Route("v1/customers/{id}")]
        public void Delete([FromRoute] Guid id)
        {
            _service.Delete(id);
        }

        [HttpGet]
        [Route("v1/customers")]
        public IEnumerable<CustomerDto> GetAll()
        {
            return _service.GetAllCustomers();
        }

        [HttpGet]
        [Route("v1/customers/{id}")]
        public CustomerDto GetById([FromRoute] Guid id)
        {
            return _service.GetCustomerById(id);
        }

        [HttpPut]
        [Route("v1/customers")]
        public CustomerDto Update([FromRoute] CustomerDto customer)
        {
           return  _service.Update(customer);
        }

    }
}