﻿using Day8.Models;
using Day8.Services;
using Day8.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day8.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View(employeeService.GetAll());
        }
        public IActionResult GetById(int id)
        {
            return View(employeeService.GetById(id));
        }
        public IActionResult delete(int id)
        {
            employeeService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult Edit(Employee emp)
        //{
        //    employeeService.Edit(emp);
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpGet]
        public IActionResult Add()
        {
            return View(employeeService.GetAll());
        }
        [HttpPost]
        public IActionResult Add(Employee emp)
        {
            employeeService.Add(emp);
            return RedirectToAction(nameof(Index));
        }
    }
}
