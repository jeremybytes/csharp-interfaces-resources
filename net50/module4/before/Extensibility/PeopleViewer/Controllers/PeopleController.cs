using Microsoft.AspNetCore.Mvc;
using PersonReader.Factory;
using PersonReader.Interface;
using System.Collections.Generic;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        private ReaderFactory readerFactory = new ReaderFactory();

        public IActionResult UseService()
        {
            ViewData["Title"] = "Using a Web Service";
            return PopulatePeopleView("Service");
        }

        public IActionResult UseCSV()
        {
            ViewData["Title"] = "Using a CSV File";
            return PopulatePeopleView("CSV");
        }

        public IActionResult UseSQL()
        {
            ViewData["Title"] = "Using a SQL Database";
            return PopulatePeopleView("SQL");
        }

        private IActionResult PopulatePeopleView(string readerType)
        {
            IPersonReader reader = readerFactory.GetReader(readerType);
            IEnumerable<Person> people = reader.GetPeople();

            ViewData["ReaderType"] = reader.GetType().ToString();
            return View("Index", people);
        }
    }
}