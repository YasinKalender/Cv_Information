using Cv_Information.DTOs.Dto.SkillsDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class SkillAddUpdateValidator:AbstractValidator<SkillAddUpdateDto>
    {

        public SkillAddUpdateValidator()
        {
            RuleFor(i => i.Skill).NotNull().WithMessage("bu alan boş geçilmez");
        }
    }
}
