namespace Jazani.Application.Admins.Dtos.Requirements
{
    public class RequirementSaveDto
    {
        public string Name { get; set; } = default;
        public int ProcedureId { get; set; } = default;
        public int? Percent { get; set; }
    }
}
