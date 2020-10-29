using Cv_Information.DTOs.Dto.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegister>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(i => i.Username).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(i => i.FirstName).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(i => i.Pass).NotNull().WithMessage("Bu alan boş geçielemez");
            //RuleFor(i => i.Pass).Equal(i => i.Pass);
            RuleFor(i => i.Email).NotNull().WithMessage("E mail alanı boş geçielemez").EmailAddress().WithMessage("Geçerli email adresi giriniz");
        }


    }
}
