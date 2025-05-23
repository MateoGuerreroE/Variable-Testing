using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class User
    {
        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }
    }
}