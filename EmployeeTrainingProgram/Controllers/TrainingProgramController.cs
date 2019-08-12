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
            List<TrainingProgram> programs = new List<TrainingProgram>();
            programs.Add(new TrainingProgram
            {
                ProgramID = 1,
                CertificateName = "Basic Rigging Training",
                Group = "",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 2,
                CertificateName = "Breathing Apparatus Training",
                Group = "",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Not issued"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 3,
                CertificateName = "Diversity Training",
                Group = "",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 4,
                CertificateName = "Electric Hoist Training",
                Group = "Competencies - Licence",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 5,
                CertificateName = "GM Production Bonus Feedback Session",
                Group = "Communication - General",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 6,
                CertificateName = "GM Information Training",
                Group = "Communication - General",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 7,
                CertificateName = "Induction",
                Group = "",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 8,
                CertificateName = "Information Session Section 189",
                Group = "Communication - General",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 9,
                CertificateName = "Medical - Annual",
                Group = "",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Now,
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 10,
                CertificateName = "MS-TEM-SH-TT-006 REV 1.0 The Environment",
                Group = "Communication - Toolbox Talk",
                IssueDate = DateTime.Now,
                ExpiryDate = DateTime.Today,
                Status = "Not issued"
            });

            return programs;
            //return db.TrainingPrograms.ToList();
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