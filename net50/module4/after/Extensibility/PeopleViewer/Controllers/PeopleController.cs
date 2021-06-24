using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PersonReader.Factory;
using PersonReader.Interface;
using System.Collections.Generic;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        private ReaderFactory readerFactory = new ReaderFactory();

        IConfiguration Configuration;

        public PeopleController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult UseConfiguredReader()
        {
            string readerType = Configuration["PersonReaderType"];
            ViewData["Title"] = "Using Configured Reader";
            return PopulatePeopleView(readerType);
        }

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