using AutoMapper;
using Cv_Information.DTOs.Dto.AboutDtos;
using Cv_Information.DTOs.Dto.AppUserDtos;
using Cv_Information.DTOs.Dto.EducationDtos;
using Cv_Information.DTOs.Dto.ExperienceDtos;
using Cv_Information.DTOs.Dto.SkillsDto;
using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv_Information.UI.Mapping.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AboutAddViewModel, Abouts>();
            CreateMap<Abouts, AboutAddViewModel>();
            CreateMap<AboutUpdateModel, Abouts>();
            CreateMap<Abouts, AboutUpdateModel>();

            CreateMap<AppUserRegister, AppUser>();
            CreateMap<AppUser, AppUserRegister>();
            CreateMap<AppUserSıgn, AppUser>();
            CreateMap<AppUser, AppUserSıgn>();

            CreateMap<EducationUpdateDto, Education>();
            CreateMap<Education, EducationUpdateDto>();

            CreateMap<ExperienceAddDto, Experience>();
            CreateMap<Experience, ExperienceAddDto>();

            CreateMap<SkillAddUpdateDto, Skills>();
            CreateMap<Skills, SkillAddUpdateDto>();





        }


    }
}
