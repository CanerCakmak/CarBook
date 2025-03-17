using CarBook.Application.Bases;
using CarBook.Application.Features.Auth.Rules;
using CarBook.Application.Interfaces.AutoMapper;
using CarBook.Application.Interfaces.Tokens;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Auth.Commands.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        private readonly AuthRules authRules;
        private readonly ITokenService tokenService;

        public LoginCommandHandler(UserManager<User> userManager,IConfiguration configuration,AuthRules authRules,ITokenService tokenService, ICustomMapper customMapper , IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(customMapper,unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.authRules = authRules;
            this.tokenService = tokenService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);

            await authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);

            IList<string> roles = await userManager.GetRolesAsync(user);

            JwtSecurityToken token = await tokenService.CreateToken(user, roles);
            string refreshToken = tokenService.GenerateRefreshToken();

            _ = int.TryParse(configuration["JWT:RefreshTolenValidityInDays"], out int refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpireTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

            await userManager.UpdateAsync(user);
            await userManager.UpdateSecurityStampAsync(user);

            string _token = new JwtSecurityTokenHandler().WriteToken(token);

            await userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", _token);

            return new()
            {
                Token = _token,
                RefreshToken = refreshToken,
                Expiration = token.ValidTo
            };
        }
    }
}
