using Microsoft.AspNetCore.Mvc;
using PersonReader.Interface;

namespace PeopleViewer.Controllers;

public class PeopleController : Controller
{
    private IPersonReader reader;

    public PeopleController(IPersonReader dataReader)
    {
        reader = dataReader;
    }

    public IActionResult UseRuntimeReader()
    {
        IEnumerable<Person> people = reader.GetPeople();

        ViewData["Title"] = "Using a Runtime Reader";
        ViewData["ReaderType"] = reader.GetType().ToString();
        return View("Index", people);
    }

}
