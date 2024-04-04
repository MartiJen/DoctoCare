namespace DoctoCare.Models
{
    public class RendezVous
    {
        public int RendezVousId { get; set; }
        public DateTime Date { get; set; }
        public string Commentary { get; set; }

        // Clés étrangères
        public int PatientId { get; set; }
        public int PhysicianId { get; set; }

        // Navigation properties
        public virtual Patient Patient { get; set; }
        public virtual Physician Physician { get; set; }
    }
}
