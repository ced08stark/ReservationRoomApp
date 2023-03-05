using Microsoft.AspNetCore.Mvc.Rendering;

namespace Catalogue.web.Models
{
    public class UserModel
    {
       
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Profile { get; set; }
            public string Picture { get; set; }
            public IEnumerable<SelectListItem> Profiles { get; set; }
            public int ProfilesSelectValue { get; set; }


            public UserModel()
            {

            }

            public UserModel(int id, string username, string password, DateTime createdAt, string profile, string picture)
            {
                Id = id;
                Username = username;
                Password = password;
                CreatedAt = createdAt;
                Profile = profile;
                Picture = picture;
            }

            public UserModel(int id, string username, string password, DateTime createdAt, string profile, string picture, IEnumerable<SelectListItem> profiles) : this(id, username, password, createdAt, profile, picture)
            {
                Profiles = profiles;
            }
        }
    
}
