using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class AuthentificationDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
    public class UserRegistrationDto : AuthentificationDto
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
    }
}