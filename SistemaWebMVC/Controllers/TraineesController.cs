using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Services;

namespace SistemaWebMVC.Controllers
{
    public class TraineesController : Controller
    {

        private readonly TraineeService _traineeService;
        public TraineesController(TraineeService traineeService)
        {
            _traineeService = traineeService;
        }
        public IActionResult Index()
        {
            var list = _traineeService.FindAll();
            return View(list);
        }
    }
}
