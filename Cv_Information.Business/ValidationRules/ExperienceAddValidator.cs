using Cv_Information.DTOs.Dto.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class ExperienceAddValidator:AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddValidator()
        {
            RuleFor(i => i.Title).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(i=>i.UnderTitle).NotNull().WithMessage("Bu alan boş geçilemez");
           
        }

    }
}
