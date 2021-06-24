using Microsoft.AspNetCore.Mvc;
using People.Library;
using PeopleViewer.Models;
using System;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult UseConsoleLogger()
        {
            IPeopleLogger logger = new ConsoleLogger();
            try
            {
                ViewData["Title"] = "Using Console Logger";
                return GetPeople(logger);
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return View("Error", new ErrorViewModel());
            }
        }

        public IActionResult UseFileLogger()
        {
            IPeopleLogger logger = new FileLogger();
            try
            {
                ViewData["Title"] = "Using FileLogger";
                return GetPeople(logger);

            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return View("Error", new ErrorViewModel());
            }
        }

        private IActionResult GetPeople(IPeopleLogger logger)
        {
            PersonReader reader = new PersonReader();
            var people = reader.GetPeople();
            ViewData["ReaderType"] = reader.GetType().ToString();

            logger?.Log(PeopleLogLevel.Information, "GetPeople action finished");

            return View("Index", people);
        }
    }
}