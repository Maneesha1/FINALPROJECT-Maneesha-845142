using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellerServices.Models;
using SellerServices.Repositary;

namespace SellerServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepositary _repo;
        public ItemController(IItemRepositary rep)
        {
            _repo = rep;
        }

        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(Items itemobj)
        {
            try
            {
                _repo.AddItem(itemobj);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        [HttpGet]
        [Route("ViewItems")]
        public IActionResult ViewItems()
        {
            try
            {

                return Ok(_repo.ViewItems());
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpDelete]
        [Route("DeleteItem/{itemid}")]
        public IActionResult DeleteItem(string itemid)
        {
            try
            {
                _repo.DeleteItem(itemid);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem(Items iobj)
        {
            try
            {

                _repo.UpdateItem(iobj);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        [HttpGet]
        [Route("GetItem/{itemid}")]
        public IActionResult GetItem(string itemid)
        {
            try
            {

                return Ok(_repo.GetItem(itemid));
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }





        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories()
        {
            try
            {
                return Ok(_repo.GetCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



        [HttpGet]
        [Route("GetSubCategories/{catid}")]
        public IActionResult GetSubCategories(string catid)
        {
            try
            {
                return Ok(_repo.GetSubCategories(catid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}