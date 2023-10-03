
namespace Jazani.Domain.Admins.Models
{
    public class Requirement
    {
        public long Id { get; set; }
        public string Name { get; set; } = default;
        public int ProcedureId { get; set; } = default;
        public int? Percent { get; set; } 
        public DateTime RegistrationDate { get; set; } 
        public bool State { get; set; }

        public Procedure procedure { get; set; }
        
    }

    public class Procedure
    {
        public long Id { get; set; }
    }
}
