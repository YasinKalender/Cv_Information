using Cv_Information.DTOs.Dto.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class EducationUpdateValidator:AbstractValidator<EducationUpdateDto>
    {

        public EducationUpdateValidator()
        {
            RuleFor(i => i.Title).NotNull().WithMessage("Bu alan zorunlu alan");
            RuleFor(i => i.UnderTitle).NotNull().WithMessage("Bu alan zorunlu alan");
            RuleFor(i => i.AppUserID).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir user seçiniz");
        }
    }
}
