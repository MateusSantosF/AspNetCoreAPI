using Learn.Business;
using Learn.Models;
using Microsoft.AspNetCore.Mvc;


namespace Learn.Controllers{

    [ApiController]
    
    [Route("api/[controller]")]
    public class BookController : ControllerBase{

        private readonly IBookBusiness _business;
        public BookController(IBookBusiness business){
            _business = business;
        }
        
        [HttpGet]
        public IActionResult ListAll(){
            
            return Ok(_business.ListAll());
        }

        [HttpGet("{id}")]
        public IActionResult ListById(long id){
            return Ok(_business.ListById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Book book){

            return Ok(_business.Create(book));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Book book){
            return Ok(_business.Update(book));
        }
    }
}