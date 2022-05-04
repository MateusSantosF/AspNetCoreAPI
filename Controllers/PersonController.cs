using Learn.Business;
using Learn.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learn.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;
    private readonly IPersonBusiness _person;

    public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
    {
        _logger = logger;
        _person = personBusiness;
    }

    
    [HttpGet]
    public IActionResult ListAll(){

        return Ok(_person.ListAll());

    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult ListById(long id){
        return Ok(_person.ListById(id));
    }

    [HttpPost]
    public IActionResult Create([FromBody] Person person){
        if(person == null)return BadRequest();
        return Ok(_person.Create(person));
    }

    [HttpPut]
    public IActionResult Update([FromBody] Person person){
        if(person == null)return BadRequest();
        return Ok(_person.Update(person));
    }
}
