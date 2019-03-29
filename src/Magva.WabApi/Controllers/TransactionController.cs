using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Magva.WabApi.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _service;

        public TransactionController(ITransactionService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("v1/transaction")]
        public void Insert([FromBody] Transaction transaction)
        {
            _service.Add(transaction);
        }

        [HttpDelete]
        [Route("v1/transaction/{id}")]
        public void Delete(Guid id)
        {
            _service.Remove(id);
        }

        [HttpGet]
        [Route("v1/transaction")]
        public IEnumerable<TransactionDto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("v1/transaction/{id}")]
        public TransactionDto GetById(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        [Route("v1/transaction")]
        public void Update([FromBody]TransactionDto transactionDto)
        {
            _service.Update(transactionDto);
        }
    }
}