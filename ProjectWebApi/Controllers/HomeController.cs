using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;
using ServicesHandler;

namespace ProjectWebApi.Controllers
{
    [Route("v2/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IServiceManagement _ServiceManagement;

        public HomeController(IServiceManagement serviceManagement)
        {
            _ServiceManagement = serviceManagement;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            var obj_list = _ServiceManagement.GetAll<Student>();
            return Ok(obj_list);
        }
        [Route("details/{id}")]
        public IActionResult Details(string id)
        {
            var obj = _ServiceManagement.Get<Student>(id);

            return Ok(obj);
        }
        [Route("create")]
        [HttpPost]
        public RedirectToActionResult Create(Student record)
        {
            Student newStudent = _ServiceManagement.Create<Student>(record);
            return RedirectToAction("details", new { id = newStudent.PrimaryId });
        }
        [Route("update/{id}")]
        [HttpPut]
        public RedirectToActionResult Update(string Id, Student student)
        {
            var st = _ServiceManagement.Get<Student>(Id);
            if (st != null)
            {
                _ServiceManagement.UpdateInfo(Id, student);
            }
            _ServiceManagement.UpdateInfo<Student>(Id, student);
            return RedirectToAction("details", new { id = Id });
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public void Delete(string id)
        {
            _ServiceManagement.Delete<Student>(id);
        }
    }
}