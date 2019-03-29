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
        public void Insert([FromBody] Card card)
        {
            _service.Add(card);
        }

        [HttpDelete]
        [Route("v1/card/{id}")]
        public void Delete(Guid id)
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
        public CardDto GetById(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        [Route("v1/card")]
        public void Update([FromBody]CardDto cardDto)
        {
            _service.Update(cardDto);
        }
    }
}