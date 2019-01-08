using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UltraCines.Models;

namespace UltraCines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly UltraCinesContext _context; 
        public MoviesController(UltraCinesContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_context.Movies.ToList());
        }
        
        [HttpPost]
        public JsonResult Index([FromBody] Movie movie
        )
        {
            var savedEntity = _context.Movies.Add(movie);
            _context.SaveChanges();
            return Json(savedEntity.Entity);   
        } 
    }
}
