using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DTOs.Dto.AppUserDtos
{
    public class AppUserUpdateDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Pass { get; set; }

        public string Image { get; set; }

        public string Telephone { get; set; }

        public string Adress { get; set; }
    }
}
