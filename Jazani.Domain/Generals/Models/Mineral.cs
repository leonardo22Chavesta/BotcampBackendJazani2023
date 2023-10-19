using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Domain.Generals.Models
{
    public class Mineral
    {
        public int Id { get; set; }
        public int MineralTypeId { get; set; }
        public string Name { get; set; } = default;
        public string? Description { get; set; }
        public string? Symbol { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

        public virtual MineralType? MineralType  { get; set; }
    }
}
