namespace CareNet_System.ViewModels
{
    public class BillsViewModels
    {
        public int Id { get; set; }

        public double total_amount { get; set; }

        public string Payment_Method { get; set; }

        public int patient_id { get; set; }

        public int insurance_id { get; set; }

    }
}

