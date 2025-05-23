using System.ComponentModel.DataAnnotations.Schema;

namespace CareNet_System.Models
{
    public enum TreatmentType
    {
        Drug, Surgery, Radiation, Chemotherapy, PhysicalTherapy
    }
    public class Patient
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int room_num { get; set; }

        [ForeignKey("staff")]
        public int followUp_doctorID { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public TreatmentType? treatment { get; set; }

        [ForeignKey("department")]
        public int dept_id { get; set; }

        public Department? department { get; set; }
        public Staff? staff { get; set; }

        public List<Bills>? bills { get; set; }
    }
}
