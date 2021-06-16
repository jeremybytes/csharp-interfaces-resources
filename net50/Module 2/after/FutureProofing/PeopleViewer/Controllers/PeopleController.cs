using System.Collections.Generic;
using Common;
using Microsoft.AspNetCore.Mvc;
using People.Library;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        PersonReader reader = new PersonReader();

        public IActionResult UseConcreteType()
        {
            List<Person> people = reader.GetPeople();

            ViewData["Title"] = "Using Concrete Type";
            return View("Index", people);
        }

        public IActionResult UseAbstractType()
        {
            IEnumerable<Person> people = reader.GetPeople();

            ViewData["Title"] = "Using Abstract Type";
            return View("Index", people);
        }
    }
}