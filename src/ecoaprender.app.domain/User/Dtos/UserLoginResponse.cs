using System.Collections.Generic;
using ecoaprender.app.domain.Student.Dtos;

namespace ecoaprender.app.domain.User.Dtos
{
    public class UserLoginResponse
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }

        public string Email { get; set; }        

        public string Name { get; set; }

        public List<ecoaprender.app.domain.Student.Dtos.Student> Students { get; set; }
    }
}