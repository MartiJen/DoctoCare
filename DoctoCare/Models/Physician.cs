using DoctoCare.Interfaces;

namespace DoctoCare.Models
{
    public class Physician : IUtilisateur
    {
        public int Id { get; set; }   
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string speciality { get; set; }
        public string Address { get; set; }
        public string SchoolCareer { get; set; }
        public string Experience { get; set; }
        public string CarteImageUrl { get; set; }

        public virtual ICollection<RendezVous> RendezVous { get; set; }
    }
}
