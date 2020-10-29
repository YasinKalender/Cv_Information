using Cv_Information.DTOs.Dto.AboutDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class AboutUpdateValidator:AbstractValidator<AboutUpdateModel>
    {

        public AboutUpdateValidator()
        {
            RuleFor(i => i.About).NotNull().WithMessage("Bu alan boş geçilemez");
        }
    }
}
