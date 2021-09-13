﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Services;
using SistemaWebMVC.Models;
using SistemaWebMVC.Models.ViewModels;
using SistemaWebMVC.Services.Exceptions;

namespace SistemaWebMVC.Controllers
{
    public class TraineesController : Controller
    {

        private readonly TraineeService _traineeService;
        private readonly DepartmentService _departmentService;
        public TraineesController(TraineeService traineeService, DepartmentService departmentService)
        {
            _traineeService = traineeService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var list = _traineeService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new TraineeFormViewModel { Departments = departments }; 
            return View(viewModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Trainee trainee)
        {
            _traineeService.Insert(trainee);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _traineeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(int id)
        {
            _traineeService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _traineeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _traineeService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            List<Department> departments = _departmentService.FindAll();

            TraineeFormViewModel viewModel = new TraineeFormViewModel { Trainee = obj, Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit (int id, Trainee trainee)
        {
            if (id != trainee.Id)
            {
                return BadRequest();
            }
            try
            {
                _traineeService.Update(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
        
    }
}
