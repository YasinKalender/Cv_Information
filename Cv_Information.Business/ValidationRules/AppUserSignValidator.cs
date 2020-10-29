using Cv_Information.DTOs.Dto.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class AppUserSignValidator:AbstractValidator<AppUserSıgn>
    {


        public AppUserSignValidator()
        {
            RuleFor(i => i.Username).NotNull().WithMessage("Bu alan zorunlu alan");
            RuleFor(i => i.Password).NotNull().WithMessage("Bu alan zorunlu alan");
        }
    }
}
