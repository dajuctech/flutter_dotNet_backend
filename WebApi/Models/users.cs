using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Users
    {
        [Key]
        public int userid { get; set; }

        [Required]
        public string name { get; set; } = "";

        public string address { get; set; } = "";
    }
}
