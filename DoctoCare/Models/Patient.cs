using DoctoCare.Interfaces;

namespace DoctoCare.Models
{
    public class Patient : IUtilisateur
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        // Autres informations de contact...

        // Navigation properties
        public virtual ICollection<RendezVous> RendezVous { get; set; }
       
    }
}
