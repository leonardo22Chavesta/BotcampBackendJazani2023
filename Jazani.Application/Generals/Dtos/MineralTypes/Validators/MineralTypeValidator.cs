using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Jazani.Application.Generals.Dtos.MineralTypes.Validators
{
    public class MineralTypeValidator : AbstractValidator<MineralTypeSaveDto>
    {
        public MineralTypeValidator() 
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();

        }
    }
}
