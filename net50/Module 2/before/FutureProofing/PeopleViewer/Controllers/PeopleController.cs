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
            // TODO: Get data

            ViewData["Title"] = "Using Concrete Type";
            return View("Index", null);
        }

        public IActionResult UseAbstractType()
        {
            // TODO: Get data

            ViewData["Title"] = "Using Abstract Type";
            return View("Index", null);
        }
    }
}