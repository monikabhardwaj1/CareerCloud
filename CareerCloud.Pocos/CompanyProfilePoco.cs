using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco
    {

        [Key]
        public Guid Id { get; set; }

        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }

        [Column ("Company_Website")]
        public string CompanyWebsite { get; set; }

        [Column("Company_Phone")]
        public string CompanyPhone { get; set; }

        [Column("Company_Name")]
        public string CompanyName { get; set; }

        [Column("Company_Logo")]
        public Byte[] CompanyLogo { get; set; }

        [Column ("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
    }
}
