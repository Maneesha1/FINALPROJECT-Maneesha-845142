using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyerService.Models;
using BuyerService.Repositary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerRepositary _repo;
        public BuyerController(IBuyerRepositary rep)
        {
            _repo = rep;
        }
        [HttpPost]
        [Route("BuyItem")]

        public IActionResult BuyItem(Transactionhistory obj)
        {
            try
            {
                _repo.BuyItem(obj);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("EditProfile")]

        public IActionResult EditProfile(Buyer obj)
        {
            try
            {
                _repo.EditProfile(obj);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet]
        [Route("SearchItems/{name}")]
        public IActionResult SearchItems(string name)
        {
            try
            {
                return Ok(_repo.SearchItems(name));
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewProfile/{id}")]

        public IActionResult ViewProfile(string id)
        {
            try
            {
                return Ok(_repo.ViewProfile(id));
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        ////[HttpGet]
        ////[Route("ViewProfile")]
        ////public IActionResult ViewProfile()
        ////{
        ////    try
        ////    {

        ////        return Ok(_repo.ViewProfile());
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        return NotFound(ex.InnerException.Message);
        ////    }
        ////}

        //[HttpGet]
        //[Route("TransactionHistory/{id}")]

        //public IActionResult TransactionHistory(string id)
        //{
        //    try
        //    {
        //        return Ok(_repo.TransactionHistory(id));
        //    }

        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}
        [HttpPost]
        [Route("Addtocart")]

        public IActionResult Addtocart(Cart cartobj)
        {
            try
            {
                _repo.Addtocart(cartobj);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("Deletefromcart/{cartid}")]
        public IActionResult Deletefromcart(string cartid)
        {
            try
            {
                _repo.Deletefromcart(cartid);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        [HttpGet]
        [Route("ViewCart/{bid}")]
        public IActionResult ViewCart(string bid)
        {
            try
            {

                return Ok(_repo.ViewCart(bid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        
                [HttpGet]
        [Route("PurchaseHistory/{bid}")]
        public IActionResult Transactionhistory(string bid)
        {
            try
            {

                return Ok(_repo.Transactionhistory(bid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }



    }
}