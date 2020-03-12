using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Models;
using AdminService.Repositary;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public readonly IAdminRepositary _iadminrepo;
        public AdminController(IAdminRepositary adminrepo)
        {
            _iadminrepo = adminrepo;
        }

        [HttpPost]
        [Route("AddCategories")]
        public IActionResult AddCategories(Category catobj)
        {
            try
            {
                _iadminrepo.AddCategories(catobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }

        }
        [HttpPost]
        [Route("AddSubCategories")]
        public IActionResult AddSubCategories(SubCategory subcatobj)
        {
            try
            {
                _iadminrepo.AddSubCategories(subcatobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }



        [HttpGet]
        [Route("ViewCategories")]
        public IActionResult ViewCategories()
        {
            try
            {

                return Ok(_iadminrepo.ViewCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("ViewSubCategories")]
        public IActionResult ViewSubCategories()
        {
            try
            {

                return Ok(_iadminrepo.ViewSubCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        [HttpPut]
        [Route("EditCategories")]
        public IActionResult EditCategories(Category catobj)
        {
            try
            {
                _iadminrepo.EditCategories(catobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        [HttpPut]
        [Route("EditSubCategories")]
        public IActionResult EditSubCategories(SubCategory subcatobj)
        {
            try
            {
                _iadminrepo.EditSubCategories(subcatobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCategories/{catid}")]
        public IActionResult DeleteCategories(string catid)
        {
            try
            {
                _iadminrepo.DeleteCategories(catid);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteSubCategories/{subcatid}")]
        public IActionResult DeleteSubCategories(string subcatid)
        {
            try
            {
                _iadminrepo.DeleteSubCategories(subcatid);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        [HttpGet]
        [Route("GetSubCatById/{subcatid}")]
        public IActionResult GetSubCatById(string subcatid)
        {
            try
            {

                return Ok(_iadminrepo.GetSubCatById(subcatid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetCatById/{catid}")]
        public IActionResult GetCatById(string catid)
        {
            try
            {

                return Ok(_iadminrepo.GetCatById(catid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

    }
}