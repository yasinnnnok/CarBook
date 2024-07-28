using Applicaton.Features.Mediator.Commands.FooaterAdressCommands;
using Applicaton.Features.Mediator.Queries.FooterAdressQueries;
using CarBook.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAdressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAdressController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> FooterAdressList()
        {
            var values = await _mediator.Send(new GetFooterAdressQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterAdress(CreateFooterAdressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt adres Bilgisi eklendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooaterAdress(int id)
        {
            var value = await _mediator.Send(new GetFooterAdressByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAdress (int id)
        {
            await _mediator.Send(new RemoveFooterAdressCommand(id));
            return Ok("Alt adres bilgisi silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAdress(UpdateFooterAdressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt adres bilgisi güncellendi.");
        }

    }
}
