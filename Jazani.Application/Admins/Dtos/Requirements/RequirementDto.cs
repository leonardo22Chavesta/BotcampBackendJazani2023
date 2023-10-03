namespace Jazani.Application.Admins.Dtos.Requirements
{
    public class RequirementDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = default;
        public int ProcedureId { get; set; } = default;
        public int? Percent { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
