using Magva.Infra.Crosscutting.DataTransferObject;
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
        [Route("v1/transactions/deposit")]
        public void Deposit([FromBody] TransactionDto transactionDto)
        {
            _service.Deposit(transactionDto);
        }

        [HttpPost]
        [Route("v1/transactions/withdrawal")]
        public void Withdrawal([FromBody] TransactionDto transactionDto)
        {
            _service.Withdrawal(transactionDto);
        }

        [HttpDelete]
        [Route("v1/transactions/{id}")]
        public void Delete([FromRoute] Guid id)
        {
            _service.Remove(id);
        }

        [HttpGet]
        [Route("v1/transactions")]
        public IEnumerable<TransactionDto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("v1/transactions/{id}")]
        public TransactionDto GetById([FromRoute] Guid id)
        {
            return _service.GetById(id);
        }
      
    }
}