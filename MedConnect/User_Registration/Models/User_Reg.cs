using System.ComponentModel.DataAnnotations;
namespace User_Registration.Models
{
    public class User_Reg
    {
        [Key]

        public int UserId { get; set; }

        public string? UserName { get; set; }

        public int UserAge { get; set; }

        public char UserGender { get; set; }

        public string? UserEmail { get; set; }

        public long UserContactNumber { get; set; }

    }

}

