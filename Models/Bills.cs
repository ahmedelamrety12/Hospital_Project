using System.ComponentModel.DataAnnotations.Schema;

namespace CareNet_System.Models
{

    public enum billMethod
    { Cash, Visa }
    public class Bills
    {
        public int Id { get; set; }

        public double total_amount { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public billMethod Payment_Method { get; set; }

        public int insurance_id { get; set; }
        [ForeignKey("patient")]
        public int patient_id { get; set; }
        public Patient? patient { get; set; }

    }
}


 

