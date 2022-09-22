﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitorManagementSystem.Models;
using VisitorManagementSystem.Services;
using static VisitorManagementSystem.Enum.SweetAlertEnum;

namespace VisitorManagementSystem.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ITextFileOperations _textFileOperations;
        private readonly IDataSeeder _dataSeeder;
        private readonly ISweetAlert _sweetAlert;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment, ITextFileOperations textFileOperations, IDataSeeder dataSeeder, ISweetAlert sweetAlert)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _textFileOperations = textFileOperations;
            _dataSeeder = dataSeeder;
            _sweetAlert = sweetAlert;
        }

        public IActionResult Index()
        {
            TempData["notification"] = _sweetAlert.AlertPopupWithImage("The Visitor Management System", "Automate and record visitor management", "images/logo.png", NotificationType.success);

            //run the dataseeder
            _dataSeeder.SeedAsync();
            ViewBag.Welcome = "Welcome to the VMS";

            ViewBag.VisitorsNew = new Visitors()
            {
                FirstName = "Howard",
                LastName = "The Barbarian"
            };
            ViewData["AnotherWelcome"] = "Please enter your Name";
            ViewData["Conditions"] = _textFileOperations.LoadConditionsOfAcceptance();

            //====== Conditions of Acceptance
            //Gets or sets the absolute path to the directory that contains the web-servable application content files. 
            string rootPath = _webHostEnvironment.WebRootPath;
            //Get a path to the file by adding the filename to the path
            FileInfo filePath = new FileInfo(Path.Combine(rootPath, "ConditionsForAdmittance.txt"));
            //now we have access to the file, lets read all the lines in to a string array, each line is a separate entry in the array
            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            //then add the string array of the conditions to the ViewData to show on the front.
            ViewData["Conditions"] = lines;
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}