using CarBook.Application.Features.Contacts.Commands.CreateContact;
using CarBook.Application.Features.Contacts.Commands.DeleteContact;
using CarBook.Application.Features.Contacts.Commands.RemoveContact;
using CarBook.Application.Features.Contacts.Commands.UpdateContact;
using CarBook.Application.Features.Contacts.Queries.GetContactById;
using CarBook.Application.Features.Contacts.Queries.GetAllContacts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactsController : Controller
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContacts()
        {
            var response = await _mediator.Send(new GetAllContactsQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactByID(int id)
        {
            var response = await _mediator.Send(new GetContactByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("İletişim Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("İletişim Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(DeleteContactCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("İletişim Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveContact(RemoveContactCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("İletişim Başarıyla Sistemden Silindi");
        }

    }
}
