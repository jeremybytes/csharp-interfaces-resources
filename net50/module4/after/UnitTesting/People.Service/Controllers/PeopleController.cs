using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using People.Service.Models;
using PersonReader.Interface;

namespace People.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<PeopleController> _logger;
        private readonly IPeopleProvider _provider;

        public PeopleController(IPeopleProvider provider,
            ILogger<PeopleController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _provider.GetPeople();
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _provider.GetPeople().First(p => p.Id == id);
        }
    }
}
