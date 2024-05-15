using System.Text.Json.Serialization;

namespace Imdb_API.Models.Entities
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public Guid Userid { get; set; }
        public required string Username { get; set; } = null!;

        public required string Password { get; set; } = null!;

        public required string Email { get; set; } = null!;

        public DateTime Created_at { get; set; } 

        public DateTime Last_login { get; set; } 

    }
}
