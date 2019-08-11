using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTrainingProgram.Data;
using EmployeeTrainingProgram.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTrainingProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProgramController : ControllerBase
    {
        private ApplicationDbContext db; //works with services
        public TrainingProgramController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TrainingProgram>> GetTrainingPrograms()
        {
            return db.TrainingPrograms.ToList();
        }

        [HttpPost]
        public ActionResult<HttpResponse> AddTrainingPrograms(TrainingProgram trainingProgram)
        {
            if(ModelState.IsValid)
            {
                db.TrainingPrograms.Add(trainingProgram);
                db.SaveChanges();
                return Ok(trainingProgram);
            }
            else
            {
                return BadRequest("Oops! The data you passed is invalid.");
            }          
        }
    }
}