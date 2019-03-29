using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Magva.WabApi.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _service;

        public CardController(ICardService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("v1/card")]
        public void Insert([FromRoute] CardDto cardDto)
        {
            _service.Add(cardDto);
        }

        [HttpDelete]
        [Route("v1/card/{id}")]
        public void Delete([FromRoute]Guid id)
        {
            _service.Remove(id);
        }

        [HttpGet]
        [Route("v1/card")]
        public IEnumerable<CardDto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("v1/card/{id}")]
        public CardDto GetById([FromRoute] Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        [Route("v1/card")]
        public void Update([FromRoute] CardDto cardDto)
        {
            _service.Update(cardDto);
        }
    }
}