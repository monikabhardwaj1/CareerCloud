using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    public class CompanyLocationPoco
    {
        [Key]
        public Guid ID { get; set; }

        public Guid Company { get; set; }

        [Column("Country_Code")]
        public string CountryCode { get; set; }

        [Column("State_Province_Code")]
        public string StateProvinceCode { get; set; }

        [Column("Street_Address")]
        public string StreetAddresss { get; set; }

        [Column("City_Town")]
        public string CityTown { get; set; }

        [Column("Zip_Postal_Code")]
        public string ZipPostalCode { get; set; }

        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

    }
}
