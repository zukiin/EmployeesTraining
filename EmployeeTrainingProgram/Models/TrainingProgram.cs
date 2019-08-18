using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrainingProgram.Models
{
    public class TrainingProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgramID { get; set; }

        [Required(ErrorMessage = "Certificate name is required.")]
        [StringLength(70)]
        [DisplayName("Certificate Name")]
        public string CertificateName { get; set; }

        [StringLength(20)]
        public string Group { get; set; }

        [DisplayName("Issue Date")]
        public DateTime? IssueDate = null;

        [DisplayName("Expiry Date")]
        public DateTime? ExpiryDate = null;

        [Required]
        public string Status;

        public string GetStatus()
        {
            if(ExpiryDate < DateTime.Now)
            {
                return Status = "<span style=\'background-color:Green'>Not Issued</span>";
            }
            else if(IssueDate != null && ExpiryDate == null)
            {
                return Status = "<span style=\'background-color:Grey'>Permanent</span>";
            }
            else if (IssueDate == null)
            {
                return Status = "<span style=\'background-color:Orange'>Not Issued</span>";
            }
            else
            {
                return Status = "<span style=\'background-color:White'>Expired</span>";
            }
        }
    }
}
