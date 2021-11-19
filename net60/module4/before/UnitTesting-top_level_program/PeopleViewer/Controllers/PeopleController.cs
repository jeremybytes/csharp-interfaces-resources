using Microsoft.AspNetCore.Mvc;
using PersonReader.Factory;
using PersonReader.Interface;

namespace PeopleViewer.Controllers;

public class PeopleController : Controller
{
    private ReaderFactory readerFactory;

    public PeopleController(IConfiguration configuration)
    {
        readerFactory = new ReaderFactory(configuration);
    }

    public IActionResult UseRuntimeReader()
    {
        IPersonReader reader = readerFactory.GetReader();
        IEnumerable<Person> people = reader.GetPeople();

        ViewData["Title"] = "Using a Runtime Reader";
        ViewData["ReaderType"] = reader.GetType().ToString();
        return View("Index", people);
    }

}
