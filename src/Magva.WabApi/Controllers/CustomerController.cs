using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
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
        [Route("v1/customer")]
        public void Insert([FromBody] CustomerDto customerDto)
        {
            _service.Register(customerDto);
        }

        [HttpDelete]
        [Route("v1/customer/{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }

        [HttpGet]
        [Route("v1/customer")]
        public IEnumerable<CustomerDto> GetAll()
        {
            return _service.GetAllCustomers();
        }

        [HttpGet]
        [Route("v1/customer/{id}")]
        public CustomerDto GetById(Guid id)
        {
            return _service.GetCustomerById(id);
        }

        [HttpPut]
        [Route("v1/customer")]
        public void Update([FromBody]CustomerDto customer)
        {
            _service.Update(customer);
        }

    }
}