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
        [Route("v1/transaction/deposit")]
        public void Deposit([FromRoute] TransactionDto transactionDto)
        {
            _service.Deposit(transactionDto);
        }

        [HttpPost]
        [Route("v1/transaction/withdrawal")]
        public void Withdrawal([FromRoute] TransactionDto transactionDto)
        {
            _service.Withdrawal(transactionDto);
        }

        [HttpDelete]
        [Route("v1/transaction/{id}")]
        public void Delete([FromRoute] Guid id)
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
        public TransactionDto GetById([FromRoute] Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        [Route("v1/transaction")]
        public void Update([FromRoute] TransactionDto transactionDto)
        {
            _service.Update(transactionDto);
        }
    }
}