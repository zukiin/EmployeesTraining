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
        [HttpGet]
        public ActionResult<IEnumerable<TrainingProgram>> GetTrainingPrograms()
        {
            List<TrainingProgram> programs = new List<TrainingProgram>();
            programs.Add(new TrainingProgram
            {
                ProgramID = 1,
                CertificateName = "Basic Rigging Training",
                Group = "",
                IssueDate = new DateTime(2018, 02, 09),
                ExpiryDate = null,
                Status = "Permanent"
            }) ;
            programs.Add(new TrainingProgram
            {
                ProgramID = 2,
                CertificateName = "Breathing Apparatus Training",
                Group = "",
                IssueDate = null,
                ExpiryDate = null,
                Status = "Not issued"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 3,
                CertificateName = "Diversity Training",
                Group = "",
                IssueDate = new DateTime(2017, 11, 29),
                ExpiryDate = null,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 4,
                CertificateName = "Electric Hoist Training",
                Group = "Competencies - Licence",
                IssueDate = new DateTime(2018, 03, 14),
                ExpiryDate = new DateTime(2018, 03, 14),
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 5,
                CertificateName = "GM Production Bonus Feedback Session",
                Group = "Communication - General",
                IssueDate = new DateTime(2019, 06, 14),
                ExpiryDate = null,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 6,
                CertificateName = "GM Information Training",
                Group = "Communication - General",
                IssueDate = new DateTime(2018, 11, 13),
                ExpiryDate = null,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 7,
                CertificateName = "Induction",
                Group = "",
                IssueDate = new DateTime(2019, 02, 06),
                ExpiryDate = new DateTime(2020, 02, 06),
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 8,
                CertificateName = "Information Session Section 189",
                Group = "Communication - General",
                IssueDate = new DateTime(2019, 05, 31),
                ExpiryDate = null,
                Status = "Permanent"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 9,
                CertificateName = "Medical - Annual",
                Group = "",
                IssueDate = new DateTime(2019, 05, 09),
                ExpiryDate = new DateTime(2020, 05, 09),
                Status = "Valid"
            });
            programs.Add(new TrainingProgram
            {
                ProgramID = 10,
                CertificateName = "MS-TEM-SH-TT-006 REV 1.0 The Environment",
                Group = "Communication - Toolbox Talk",
                IssueDate = null,
                ExpiryDate = null,
                Status = "Not issued"
            });

            return programs;
        }
    }
}