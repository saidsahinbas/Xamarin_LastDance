using System.Collections.Generic;

namespace WebServiceProject.Models.Resources
{
    public class UserResource
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
