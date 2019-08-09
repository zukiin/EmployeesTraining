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
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }

        [DisplayName("Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        public string Status { get; set; }
    }
}
