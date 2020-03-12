using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AccountServices.Models;
using AccountServices.Repositary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AccountServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IConfiguration message;
        private readonly IAccountRepositary _repo;
        public AccountController(IAccountRepositary rep, IConfiguration configuration)
        {
            _repo = rep;
            this.configuration = configuration;

        }
        [HttpPost]
        [Route("BuyerRegister")]
        public IActionResult BuyerRegister(Buyer obj)
        {
            try
            {
                _repo.BuyerRegister(obj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("SellerRegister")]
        public IActionResult SellerRegister(Seller obj)
        {
            try
            {
                _repo.SellerRegister(obj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("BuyerLogin/{username}/{pwd}")]
        public IActionResult BuyerLogin(string username, string pwd)
        {
            Token token = null;
            try
            {

                Buyer buyer = _repo.BuyerLogin(username, pwd);
                if (buyer != null)
                {
                    token = new Token() { BuyerId = buyer.BuyerId, token = GenerateJwtToken(username), message = "success", username = username };
                }
                else
                {
                    token = new Token() { token = null, message = "unsuccess" };
                }
                return Ok(token);

            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        //    try
        //    {
        //        return Ok(GenerateJwtToken(username));
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.InnerException.Message);
        //    }
        //}
        [HttpGet]
        [Route("SellerLogin/{username}/{pwd}")]
        public IActionResult SellerLogin(string username, string pwd)
        {
            Token token = null;
            try
            {

                Seller seller = _repo.SellerLogin(username, pwd);
                if (seller != null)
                {
                    token = new Token() { SellerId = seller.SellerId, token = GenerateJwtToken(username), message = "success", username = username };
                }
                else
                {
                    token = new Token() { token = null, message = "unsuccess" };
                }
                return Ok(token);

            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        //    try
        //    {
        //        return Ok(_repo.SellerLogin(username, pwd));
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.InnerException.Message);
        //    }
        //}
        private string GenerateJwtToken(string uname)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, uname),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, uname),
                new Claim(ClaimTypes.Role,uname)
            };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            // recommended is 5 min
            var expires = DateTime.Now.AddDays(Convert.ToDouble(configuration["JwtExpireDays"]));
            var token = new JwtSecurityToken(
                configuration["JwtIssuer"],
                configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            //var response = new Token
            //{
            //    uname = uname,
            //    token = new JwtSecurityTokenHandler().WriteToken(token)
            //};
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

