﻿using CarBook.Application.Features.Auth.Commands.Login;
using CarBook.Application.Features.Auth.Commands.RefreshToken;
using CarBook.Application.Features.Auth.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response = await mediator.Send(request);

            return StatusCode(StatusCodes.Status200OK,response);
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);

            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
